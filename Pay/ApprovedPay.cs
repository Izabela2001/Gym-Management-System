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

namespace Gym_Management_System.Pay
{
    public partial class ApprovedPay : Form
    {
        public ApprovedPay()
        {
            InitializeComponent();
            All_Payment();
        }

        private void Approved_payment_Click(object sender, EventArgs e)
        {

        }
        private void All_Payment()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT P.IdPayment " +
                    "AS 'Identyfikator płatności', " +
                    "P.IdReservation as 'Identyfikator rezerwacji',\r\n  " +
                    "TP.Name AS 'Rodzaj płatności', P.IdUser AS 'Identyfiaktor użytkownika', " +
                    "P.DateOfPayment AS 'Data płatności'\r\n  FROM PAYMENT AS P\r\n  " +
                    "INNER JOIN TYPE_PAYMENT AS TP ON P.IdTypePayment = TP.IdTypePayment\r\n " +
                    " WHERE P.IfPaid =0;", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PAYMENT");

                AllPayment.DataSource = ds.Tables["PAYMENT"];

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
    }
}
