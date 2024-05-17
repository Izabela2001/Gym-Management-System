using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Gym_Management_System
{
    public partial class Logging : Form
    {
        public Logging()
        {
            InitializeComponent();
            
        }

       
        private void Logowanie_Click(object sender, EventArgs e)
        {
            Fitnesso form1 = new Fitnesso();

            string login = Login.Text;
            string haslo = Hasło.Text;

            if (login == "Admin" && haslo == "Admin")
            {
                form1.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Błędny login lub hasło");
            }

        }

        private void Logging_Load(object sender, EventArgs e)
        {

        }

        private void ZdjecieLogowania_Click(object sender, EventArgs e)
        {

        }
    }
}
