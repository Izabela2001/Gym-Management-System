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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.IdReservation, R.IdUser, R.DateReservation, R.IdFitnessClass\r\n" +
                    "FROM RESERVATION AS R\r\nWHERE R.IsAccepted = 0 AND R.DateReservation >= GETDATE();", con);
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
                        SqlCommand paymentCheckCmd = new SqlCommand(paymentCheckQuery, con);
                        
                            paymentCheckCmd.Parameters.AddWithValue("@ReservationId", selectedReservationId);
                            int paymentCount = Convert.ToInt32(paymentCheckCmd.ExecuteScalar());
                            if (paymentCount == 0)
                            {
                                Result_Approved.Text = "Nie można zaakceptować rezerwacji. Brak wpisu o płatności. Proszę dodać płatność.";
                                return;
                            }
                        

                       
                        string paymentStatusQuery = "SELECT IfPaid FROM PAYMENT WHERE IdReservation = @ReservationId";
                        SqlCommand paymentStatusCmd = new SqlCommand(paymentStatusQuery, con);
                        
                            paymentStatusCmd.Parameters.AddWithValue("@ReservationId", selectedReservationId);
                            bool isPaid = Convert.ToBoolean(paymentStatusCmd.ExecuteScalar());

                            if (!isPaid)
                            {
                                Result_Approved.Text= "Nie można zaakceptować rezerwacji. Rezerwacja nie została opłacona.";
                                return;
                            }
                        

                        string timeQuery = "SELECT COUNT(*) \r\nFROM FITNESS_CLASS AS FC \r\nINNER JOIN RESERVATION as R ON FC.IdFitnessClass = R.IdFitnessClass " +
                            "\r\nWHERE GETDATE() BETWEEN FC.StartDate AND FC.EndDate AND R.IdReservation =@ReservationId;";
                        SqlCommand sqlCommand = new SqlCommand(timeQuery, con);
                        sqlCommand.Parameters.AddWithValue("@ReservationId", selectedReservationId);
                        int timeCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        if(timeCount == 0)
                        {
                            Result_Approved.Text = "Nie można zaakceptować rezerwacji. Termin zajęć minął";
                            return;
                        }

                        string placeQuery = "SELECT COUNT(*) \r\nFROM FITNESS_CLASS AS FC \r\nINNER JOIN RESERVATION as R ON FC.IdFitnessClass = R.IdFitnessClass \r\n" +
                            "WHERE  FC.ActivePlace != FC.MaxPlace AND R.IdReservation =@ReservationId;";
                        SqlCommand sqlPlace = new SqlCommand(placeQuery, con);
                        sqlPlace.Parameters.AddWithValue("@ReservationId", selectedReservationId);
                        int placeCount = Convert.ToInt32(sqlPlace.ExecuteScalar());
                        if (placeCount == 0)
                        {
                            Result_Approved.Text = "Nie można zaakceptować rezerwacji. Brakuje miejsc na zajęcia";
                            return;
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

                    string updateReservation = "UPDATE RESERVATION SET IsAccepted = 1 WHERE IdReservation = @ReservationId";

                    
                    string getActivePlaceQuery = "SELECT ActivePlace FROM FITNESS_CLASS WHERE IdFitnessClass = (SELECT IdFitnessClass FROM RESERVATION WHERE IdReservation = @ReservationId)";

                    SqlCommand getActivePlaceCmd = new SqlCommand(getActivePlaceQuery, con);
                    getActivePlaceCmd.Parameters.AddWithValue("@ReservationId", reservationId);
                    int activePlace = Convert.ToInt32(getActivePlaceCmd.ExecuteScalar());

                    
                    activePlace++;

                    
                    string updateFitnessClass = "UPDATE FITNESS_CLASS SET ActivePlace = @ActivePlace " +
                        "WHERE IdFitnessClass = (SELECT IdFitnessClass FROM RESERVATION WHERE IdReservation = @ReservationId)";

                    SqlCommand cmd1 = new SqlCommand(updateReservation, con);
                    cmd1.Parameters.AddWithValue("@ReservationId", reservationId);
                    int resultApproved = cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand(updateFitnessClass, con);
                    cmd2.Parameters.AddWithValue("@ReservationId", reservationId);
                    cmd2.Parameters.AddWithValue("@ActivePlace", activePlace);
                    int resultUpdateFitnessClass = cmd2.ExecuteNonQuery();

                    if (resultApproved > 0 && resultUpdateFitnessClass > 0)
                    {
                        Result_Approved.Text = "Rezerwacja została zaakceptowana";
                        ShowNoApprovedReservation();
                    }
                    else
                    {
                        Result_Approved.Text = "Rezerwacja nie została zaakceptowana";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }



        private void Return_reservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Hide();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }
    }
}
