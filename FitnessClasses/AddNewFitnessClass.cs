using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System.FitnessClasses
{
    public partial class AddNewFitnessClass : Form
    {
        public AddNewFitnessClass()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            FitnessClass fitnessClass = new FitnessClass();
            fitnessClass.Show();
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
