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

namespace Gym_Management_System.Fitness_Class
{
    public partial class AddFitnessClasss : Form
    {
        public AddFitnessClasss()
        {
            InitializeComponent();
            LoadTypeFitnessClass();
            LoadLevelOfAdvancement();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Return_Class_Click(object sender, EventArgs e)
        {
            FitnessClass fitnessClass = new FitnessClass();
            fitnessClass.Show();
            fitnessClass.RefreshData();
            this.Close();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Close();
        }

        private void LoadTypeFitnessClass()
        {
            using (SqlConnection con = new SqlConnection("Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT IdTypeFitness, Name FROM dbo.TYPE_FITNESS_CLASS", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cb_IdTypeFitness.DataSource = dt;
                    cb_IdTypeFitness.DisplayMember = "Name";
                    cb_IdTypeFitness.ValueMember = "IdTypeFitness";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }


        }

        private void LoadLevelOfAdvancement()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT LevelOdAdvancement FROM dbo.FITNESS_CLASS", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cB_LevelOfAdvancement.DataSource = dt;
                cB_LevelOfAdvancement.DisplayMember = "LevelOdAdvancement";
                cB_LevelOfAdvancement.ValueMember = "LevelOdAdvancement";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Błąd SQL: " + ex.Message);
                // Możesz też zalogować ex.StackTrace jeśli to konieczne
            }

            finally
            {
                con.Close();
            }
        }

        private void cb_IdTypeFitness_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tB_IdEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddFtinessClass(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dt_StartDate.Value;
                DateTime endDate = dt_EndDate.Value;
                int id = Convert.ToInt32(cb_IdTypeFitness.SelectedValue);
                string employeeId = tB_IdEmployee.Text.Trim();
                DataRowView selectedLevel = (DataRowView)cB_LevelOfAdvancement.SelectedItem;
                string levelOfAdvancement = selectedLevel != null ? selectedLevel["LevelOdAdvancement"].ToString() : "";

                if (string.IsNullOrEmpty(employeeId) || selectedLevel == null || string.IsNullOrEmpty(levelOfAdvancement))
                {
                    MessageBox.Show("Proszę uzupełnić wszystkie pola.");
                    return;
                }

                if (endDate < startDate)
                {
                    MessageBox.Show("Data zakończenia nie może być wcześniejsza niż data rozpoczęcia.");
                    return;
                }

                int maxPlaces = (int)num_MaxPlaces.Value;
                int activePlaces = (int)num_ActivePlaces.Value;

                if (maxPlaces <= 0)
                {
                    MessageBox.Show("Liczba maksymalna miejsc musi być większa od 0.");
                    return;
                }

                if (maxPlaces < activePlaces)
                {
                    MessageBox.Show("Maksymalna liczba miejsc nie może być mniejsza od liczby zajętych miejsc.");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;"))
                {
                    string query = "INSERT INTO dbo.FITNESS_CLASS (IdTypeFitness, StartDate, EndDate, MaxPlace, ActivePlace, IdEmployee, LevelOdAdvancement) VALUES (@IdTypeFitness, @StartDate, @EndDate, @MaxPlace, @ActivePlace, @IdEmployee, @LevelOfAdvancement)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdTypeFitness", id);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        cmd.Parameters.AddWithValue("@MaxPlace", maxPlaces);
                        cmd.Parameters.AddWithValue("@ActivePlace", activePlaces);
                        cmd.Parameters.AddWithValue("@IdEmployee", Convert.ToInt32(employeeId));
                        cmd.Parameters.AddWithValue("@LevelOfAdvancement", levelOfAdvancement);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Zajęcia zostały pomyślnie dodane!");
                        }
                        else
                        {
                            MessageBox.Show("Dodanie zajęć nie powiodło się!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }


        }
    }
}
