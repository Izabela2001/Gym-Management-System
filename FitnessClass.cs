﻿using System;
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
            this.Shown += (sender, args) => RefreshData();

        }

        public void RefreshData()
        {
            ViewFitnessClasss.DataSource = null;

            try
            {
                using (SqlConnection con = new SqlConnection("Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT fc.[IdFitnessClass] as 'ID zajęć', tf.[Name] as 'Rodzaj zajęć',fc.[StartDate]as 'Data rozpoczęcia',fc.[EndDate] as 'Data zakończenia',fc.[MaxPlace] as 'Maksymalna ilość miejsc',fc.[ActivePlace] as 'Dostępne miejsca',fc.[IdEmployee] as 'ID pracownika',fc.[LevelOdAdvancement] as 'Poziom trudności'\r\nFROM [Fitnesso].[dbo].[FITNESS_CLASS] fc\r\nINNER JOIN [Fitnesso].[dbo].[TYPE_FITNESS_CLASS] tf ON fc.[IdTypeFitness] = tf.[IdTypeFitness]", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ViewFitnessClasss.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy ładowaniu danych: " + ex.Message);
            }
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
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                string queryFitnessClass = " SELECT FC.IdFitnessClass AS 'Id typu zajęć'," +
                    " TFC.Name AS 'Rodzaj zajęć',\r\n  FC.StartDate AS 'Data rozpoczęcia', " +
                    "FC.EndDate AS 'Data zakończenia', FC.MaxPlace AS 'Maksymalna ilość miejsc'," +
                    "\r\n  FC.ActivePlace AS 'Aktywne miejsca', FC.IdEmployee AS 'Id pracownika'," +
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

            SqlConnection con = new SqlConnection();
            try
            {

                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                string queryActiveFitnessClass = "SELECT fc.[IdFitnessClass] as 'ID zajęć', tf.[Name] as 'Rodzaj zajęć',fc.[StartDate]as 'Data rozpoczęcia',fc.[EndDate] as 'Data zakończenia',fc.[MaxPlace] as 'Maksymalna ilość miejsc',fc.[ActivePlace] as 'Dostępne miejsca',fc.[IdEmployee] as 'ID pracownika',fc.[LevelOdAdvancement] as 'Poziom trudności'\r\nFROM [Fitnesso].[dbo].[FITNESS_CLASS] fc\r\nINNER JOIN [Fitnesso].[dbo].[TYPE_FITNESS_CLASS] tf ON fc.[IdTypeFitness] = tf.[IdTypeFitness]\r\nWHERE GETDATE() < fc.[EndDate];";
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

                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                string queryAfterTime = "SELECT fc.[IdFitnessClass] as 'ID zajęć', tf.[Name] as 'Rodzaj zajęć',fc.[StartDate]as 'Data rozpoczęcia',fc.[EndDate] as 'Data zakończenia',fc.[MaxPlace] as 'Maksymalna ilość miejsc',fc.[ActivePlace] as 'Dostępne miejsca',fc.[IdEmployee] as 'ID pracownika',fc.[LevelOdAdvancement] as 'Poziom trudności'FROM [Fitnesso].[dbo].[FITNESS_CLASS] fc\r\nINNER JOIN [Fitnesso].[dbo].[TYPE_FITNESS_CLASS] tf ON fc.[IdTypeFitness] = tf.[IdTypeFitness]\r\nWHERE GETDATE() > fc.[EndDate];";
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
            Fitness_Class.AddFitnessClasss addFitnessClasss = new Fitness_Class.AddFitnessClasss();
            addFitnessClasss.Show();
            this.Close();


        }

        private void DeleteFitnessClass_Click(object sender, EventArgs e)
        {
            if (ViewFitnessClasss.SelectedRows.Count > 0)
            {
  
                int fitnessClassId = Convert.ToInt32(ViewFitnessClasss.SelectedRows[0].Cells["ID zajęć"].Value);

                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć te zajęcia?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (CheckReservationsExist(fitnessClassId))
                    {
                        MessageBox.Show("Nie można usunąć tych zajęć, ponieważ istnieją dla niego rezerwacje.");
                        return;
                    }

                    DeleteFitnessClassFromDatabase(fitnessClassId);
                    RefreshData();  
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać zajęcie fitness do usunięcia.");
            }
        }

        private bool CheckReservationsExist(int fitnessClassId)
        {
            bool reservationsExist = false;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();

                
                string queryCheckReservations = "SELECT COUNT(*) FROM RESERVATION WHERE IdFitnessClass = @FitnessClassId";
                SqlCommand cmdCheckReservations = new SqlCommand(queryCheckReservations, con);
                cmdCheckReservations.Parameters.AddWithValue("@FitnessClassId", fitnessClassId);
                int reservationsCount = (int)cmdCheckReservations.ExecuteScalar();

                reservationsExist = (reservationsCount > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas sprawdzania rezerwacji: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return reservationsExist;
        }

        private void DeleteFitnessClassFromDatabase(int fitnessClassId)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();

                
                string queryDeleteFitnessClass = "DELETE FROM FITNESS_CLASS WHERE IdFitnessClass = @FitnessClassId";
                SqlCommand cmd = new SqlCommand(queryDeleteFitnessClass, con);
                cmd.Parameters.AddWithValue("@FitnessClassId", fitnessClassId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Zajęcia zostały pomyślnie usunięte.");


                ShowFitnessClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania zajęć: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fitness_Class.UpdateFitnessClasses updateFitnessClasses = new Fitness_Class.UpdateFitnessClasses();
            updateFitnessClasses.Show();
            this.Close();
        }
    }
}
