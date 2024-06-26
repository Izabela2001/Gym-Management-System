﻿using System;
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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            Display_Options.Visible = false;
            ManagmentOptions.Visible = false;
            Display.Visible = false;


        }

        private void Display_reservation_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {

                Display.DataSource = null;
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT R.IdReservation AS 'Id rezerwacji', R.IdUser AS 'Id użytkownika',R.DateReservation AS 'Data rezeracji',R.IsAccepted AS 'Czy zakceptowane?',R.IdFitnessClass AS 'Id zajęć'\r\n  FROM RESERVATION AS R;", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "RESERVATION"); 
                Display.DataSource = ds.Tables["RESERVATION"];
               


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

        private void Display_payment_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection();
            try
            {
                Display.DataSource = null;
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT P.IdPayment as 'Id płatności', P.IdReservation as 'Id rezerwacji', TP.Name as 'Rodzaj płatności', P.IdUser as 'Id użytkownika' ,P.DateOfPayment as 'Data płatności',P.IfPaid as 'Czy zapłacone?'\r\n  FROM PAYMENT AS P\r\n  INNER JOIN TYPE_PAYMENT AS TP ON P.IdTypePayment = TP.IdTypePayment;", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "PAYMENT");
                Display.DataSource = ds.Tables["PAYMENT"];
                


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

        private void Display_fitnessClass_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                Display.DataSource = null;
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT FT.IdFitnessClass as 'Id zajęć',TFT.Name as 'Rodzaj zajęć', FT.LevelOdAdvancement as 'Poziom trudności', FT.StartDate as 'Data rozpoczęcia', FT.EndDate as 'Data zakończenia', FT.MaxPlace as 'Max miejsc', FT.ActivePlace as 'Atktywne miejsca', FT.IdEmployee as 'Id pracownika'\t\r\n  FROM FITNESS_CLASS AS FT\r\n  INNER JOIN TYPE_FITNESS_CLASS AS TFT ON FT.IdTypeFitness = TFT.IdTypeFitness;", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "FITNESS_CLASS");
                Display.DataSource = ds.Tables["FITNESS_CLASS"];
                


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

        private void Display_TypeClass_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                Display.DataSource = null;
                con.ConnectionString = "Server=DESKTOP-DDK5DON;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TF.IdTypeFitness AS 'Id typu zajęć', TF.Name AS 'Rodzaj zajęć', TF.Description AS 'Opis'\r\n  FROM TYPE_FITNESS_CLASS AS TF;", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "TYPE_FITNESS_CLASS");
                Display.DataSource = ds.Tables["TYPE_FITNESS_CLASS"];
               


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

        private void Add_Rese_Click(object sender, EventArgs e)
        {
            
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Hide();
        }

        private void Display_OptionButton_CheckedChanged(object sender, EventArgs e)
        {
            
            Display_Options.Visible = true;
            ManagmentOptions.Visible = false;
            Display.Visible = true;
        }

        private void management_CheckedChanged(object sender, EventArgs e)
        {
            ManagmentOptions.Visible = true;
            Display_Options.Visible = false;
            Display.Visible = false;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
             
            Logging logging = new Logging();
            
            logging.Show();
            this.Close();
        }

        private void ManagingReservation_Click(object sender, EventArgs e)
        {
            FitnessClass fitnessClass = new FitnessClass(); 
            fitnessClass.Show();
            this.Close();
        }

        private void ManagingPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Close();
        }

        private void Display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
