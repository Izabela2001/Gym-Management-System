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
            App App = new App();

            string login = Login.Text;
            string haslo = Hasło.Text;

            if (login == "Admin" && haslo == "Admin")
            {
                App.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło");
            }

        }

       
    }
}
