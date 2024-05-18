using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class ApproveReservation : Form
    {
       

        public ApproveReservation()
        {
            InitializeComponent();
            ShowNoApprovedReservation();
            


        }

        private void ApproveReservation_Load(object sender, EventArgs e)
        {

        }
        private void ShowNoApprovedReservation()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.IdReservation, R.IdUser, R.DateReservation, R.IdFitnessClass\r\nFROM RESERVATION AS R\r\nWHERE R.IsAccepted = 0 AND R.DateReservation >= GETDATE();", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "RESERVATION");
                if (ds.Tables["RESERVATION"].Rows.Count == 0)
                {
                    Reservation_NoApproved.DataSource = null;
                    Reservation_NoApproved.Rows.Clear();
                    Reservation_NoApproved.Columns.Clear();
                    Reservation_NoApproved.Rows.Add("Brak rezerwacji do akceptacji");
                }
                else
                {
                  
                    Reservation_NoApproved.DataSource = ds.Tables["RESERVATION"];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Approved_Click(object sender, EventArgs e)
        {
            
            if (Reservation_NoApproved.SelectedRows.Count > 0)
            {
                
                int selectedReservationId = Convert.ToInt32(Reservation_NoApproved.SelectedRows[0].Cells["IdReservation"].Value);

                
                using (SqlConnection con = new SqlConnection("Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;"))
                {
                    try
                    {
                        con.Open();


                        string paymentCheckQuery = "SELECT COUNT(*) FROM PAYMENT WHERE IdReservation = @ReservationId";
                        using (SqlCommand paymentCheckCmd = new SqlCommand(paymentCheckQuery, con))
                        {
                            paymentCheckCmd.Parameters.AddWithValue("@ReservationId", selectedReservationId);
                            int paymentCount = Convert.ToInt32(paymentCheckCmd.ExecuteScalar());
                            if (paymentCount == 0)
                            {
                                Result_Approved.Text = "Nie można zaakceptować rezerwacji. Brak wpisu o płatności. Proszę dodać płatność.";
                                return;
                            }
                        }

                       
                        string paymentStatusQuery = "SELECT IfPaid FROM PAYMENT WHERE IdReservation = @ReservationId";
                        using (SqlCommand paymentStatusCmd = new SqlCommand(paymentStatusQuery, con))
                        {
                            paymentStatusCmd.Parameters.AddWithValue("@ReservationId", selectedReservationId);
                            bool isPaid = Convert.ToBoolean(paymentStatusCmd.ExecuteScalar());

                            if (!isPaid)
                            {
                                Result_Approved.Text= "Nie można zaakceptować rezerwacji. Rezerwacja nie została opłacona.";
                                return;
                            }
                        }
                        Approved_Reservation();
                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać rezerwację do zaakceptowania.");
            }
        }

        private void Approved_Reservation()
        {
            SqlConnection con = new SqlConnection();
            if (Reservation_NoApproved.SelectedRows.Count > 0)
            {
                int reservationId = Convert.ToInt32(Reservation_NoApproved.SelectedRows[0].Cells["IdReservation"].Value);
                try
                {
                    con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                    con.Open();

                    string update = "UPDATE RESERVATION SET IsAccepted = 1 WHERE IdReservation = @ReservationId";
                    SqlCommand cmd = new SqlCommand(update, con);
                    cmd.Parameters.AddWithValue("@ReservationId", reservationId);
                    int resultApproved = cmd.ExecuteNonQuery();
                    if (resultApproved > 0)
                    {
                        Result_Approved.Text = "Rezerwacja została zakceptowan";
                        ShowNoApprovedReservation();
                    }
                    else
                    {
                        Result_Approved.Text = "Rezerwacja nie została zakcpetowana";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd" + ex.Message);
                }
            }
        }

        private void Return_reservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Hide();
        }
    }
}
