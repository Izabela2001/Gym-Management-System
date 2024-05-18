using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.IdReservation as 'Identyfikator rezewacji', R.IdUser as 'Identyfikator użytkownika', R.DateReservation as 'Data rezerwacji'," +
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
            this.Hide();
        }

        private void Approve_Reservation_Click(object sender, EventArgs e)
        {
            ApproveReservation approveReservation = new ApproveReservation();
            approveReservation.Show();
            this.Hide();
        }

        private void UpdateReservation_Click(object sender, EventArgs e)
        {
            Reservations.UpdateReservation updateReservation = new Reservations.UpdateReservation();
            updateReservation.Show();
            this.Hide();
        }

        private void ReturnApp_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.IdReservation as 'Identyfikator rezerwacji', R.IdUser as 'Identyfikator użytkownika', " +
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

        }
    }
}
