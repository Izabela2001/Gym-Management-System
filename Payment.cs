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

namespace Gym_Management_System
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            ShowAllPayment();
        }

        private void ShowNoPaid_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT P.IdPayment AS 'Identyfikator płatności', " +
                    "P.IdReservation as 'Identyfikator rezerwacji',\r\n  TP.Name AS 'Rodzaj płatności', " +
                    "P.IdUser AS 'Identyfiaktor użytkownika', P.DateOfPayment AS 'Data płatności'\r\n  " +
                    "FROM PAYMENT AS P\r\n  INNER JOIN TYPE_PAYMENT AS TP ON P.IdTypePayment = TP.IdTypePayment\r\n  " +
                    "WHERE P.IfPaid =0 AND GETDATE() > P.DateOfPayment;", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PAYMENT");

                ShowPayment.DataSource = ds.Tables["PAYMENT"];

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
        private void ShowAllPayment()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT P.IdPayment AS 'Identyfikator płatności', P.IdReservation as 'Identyfikator rezerwacji',\r\n  TP.Name AS 'Rodzaj płatności', P.IdUser AS 'Identyfiaktor użytkownika', " +
                    "P.DateOfPayment AS 'Data płatności'\r\n  FROM PAYMENT AS P\r\n  INNER JOIN TYPE_PAYMENT AS TP ON P.IdTypePayment = TP.IdTypePayment;", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PAYMENT");

                ShowPayment.DataSource = ds.Tables["PAYMENT"];

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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT P.IdPayment AS " +
                    "'Identyfikator płatności', P.IdReservation as 'Identyfikator rezerwacji'," +
                    "\r\n  TP.Name AS 'Rodzaj płatności', P.IdUser AS 'Identyfiaktor użytkownika'," +
                    " P.DateOfPayment AS 'Data płatności'\r\n  FROM PAYMENT AS P\r\n " +
                    " INNER JOIN TYPE_PAYMENT AS TP ON P.IdTypePayment = TP.IdTypePayment\r\n " +
                    " WHERE P.IfPaid =0 AND GETDATE() > P.DateOfPayment;", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PAYMENT");

                ShowPayment.DataSource = ds.Tables["PAYMENT"];

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

        private void PaidPayment_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT P.IdPayment " +
                    "AS 'Identyfikator płatności', " +
                    "P.IdReservation as 'Identyfikator rezerwacji',\r\n  " +
                    "TP.Name AS 'Rodzaj płatności', P.IdUser AS 'Identyfiaktor użytkownika', " +
                    "P.DateOfPayment AS 'Data płatności'\r\n  FROM PAYMENT AS P\r\n  " +
                    "INNER JOIN TYPE_PAYMENT AS TP ON P.IdTypePayment = TP.IdTypePayment\r\n " +
                    " WHERE P.IfPaid =1;", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PAYMENT");

                ShowPayment.DataSource = ds.Tables["PAYMENT"];

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

        

        private void UpdatePayment_Click(object sender, EventArgs e)
        {
           Pay.UpdatePay  updatePay = new Pay.UpdatePay();
            updatePay.Show();
            this.Close();

        }

        private void AddPayment_Click(object sender, EventArgs e)
        {
            Pay.AddPayment pay = new Pay.AddPayment();
            pay.Show();
            this.Close();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            App app = new App();    
            app.Show();
            this.Close();
        }

        private void ApprovedPayment_Click(object sender, EventArgs e)
        {
            Pay.ApprovedPay approvedPay = new Pay.ApprovedPay();    
            approvedPay.Show();
            this.Close();
        }
    }
}
