using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gym_Management_System.FitnessoDataSet;

namespace Gym_Management_System.Pay
{
    public partial class UpdatePay : Form
    {
        private int selectedPaymentId;

        public UpdatePay()
        {
            InitializeComponent();
            ShowPayment.Visible = true;
            ShowAllPayment();
            OptionsPay.Visible = false;
        }

        private void ShowAllPayment()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT P.IdPayment, P.IdReservation, P.IdUser, TP.Name, P.DateOfPayment " +
                    "FROM PAYMENT AS P INNER JOIN TYPE_PAYMENT AS TP ON P.IdTypePayment = TP.IdTypePayment;", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "TYPE_PAYMENT");

                ShowPayment.DataSource = ds.Tables["TYPE_PAYMENT"];
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

        private void UpdatePayment_Click(object sender, EventArgs e)
        {
            OptionsPay.Visible = true;
            if (ShowPayment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ShowPayment.SelectedRows[0];
                selectedPaymentId = Convert.ToInt32(selectedRow.Cells["IdPayment"].Value);
                
                IdUser.Text = selectedRow.Cells["IdUser"].Value.ToString();
                DataPay.Text = selectedRow.Cells["DateOfPayment"].Value.ToString();

                

               
            }
        }

        private void UpdatePaymentPost_Click(object sender, EventArgs e)
        {
            
            int newUserId = Convert.ToInt32(IdUser.Text);
            DateTime newDateOfPayment = Convert.ToDateTime(DataPay.Text);

            SqlConnection con = new SqlConnection("Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("UPDATE PAYMENT SET IdUser = @UserId, DateOfPayment = @DateOfPayment WHERE IdPayment = @PaymentId", con);
            cmd.Parameters.AddWithValue("@UserId", newUserId);
            cmd.Parameters.AddWithValue("@DateOfPayment", newDateOfPayment);
            cmd.Parameters.AddWithValue("@PaymentId", selectedPaymentId);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Płatność została pomyślnie zaktualizowana!");
                    ShowAllPayment();
                }
                else
                {
                    MessageBox.Show("Aktualizacja płatności nie powiodła się!");
                }
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
    }
}
