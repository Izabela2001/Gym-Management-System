using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_Management_System.Pay
{
    public partial class AddPay : Form
    {
        public AddPay()
        {
            InitializeComponent();
            AllReservationNo();
            LoadTypePayments();
            OptionsPayment.Visible = false;
        }

        int paymentStatus; 

        
        private void AllReservationNo()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.[IdReservation] " +
                    "as 'Identyfikator rezerwacji'\r\n      " +
                    ",R.[IdUser] as 'Identyfikator użytkownika'\r\n   " +
                    "   ,R.[DateReservation] as 'Data rezerwacji'\r\n     " +
                    " ,R.[IdFitnessClass] as 'Identyfikator typu zajęć'\r\nFROM " +
                    "[Fitnesso].[dbo].[RESERVATION] R\r\nLEFT JOIN [Fitnesso].[dbo].[PAYMENT]" +
                    " P\r\nON R.[IdReservation] = P.[IdReservation]\r\nWHERE P.[IdPayment] IS NULL", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PAYMENT");

                NoPayid.DataSource = ds.Tables["PAYMENT"]; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message); 
            }
            finally
            {
                con.Close(); 
            }
        }

       
        private void LoadTypePayments()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT IdTypePayment, Name FROM TYPE_PAYMENT", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                TypePayment.DataSource = dt; 
                TypePayment.DisplayMember = "Name"; 
                TypePayment.ValueMember = "IdTypePayment"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message); 
            }
            finally
            {
                con.Close(); 
            }
        }

        
        private void AddPayment_Click(object sender, EventArgs e)
        {
            if (NoPayid.SelectedRows.Count > 0)
            {
                OptionsPayment.Visible = true; 
                DataGridViewRow selectedRow = NoPayid.SelectedRows[0];
                IdReservation.Text = selectedRow.Cells[0].Value.ToString(); 
                IdUser.Text = selectedRow.Cells[1].Value.ToString(); 
            }
            else
            {
                Answer.Text = "Proszę wybrać rezerwację, do której chcesz przypisać płatność"; 
            }
        }

        
        private void AddP_Click(object sender, EventArgs e)
        {
            int IdReservationNew = Convert.ToInt32(IdReservation.Text);
            int IdUserNew = Convert.ToInt32(IdUser.Text);
            int IdTypePaymentNew = Convert.ToInt32(TypePayment.SelectedValue);
            DateTime newDateOfPayment = Convert.ToDateTime(DataPay.Text);
            int IfPaidNew = paymentStatus;

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();

                string query = "INSERT INTO PAYMENT (IdReservation, IdUser, IdTypePayment, DateOfPayment, IfPaid) " +
                               "VALUES (@IdReservation, @IdUser, @IdTypePayment, @DateOfPayment, @IfPaid)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdReservation", IdReservationNew);
                cmd.Parameters.AddWithValue("@IdUser", IdUserNew);
                cmd.Parameters.AddWithValue("@IdTypePayment", IdTypePaymentNew);
                cmd.Parameters.AddWithValue("@DateOfPayment", newDateOfPayment);
                cmd.Parameters.AddWithValue("@IfPaid", IfPaidNew);

                cmd.ExecuteNonQuery();
                Answer.Text = "Płatność została dodana pomyślnie."; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message); 
            }
            finally
            {
                con.Close(); 
            }
        }

        
        private void YesPaid_CheckedChanged(object sender, EventArgs e)
        {
            paymentStatus = 1; 
        }

        
        private void NoPayid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            paymentStatus = 0; 
        }
    }
}