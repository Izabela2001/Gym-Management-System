using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Gym_Management_System.FitnessoDataSet;


namespace Gym_Management_System
{
    public partial class Fitnesso : Form

    {
        
       /// <summary>
       /// private DataGridView dataGridView2 = new DataGridView();
       /// </summary>

        public Fitnesso()
        {
            InitializeComponent(); // Inicjalizujemy komponenty formularza (w tym button_WyswietlanieRezerwacji)

            // Konfigurujemy dataGridView2

   
           // dataGridView2.Dock = DockStyle.Fill;
           /* Controls.Add(dataGridView2); // Dodajemy dataGridView2 do formularza

            dataGridView2.CellContentClick += dataGridView2_CellContentClick;*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_DodawaniaZajec_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_DataRozpoczecia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_CzasTrwaniaZajec_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_TypZajec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_CzasRozpoczecia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_MaxUczestnikow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_Zarezerwowane_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_EdytowanieZajec_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_WyswietlanieRezerwacji_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM RESERVATION", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "RESERVATION"); // Pobierz dane z tabeli RESERVATION

                // Przypisz dane do dataGridView2
                
               // dataGridView2.DataSource = ds.Tables["RESERVATION"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
