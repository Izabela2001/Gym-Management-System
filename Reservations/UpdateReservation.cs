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
namespace Gym_Management_System.Reservations
{
    public partial class UpdateReservation : Form
    {
        public UpdateReservation()
        {
            InitializeComponent();
            ShowReservation();
            ReservationUpdatePanel.Visible = false;

        }

        private void ShowReservationAfter_Click(object sender, EventArgs e)
        {

        }
        private void ShowReservation()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.IdReservation, R.IdUser, R.DateReservation, R.IdFitnessClass\r\nFROM RESERVATION AS R\r\n", con);
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

        private void Update_Reservation_Click(object sender, EventArgs e)
        {
            
            if(ReservationShow.SelectedRows.Count >0)
            {
                DataGridViewRow row = ReservationShow.SelectedRows[0];
                DateTime dateReservation = Convert.ToDateTime(row.Cells["DateReservation"].Value);
                int idUser = Convert.ToInt32(row.Cells["IdUser"].Value);
                int idFitnessClass = Convert.ToInt32(row.Cells["IdFitnessClass"].Value);
                UpdateDate.Value = dateReservation;
                UpdateUserId.Text = idUser.ToString();
                UpdateIdClass.Text = idFitnessClass.ToString();
                ReservationUpdatePanel.Visible = true;
            }
            else
            {
                Answer.Text = "Prodzę wybrać rezerwację do aktualizacji";

            }

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Close();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Close();
        }

        private void ReservationPostUpdate_Click(object sender, EventArgs e)
        {
            if(ReservationShow.SelectedRows.Count > 0)
            {
                int selectedReservationId = Convert.ToInt32(ReservationShow.SelectedRows[0].Cells["IdReservation"].Value);

                
                DateTime newDate = UpdateDate.Value;
                int newUserId = int.Parse(UpdateUserId.Text);
                int newClassId = int.Parse(UpdateIdClass.Text);
                SqlConnection con = new SqlConnection();
                try
                {
                    con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                    con.Open();
                    string query = "UPDATE RESERVATION SET DateReservation = @DateReservation, IdUser = @IdUser, IdFitnessClass = @IdFitnessClass WHERE IdReservation = @IdReservation";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DateReservation", newDate);
                    cmd.Parameters.AddWithValue("@IdUser", newUserId);
                    cmd.Parameters.AddWithValue("@IdFitnessClass", newClassId);
                    cmd.Parameters.AddWithValue("@IdReservation", selectedReservationId);

                  
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Answer.Text = "Rezerwacja została pomyślnie zaktualizowana";
                        ShowReservation();
                        ReservationUpdatePanel.Visible = false;
                    }
                    else
                    {
                        Answer.Text = "Aktualizacja rezerwacji nie powiodła się";
                        
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
            else
            {
                Answer.Text = "Prodzę wybrać rezerwację do aktualizacji";
            }
        }
    }
        
    
}
