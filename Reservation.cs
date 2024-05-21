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

namespace Gym_Management_System
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            ShowReservation();
        }
        private void ShowReservation()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.IdReservation, R.IdUser as 'Identyfikator użytkownika', R.DateReservation as 'Data rezerwacji'," +
                    " R.IdFitnessClass as 'Identyfikator zajęć'\r\nFROM RESERVATION AS R\r\n", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "RESERVATION");

                ReservationShow.DataSource = ds.Tables["RESERVATION"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void AddReservation_Click(object sender, EventArgs e)
        {
            AddReservation addReservation = new AddReservation();
            addReservation.Show();
            this.Close();
        }

        private void Approve_Reservation_Click(object sender, EventArgs e)
        {
            ApproveReservation approveReservation = new ApproveReservation();
            approveReservation.Show();
            this.Close();
        }

        private void UpdateReservation_Click(object sender, EventArgs e)
        {
            Reservations.UpdateReservation updateReservation = new Reservations.UpdateReservation();
            updateReservation.Show();
            this.Close();
        }

        private void ReturnApp_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Close();
        }

        private void AllReservation_Click(object sender, EventArgs e)
        {
            ShowReservation();
        }

        private void ToDayReservation_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("  SELECT R.IdReservation as 'Identyfikator rezerwacji', R.IdUser as 'Identyfikator użytkownika'," +
                    " R.DateReservation as 'Data rezerwacji', R.IdFitnessClass as 'Identyfikator zajęć'\r\nFROM RESERVATION AS R\r\n" +
                    "WHERE CAST(R.DateReservation AS DATE) = CAST(GETDATE() AS DATE);", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "RESERVATION");

                ReservationShow.DataSource = ds.Tables["RESERVATION"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ShowReservationAfter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.IdReservation, R.IdUser as 'Identyfikator użytkownika', " +
                    "R.DateReservation as 'Data rezerwacji', R.IdFitnessClass as 'Identyfikator zajęć'\r\n" +
                    "FROM RESERVATION AS R\r\nWHERE R.DateReservation < GETDATE()", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "RESERVATION");

                ReservationShow.DataSource = ds.Tables["RESERVATION"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DeleteReservation_Click(object sender, EventArgs e)
        {
            if(ReservationShow.SelectedRows.Count > 0)
            {
                int reservationId = Convert.ToInt32(ReservationShow.SelectedRows[0].Cells["IdReservation"].Value);

               
                DeleteReservationOne(reservationId);
                ShowReservation();
            }
            else
            {
                Return_Reservation.Text = "Proszę wybrać rezerwacje do usunięcia";
                
            }

        }
        
        private void DeleteReservationOne(int reservationId)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();

                
                string getClassQuery = "SELECT IdFitnessClass FROM RESERVATION WHERE IdReservation = @ReservationId";
                SqlCommand getClassCmd = new SqlCommand(getClassQuery, con);
                getClassCmd.Parameters.AddWithValue("@ReservationId", reservationId);
                int classId = (int)getClassCmd.ExecuteScalar();

                
                string paymentCheckQuery = "SELECT COUNT(*) FROM PAYMENT WHERE IdReservation = @ReservationId";
                SqlCommand paymentCheckCmd = new SqlCommand(paymentCheckQuery, con);
                paymentCheckCmd.Parameters.AddWithValue("@ReservationId", reservationId);
                int paymentCount = (int)paymentCheckCmd.ExecuteScalar();

               
                if (paymentCount > 0)
                {
                    DialogResult result = MessageBox.Show("Istnieje powiązana płatność. Czy chcesz usunąć również płatność?", "Usuwanie rezerwacji", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        string paymentDeleteQuery = "DELETE FROM PAYMENT WHERE IdReservation = @ReservationId";
                        SqlCommand paymentDeleteCmd = new SqlCommand(paymentDeleteQuery, con);
                        paymentDeleteCmd.Parameters.AddWithValue("@ReservationId", reservationId);
                        paymentDeleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Płatność została pomyślnie usunięta.");
                    }
                    else
                    {
                        MessageBox.Show("Nie można usunąć rezerwacji, ponieważ istnieje powiązana płatność.");
                        return;
                    }
                }

                
                string reservationDeleteQuery = "DELETE FROM RESERVATION WHERE IdReservation = @ReservationId";
                SqlCommand reservationDeleteCmd = new SqlCommand(reservationDeleteQuery, con);
                reservationDeleteCmd.Parameters.AddWithValue("@ReservationId", reservationId);
                reservationDeleteCmd.ExecuteNonQuery();

                
                string updateActivePlaceQuery = "UPDATE FITNESS_CLASS SET ActivePlace = ActivePlace - 1 WHERE IdFitnessClass = @ClassId";
                SqlCommand updateActivePlaceCmd = new SqlCommand(updateActivePlaceQuery, con);
                updateActivePlaceCmd.Parameters.AddWithValue("@ClassId", classId);
                updateActivePlaceCmd.ExecuteNonQuery();

                MessageBox.Show("Rezerwacja została pomyślnie usunięta.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Return_Reservation_Click(object sender, EventArgs e)
        {
        }
    }
}
