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

namespace Gym_Management_System
{
    public partial class FitnessClass : Form
    {
        public FitnessClass()
        {
            InitializeComponent();
            ShowFitnessClass();
        }

        private void AllFitnessClass_Click(object sender, EventArgs e)
        {
            ShowFitnessClass();
        }
        private void ShowFitnessClass()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                string queryFitnessClass = " SELECT FC.IdFitnessClass AS 'Identyfikator typu zajęć'," +
                    " TFC.Name AS 'Rodzaj zajęć',\r\n  FC.StartDate AS 'Data rozpoczęcia', " +
                    "FC.EndDate AS 'Data zakończenia', FC.MaxPlace AS 'Maksymalna ilość miejsc'," +
                    "\r\n  FC.ActivePlace AS 'Aktywne miejsc', FC.IdEmployee AS 'Identyfikator pracownika'," +
                    " FC.LevelOdAdvancement AS 'Poziom trudności'\r\n  FROM FITNESS_CLASS AS FC\r\n " +
                    " INNER JOIN TYPE_FITNESS_CLASS AS TFC ON FC.IdTypeFitness = TFC.IdTypeFitness;";
                SqlDataAdapter adapter = new SqlDataAdapter(queryFitnessClass, con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "FITNESS_CLASS");
                ViewFitnessClasss.DataSource = ds.Tables["FITNESS_CLASS"];
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

        private void ActiveFitnessClass_Click(object sender, EventArgs e)
        {
            //trzbaz dobrze zbudować zapytanie sql, które wyswieyli zajećai w termnie i zaktywnymi miejscami
            SqlConnection con = new SqlConnection();
            try
            {
                
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                string queryActiveFitnessClass = "";
                SqlDataAdapter adapter = new SqlDataAdapter(queryActiveFitnessClass, con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "FITNESS_CLASS");
                ViewFitnessClasss.DataSource = ds.Tables["FITNESS_CLASS"];
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

        private void AfterTime_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {

                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                string queryAfterTime = "";
                SqlDataAdapter adapter = new SqlDataAdapter(queryAfterTime, con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "FITNESS_CLASS");
                ViewFitnessClasss.DataSource = ds.Tables["FITNESS_CLASS"];
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

        private void Main_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void AddFitnessClass_Click(object sender, EventArgs e)
        {
            FitnessClasses.AddNewFitnessClass addNewFitnessClass = new FitnessClasses.AddNewFitnessClass();
            addNewFitnessClass.Show();
            this.Hide();

        }
    }
}
