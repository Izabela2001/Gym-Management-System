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
namespace Gym_Management_System.Reservations
{
    public partial class UpdateReservation : Form
    {
        public UpdateReservation()
        {
            InitializeComponent();
            ShowReservation();
            OpptionsUpdate.Visible = false;
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
            OpptionsUpdate.Visible=true;
        }
    }
}
