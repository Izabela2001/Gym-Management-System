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
using static Gym_Management_System.FitnessoDataSet;

namespace Gym_Management_System.Fitness_Class
{
    public partial class UpdateFitnessClasses : Form
    {
        public UpdateFitnessClasses()
        {
            InitializeComponent();
            ShowFitnessClasses();
            LoadFitnessTypesAndLevels();
            FitnessClassesUpdatePanel.Visible = false;

        }
        private void ShowFitnessClasses()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                string queryFitnessClass = " SELECT FC.IdFitnessClass AS 'Id zajęć'," +
                    " TFC.Name AS 'Rodzaj zajęć',\r\n  FC.StartDate AS 'Data rozpoczęcia', " +
                    "FC.EndDate AS 'Data zakończenia', FC.MaxPlace AS 'Maksymalna ilość miejsc'," +
                    "\r\n  FC.ActivePlace AS 'Aktywne miejsca', FC.IdEmployee AS 'Id pracownika'," +
                    " FC.LevelOdAdvancement AS 'Poziom trudności'\r\n  FROM FITNESS_CLASS AS FC\r\n " +
                    " INNER JOIN TYPE_FITNESS_CLASS AS TFC ON FC.IdTypeFitness = TFC.IdTypeFitness;";
                SqlDataAdapter adapter = new SqlDataAdapter(queryFitnessClass, con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "FITNESS_CLASS");
                FitnessClassesShow.DataSource = ds.Tables["FITNESS_CLASS"];
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
        private void LoadFitnessTypesAndLevels()
        {
            using (SqlConnection con = new SqlConnection("Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;"))
            {
                try
                {
                    con.Open();

                    SqlDataAdapter typeAdapter = new SqlDataAdapter("SELECT IdTypeFitness, Name FROM TYPE_FITNESS_CLASS", con);
                    DataTable typeDt = new DataTable();
                    typeAdapter.Fill(typeDt);
                    UpdateTypeFitnessClass.DataSource = typeDt;
                    UpdateTypeFitnessClass.DisplayMember = "Name";
                    UpdateTypeFitnessClass.ValueMember = "IdTypeFitness";

                    SqlDataAdapter levelAdapter = new SqlDataAdapter("SELECT DISTINCT LevelOdAdvancement FROM FITNESS_CLASS", con);
                    DataTable levelDt = new DataTable();
                    levelAdapter.Fill(levelDt);
                    UpdateLevelOfAdvancement.DataSource = levelDt;
                    UpdateLevelOfAdvancement.DisplayMember = "LevelOdAdvancement";
                    UpdateLevelOfAdvancement.ValueMember = "LevelOdAdvancement";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading fitness types and levels: " + ex.Message);
                }
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            FitnessClass fitnessClass = new FitnessClass();
            fitnessClass.Show();
            this.Close();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Close();
        }

        private void FitnessClassesPostUpdate_Click(object sender, EventArgs e)
        {
            if (FitnessClassesShow.SelectedRows.Count > 0)
            {
                int selectedFitnessClassId = Convert.ToInt32(FitnessClassesShow.SelectedRows[0].Cells["Id zajęć"].Value);

                DateTime newStartDate = UpdateStartDate.Value;
                DateTime newEndDate = UpdateEndDate.Value;
                int newMaxPlaces = string.IsNullOrWhiteSpace(UpdateMaxPlaces.Text) ? 0 : int.Parse(UpdateMaxPlaces.Text);
                int newActivePlaces = string.IsNullOrWhiteSpace(UpdateActivePlaces.Text) ? 0 : int.Parse(UpdateActivePlaces.Text);
                string newLevelOfAdvancement = UpdateLevelOfAdvancement.Text;
                int newIdEmployee = string.IsNullOrWhiteSpace(UpdateIdEmployee.Text) ? 0 : int.Parse(UpdateIdEmployee.Text);
                int newTypeId = (int)UpdateTypeFitnessClass.SelectedValue;

                if (newEndDate < newStartDate)
                {
                    MessageBox.Show("Data zakończenia nie może być wcześniejsza niż data rozpoczęcia.");
                    return;
                }

                if (newMaxPlaces <= 0)
                {
                    MessageBox.Show("Liczba maksymalna miejsc musi być większa od 0.");
                    return;
                }

                if (newMaxPlaces < newActivePlaces)
                {
                    MessageBox.Show("Maksymalna liczba miejsc nie może być mniejsza od liczby zajętych miejsc.");
                    return;
                }
                 
           

                SqlConnection con = new SqlConnection();
                try
                {
                    con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                    con.Open();
                    string query = "UPDATE FITNESS_CLASS SET StartDate = @StartDate, EndDate = @EndDate, MaxPlace = @MaxPlace, ActivePlace = @ActivePlace,  IdEmployee = @IdEmployee, LevelOdAdvancement = @LevelOfAdvancement WHERE IdFitnessClass = @IdFitnessClass";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StartDate", newStartDate);
                    cmd.Parameters.AddWithValue("@EndDate", newEndDate);
                    cmd.Parameters.AddWithValue("@MaxPlace", newMaxPlaces);
                    cmd.Parameters.AddWithValue("@ActivePlace", newActivePlaces);
                    cmd.Parameters.AddWithValue("@LevelOfAdvancement", newLevelOfAdvancement);
                    cmd.Parameters.AddWithValue("@IdEmployee", newIdEmployee);
                    cmd.Parameters.AddWithValue("@IdFitnessClass", selectedFitnessClassId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Zajęcia zostały pomyślnie zaktualizowane.");
                        ShowFitnessClasses();
                        FitnessClassesUpdatePanel.Visible = false;
                    }
                    else
                    {
                        Answer.Text = "Aktualizacja zajęć nie powiodła się.";
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
                Answer.Text = "Proszę wybrać zajęcia do aktualizacji.";
            }
        }

        private void Update_FitnesssClass_Click(object sender, EventArgs e)
        {
            if (FitnessClassesShow.SelectedRows.Count > 0)
            {
                DataGridViewRow row = FitnessClassesShow.SelectedRows[0];
                UpdateStartDate.Value = Convert.ToDateTime(row.Cells["Data rozpoczęcia"].Value);
                UpdateEndDate.Value = Convert.ToDateTime(row.Cells["Data zakończenia"].Value);
                UpdateMaxPlaces.Text = row.Cells["Maksymalna ilość miejsc"].Value.ToString();
                UpdateActivePlaces.Text = row.Cells["Aktywne miejsca"].Value.ToString();
                UpdateIdEmployee.Text = row.Cells["Id pracownika"].Value.ToString();
                UpdateLevelOfAdvancement.Text = row.Cells["Poziom trudności"].Value.ToString();

                string typeName = row.Cells["Rodzaj zajęć"].Value.ToString();
                UpdateTypeFitnessClass.SelectedIndex = UpdateTypeFitnessClass.FindStringExact(typeName);

                FitnessClassesUpdatePanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Proszę wybrać zajęcia do aktualizacji.");
            }
        }
    }
}
