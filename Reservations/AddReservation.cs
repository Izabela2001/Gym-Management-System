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
using System.Security.AccessControl;

namespace Gym_Management_System
{
    public partial class AddReservation : Form
    {
        int paymentStatus;

        public AddReservation()
        {
            InitializeComponent();
            FillListFitness();
            OpptionPaid.Visible = false;
            FillListTypePayment();
            List_FitnessClass.SelectedIndexChanged += List_FitnessClass_SelectedIndexChanged; // Dodajemy obsługę zdarzenia
        }

        private void FillListFitness()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT NAME FROM TYPE_FITNESS_CLASS;", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "TYPE_FITNESS_CLASS");
                foreach (DataRow row in ds.Tables["TYPE_FITNESS_CLASS"].Rows)
                {
                    List_FitnessClass.Items.Add(row["NAME"].ToString());
                }
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

        private void FillListTypePayment()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT NAME FROM TYPE_PAYMENT;", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "TYPE_PAYMENT");
                foreach (DataRow row in ds.Tables["TYPE_PAYMENT"].Rows)
                {
                    List_TypePayment.Items.Add(row["NAME"].ToString());
                }
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

        private void FillListFitnessClassTime()
        {
            if (List_FitnessClass.SelectedItem == null)
            {
                MessageBox.Show("Wybierz typ zajęć fitness z listy.");
                return;
            }

            string selectedFitnessClassName = List_FitnessClass.SelectedItem.ToString();
            /*Warunek z datami się wali*/
            SqlConnection con = new SqlConnection("Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
            "SELECT FC.IdFitnessClass, FC.StartDate, FC.EndDate, FC.LevelOfAdvancement " +
            "FROM FITNESS_CLASS AS FC " +
            "INNER JOIN TYPE_FITNESS_CLASS AS TFC ON FC.IdTypeFitness = TFC.IdTypeFitness " +
            "WHERE TFC.NAME = @FitnessClassName " +
            "AND FC.StartDate <= @CurrentDate " +
            "AND FC.EndDate >= @CurrentDate;", con);
                cmd.Parameters.AddWithValue("@FitnessClassName", selectedFitnessClassName);
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "FITNESS_CLASS");

                FitnessClasTime.Items.Clear();
                foreach (DataRow row in ds.Tables["FITNESS_CLASS"].Rows)
                {
                    string displayText = $"{row["IdFitnessClass"]}: {row["StartDate"]} - {row["EndDate"]} ({row["LevelOfAdvancement"]})";
                    FitnessClasTime.Items.Add(displayText);
                }
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

        private void List_FitnessClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListFitnessClassTime();
        }

        private int GetPaymentTypeId()
        {
            int paymentTypeId = 0;

            if (List_TypePayment.SelectedItem == null)
            {
                MessageBox.Show("Wybierz typ płatności z listy.");
                return paymentTypeId;
            }

            string selectedTypePaymentName = List_TypePayment.SelectedItem.ToString();
            using (SqlConnection con = new SqlConnection("Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT IdTypePayment FROM TYPE_PAYMENT WHERE NAME = @TypePaymentName;", con);
                    cmd.Parameters.AddWithValue("@TypePaymentName", selectedTypePaymentName);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        paymentTypeId = (int)result;
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono identyfikatora typu płatności dla wybranej nazwy.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem z pobieraniem Id typu płatności: " + ex.Message);
                }
            }
            return paymentTypeId;
        }

        private void TruePaid_CheckedChanged(object sender, EventArgs e)
        {
            paymentStatus = 1;
            OpptionPaid.Visible = true;
        }

        private void FalsePaid_CheckedChanged(object sender, EventArgs e)
        {
            paymentStatus = 0;
            OpptionPaid.Visible = false;
        }

        private void Dodaj_Reserwacje_Click(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(IdUserReservation.Text, out userId))
            {
                MessageBox.Show("Wprowadź poprawnie ID użytkownika");
                return;
            }

            if (FitnessClasTime.SelectedItem == null)
            {
                MessageBox.Show("Wybierz zajęcia fitness z listy.");
                return;
            }

            string selectedFitnessClassText = FitnessClasTime.SelectedItem.ToString();
            int fitnessClassId = int.Parse(selectedFitnessClassText.Split(':')[0]);

            DateTime dataReservation = DateTime.Now;
            int isAccepted = 0;

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = "Server=IZABELA\\SQLEXPRESS;Database=Fitnesso;Integrated Security=True;";
                con.Open();

                SqlCommand getLastIdCmd = new SqlCommand("SELECT MAX(IdReservation) FROM RESERVATION", con);
                int lastId = (int)getLastIdCmd.ExecuteScalar();
                int newId = lastId + 1;

                SqlCommand cmd = new SqlCommand("INSERT INTO RESERVATION (IdReservation, IdUser, DateReservation, IsAccepted, IdFitnessClass) " +
                    "VALUES (@IdReservation, @UserId, @DateReservation, @IsAccepted, @FitnessClassId)", con);
                cmd.Parameters.AddWithValue("@IdReservation", newId);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@DateReservation", dataReservation);
                cmd.Parameters.AddWithValue("@IsAccepted", isAccepted);
                cmd.Parameters.AddWithValue("@FitnessClassId", fitnessClassId);
                cmd.ExecuteNonQuery();
                Result_add.Text = "Dodano nową rezerwację";

                if (TruePaid.Checked)
                {
                    SqlCommand getLastIdPaid = new SqlCommand("SELECT MAX(IdPayment) FROM PAYMENT", con);
                    int lastIdPay = (int)getLastIdPaid.ExecuteScalar();
                    int newIdPay = lastIdPay + 1;

                    int typePaymentId = GetPaymentTypeId();
                    if (typePaymentId != 0)
                    {
                        SqlCommand insertPaymentCmd = new SqlCommand("INSERT INTO PAYMENT (IdPayment, IdReservation, IdUser, IdTypePayment, DateOfPayment, IfPaid) " +
                            "VALUES (@IdPayment, @IdReservation, @UserId, @TypePaymentId, @DateOfPayment, 1)", con);
                        insertPaymentCmd.Parameters.AddWithValue("@IdPayment", newIdPay);
                        insertPaymentCmd.Parameters.AddWithValue("@IdReservation", newId);
                        insertPaymentCmd.Parameters.AddWithValue("@UserId", userId);
                        insertPaymentCmd.Parameters.AddWithValue("@TypePaymentId", typePaymentId);
                        insertPaymentCmd.Parameters.AddWithValue("@DateOfPayment", DateTime.Now);
                        insertPaymentCmd.ExecuteNonQuery();
                        Result_add.Text = "Dodano nową rezerwację z płatnością";
                    }
                    else
                    {
                        Result_add.Text = "Nie znaleziono typu płatności dla wybranej nazwy.";
                    }
                }
            }
            catch (Exception ex)
            {
                Result_add.Text = "Wystąpił błąd podczas dodawania rezerwacji: " + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        private void Return_Reservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Close();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Close();
        }
    }
}