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
            LoadTypePayments();
        }

        private void ShowAllPayment()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT P.IdPayment as 'Identyfikator płatności'" +
                    ", P.IdReservation as 'Identyfikator rezerwacji'" +
                    ", P.IdUser as 'Identyfikator użytkownika'" +
                    ", TP.Name 'Typ płatności'" +
                    ", P.DateOfPayment as 'Data rezerwacji' " +
                    "FROM PAYMENT AS P INNER JOIN TYPE_PAYMENT AS TP ON P.IdTypePayment = TP.IdTypePayment;", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PAYMENT");

                ShowPayment.DataSource = ds.Tables["PAYMENT"];
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

        private void UpdatePayment_Click(object sender, EventArgs e)
        {
            
            if (ShowPayment.SelectedRows.Count > 0)
            {
                OptionsPay.Visible = true;
                DataGridViewRow selectedRow = ShowPayment.SelectedRows[0];
                selectedPaymentId = Convert.ToInt32(selectedRow.Cells[0].Value);
                IdReservation.Text = selectedRow.Cells[1].Value.ToString();
                IdUser.Text = selectedRow.Cells[2].Value.ToString();
                DataPay.Text = selectedRow.Cells[4].Value.ToString();
                TypePayment.Text = selectedRow.Cells[3].Value.ToString();
            }
            else
            {
                Answer.Text = "Prodzę wybrać płatność do aktualizacji";

            }

        }

        private void UpdatePaymentPost_Click(object sender, EventArgs e)
        {
            int newUserId = Convert.ToInt32(IdUser.Text);
            DateTime newDateOfPayment = Convert.ToDateTime(DataPay.Text);
            int newTypePaymentId = Convert.ToInt32(TypePayment.SelectedValue);
            int newReservationId  = Convert.ToInt32(IdReservation.Text);
            SqlConnection con = new SqlConnection("Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("UPDATE PAYMENT SET IdReservation = @IdReservation ,IdUser = @UserId, DateOfPayment = @DateOfPayment, IdTypePayment = @TypePaymentId WHERE IdPayment = @PaymentId", con);
            cmd.Parameters.AddWithValue("@IdReservation", newReservationId);
            cmd.Parameters.AddWithValue("@UserId", newUserId);
            cmd.Parameters.AddWithValue("@DateOfPayment", newDateOfPayment);
            cmd.Parameters.AddWithValue("@TypePaymentId", newTypePaymentId);
            cmd.Parameters.AddWithValue("@PaymentId", selectedPaymentId);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Answer.Text = "Płatność została pomyślnie zaktualizowana!";
                    ShowAllPayment();
                }
                else
                {
                    Answer.Text ="Aktualizacja płatności nie powiodła się!";
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
