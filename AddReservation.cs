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
using static Gym_Management_System.FitnessoDataSet;
using System.Security.AccessControl;

namespace Gym_Management_System
{
    public partial class AddReservation : Form
    {
        int paymentStatus;

        public AddReservation()
        {
            InitializeComponent();
            FillListFitness();
            OpptionPaid.Visible = false;

        }
        private void FillListFitness()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT NAME FROM TYPE_FITNESS_CLASS;", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "TYPE_FITNESS_CLASS");
                foreach (DataRow row in ds.Tables["TYPE_FITNESS_CLASS"].Rows)
                {
                    List_FitnessClass.Items.Add(row["NAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if( con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }




        private void OpptionPaid_Enter(object sender, EventArgs e)
        {

        }

        private int GetFitnessClassId()
        {
            int fitnessClassId = -1;
            string selectedFitnessClassName = List_FitnessClass.SelectedItem.ToString();
            SqlConnection con = new SqlConnection("Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdFitnessClass FROM TYPE_FITNESS_CLASS WHERE NAME = @FitnessClassName;", con);
                cmd.Parameters.AddWithValue("@FitnessClassName", selectedFitnessClassName);
                fitnessClassId = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Problem z pobieranie Id typu zajęć");
            }
            finally{
                con.Close() ;
            }
            return fitnessClassId;
        }
        private void TruePaid_CheckedChanged(object sender, EventArgs e)
        {
            paymentStatus = 1;
            OpptionPaid.Visible = true;
            
        }

        private void FalsePaid_CheckedChanged(object sender, EventArgs e)
        {
           paymentStatus = 0;
           OpptionPaid.Visible = false;

        }

        private void Dodaj_Reserwacje_Click(object sender, EventArgs e)
        {
            int userId;
            if(!int.TryParse(IdUserReservation.Text, out userId))
            {
                MessageBox.Show("Wprowadź porawnie ID użytkownika");
                return;
            }
            DateTime dataReservation = DateTime.Now;
            int isAccepted = 0;
            int fitnessClassId = GetFitnessClassId();

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO RESERVATION (IdUser, DateReservation, " +
                    "IsAccepted, IdFitnessClass) VALUES (@UserId, @DateReservation, @IsAccepted, @FitnessClassId)", con);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@DateReservation", dataReservation);
                //cmd.Parameters.AddWithValue('')

            }
            catch (Exception ex) { }
        }
    }
}
