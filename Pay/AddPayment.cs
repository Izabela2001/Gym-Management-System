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
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
            OptionsPayment.Visible = false;
            AllReservation();
            LoadTypePayments();

        }
        private void AllReservation()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.[IdReservation] AS 'Identyfikator rezerwacji', R.[IdUser] AS 'Identyfikator użytkownika', R.[DateReservation] AS 'Data rezerwacji', R.[IdFitnessClass] AS 'Identyfikator typu zajęć' FROM [Fitnesso].[dbo].[RESERVATION] R LEFT JOIN [Fitnesso].[dbo].[PAYMENT] P ON R.[IdReservation] = P.[IdReservation] WHERE P.[IdPayment] IS NULL", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PAYMENT");

                AllReservationNoPay.DataSource = ds.Tables["PAYMENT"];
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

                TypePaid.DataSource = dt;
                TypePaid.DisplayMember = "Name";
                TypePaid.ValueMember = "IdTypePayment";
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


        private void AddPaymentWithReservation_Click(object sender, EventArgs e)
        {
            if (AllReservationNoPay.SelectedRows.Count > 0)
            {
                OptionsPayment.Visible = true;
                DataGridViewRow selectedRow = AllReservationNoPay.SelectedRows[0];
                IdReservation.Text = selectedRow.Cells[0].Value.ToString();
                IdUsers.Text = selectedRow.Cells[1].Value.ToString();
            }
            else
            {
                Answer.Text = "Proszę wybrać rezerwację, do której chcesz przypisać płatność";
            }

        }

        private void PostPaid_Click(object sender, EventArgs e)
        {
            int IdReservationNew = Convert.ToInt32(IdReservation.Text);
            int IdUserNew = Convert.ToInt32(IdUsers.Text);
            int IdTypePaymentNew = Convert.ToInt32(TypePaid.SelectedValue);
            DateTime newDateOfPayment = Convert.ToDateTime(TimePaid.Text);
            int paymentStatus;
            if (YasPaid.Checked)
            {
                paymentStatus = 1; 
            }
            else
            {
                paymentStatus = 0; 
            }

            int IfPaidNew = paymentStatus;

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();

                string query = "INSERT INTO PAYMENT (IdReservation, IdUser, IdTypePayment, DateOfPayment, IfPaid) VALUES (@IdReservation, @IdUser, @IdTypePayment, @DateOfPayment, @IfPaid)";

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

        private void Return_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Close();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Close();
        }
    }
}
