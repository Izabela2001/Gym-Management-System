namespace Gym_Management_System.Pay
{
    partial class AddPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllReservationNoPay = new System.Windows.Forms.DataGridView();
            this.AddPaymentWithReservation = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.OptionsPayment = new System.Windows.Forms.Panel();
            this.PostPaid = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NoPaid = new System.Windows.Forms.RadioButton();
            this.YasPaid = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TimePaid = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TypePaid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdUsers = new System.Windows.Forms.TextBox();
            this.IdReservation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllReservationNoPay)).BeginInit();
            this.OptionsPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllReservationNoPay
            // 
            this.AllReservationNoPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllReservationNoPay.Location = new System.Drawing.Point(11, 42);
            this.AllReservationNoPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllReservationNoPay.Name = "AllReservationNoPay";
            this.AllReservationNoPay.RowHeadersWidth = 51;
            this.AllReservationNoPay.RowTemplate.Height = 24;
            this.AllReservationNoPay.Size = new System.Drawing.Size(576, 262);
            this.AllReservationNoPay.TabIndex = 0;
            // 
            // AddPaymentWithReservation
            // 
            this.AddPaymentWithReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPaymentWithReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPaymentWithReservation.Location = new System.Drawing.Point(11, 309);
            this.AddPaymentWithReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPaymentWithReservation.Name = "AddPaymentWithReservation";
            this.AddPaymentWithReservation.Size = new System.Drawing.Size(200, 45);
            this.AddPaymentWithReservation.TabIndex = 1;
            this.AddPaymentWithReservation.Text = "Dodaj płatność";
            this.AddPaymentWithReservation.UseVisualStyleBackColor = false;
            this.AddPaymentWithReservation.Click += new System.EventHandler(this.AddPaymentWithReservation_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(32, 320);
            this.Answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 13);
            this.Answer.TabIndex = 2;
            // 
            // OptionsPayment
            // 
            this.OptionsPayment.Controls.Add(this.PostPaid);
            this.OptionsPayment.Controls.Add(this.label5);
            this.OptionsPayment.Controls.Add(this.NoPaid);
            this.OptionsPayment.Controls.Add(this.YasPaid);
            this.OptionsPayment.Controls.Add(this.label4);
            this.OptionsPayment.Controls.Add(this.TimePaid);
            this.OptionsPayment.Controls.Add(this.label3);
            this.OptionsPayment.Controls.Add(this.TypePaid);
            this.OptionsPayment.Controls.Add(this.label2);
            this.OptionsPayment.Controls.Add(this.IdUsers);
            this.OptionsPayment.Controls.Add(this.IdReservation);
            this.OptionsPayment.Controls.Add(this.label1);
            this.OptionsPayment.Location = new System.Drawing.Point(612, 42);
            this.OptionsPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptionsPayment.Name = "OptionsPayment";
            this.OptionsPayment.Size = new System.Drawing.Size(284, 266);
            this.OptionsPayment.TabIndex = 3;
            // 
            // PostPaid
            // 
            this.PostPaid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PostPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostPaid.Location = new System.Drawing.Point(42, 195);
            this.PostPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PostPaid.Name = "PostPaid";
            this.PostPaid.Size = new System.Drawing.Size(200, 45);
            this.PostPaid.TabIndex = 11;
            this.PostPaid.Text = "Dodaj";
            this.PostPaid.UseVisualStyleBackColor = false;
            this.PostPaid.Click += new System.EventHandler(this.PostPaid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Czy opłacone?";
            // 
            // NoPaid
            // 
            this.NoPaid.AutoSize = true;
            this.NoPaid.Location = new System.Drawing.Point(115, 164);
            this.NoPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoPaid.Name = "NoPaid";
            this.NoPaid.Size = new System.Drawing.Size(95, 17);
            this.NoPaid.TabIndex = 9;
            this.NoPaid.TabStop = true;
            this.NoPaid.Text = "Nie zapłacone";
            this.NoPaid.UseVisualStyleBackColor = true;
            // 
            // YasPaid
            // 
            this.YasPaid.AutoSize = true;
            this.YasPaid.Location = new System.Drawing.Point(115, 143);
            this.YasPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YasPaid.Name = "YasPaid";
            this.YasPaid.Size = new System.Drawing.Size(78, 17);
            this.YasPaid.TabIndex = 8;
            this.YasPaid.TabStop = true;
            this.YasPaid.Text = "Zapłacone";
            this.YasPaid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data płatności:";
            // 
            // TimePaid
            // 
            this.TimePaid.Location = new System.Drawing.Point(102, 107);
            this.TimePaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimePaid.Name = "TimePaid";
            this.TimePaid.Size = new System.Drawing.Size(151, 20);
            this.TimePaid.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rodzaj płatności";
            // 
            // TypePaid
            // 
            this.TypePaid.FormattingEnabled = true;
            this.TypePaid.Location = new System.Drawing.Point(142, 76);
            this.TypePaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypePaid.Name = "TypePaid";
            this.TypePaid.Size = new System.Drawing.Size(111, 21);
            this.TypePaid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identyfikator użytkownika";
            // 
            // IdUsers
            // 
            this.IdUsers.Location = new System.Drawing.Point(142, 46);
            this.IdUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdUsers.Name = "IdUsers";
            this.IdUsers.ReadOnly = true;
            this.IdUsers.Size = new System.Drawing.Size(111, 20);
            this.IdUsers.TabIndex = 2;
            // 
            // IdReservation
            // 
            this.IdReservation.Location = new System.Drawing.Point(142, 17);
            this.IdReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdReservation.Name = "IdReservation";
            this.IdReservation.ReadOnly = true;
            this.IdReservation.Size = new System.Drawing.Size(111, 20);
            this.IdReservation.TabIndex = 1;
            this.IdReservation.TextChanged += new System.EventHandler(this.IdReservation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identyfikator rezerwacji:";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Return.Location = new System.Drawing.Point(576, 2);
            this.Return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(170, 30);
            this.Return.TabIndex = 4;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main.Location = new System.Drawing.Point(748, 2);
            this.Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(170, 30);
            this.Main.TabIndex = 5;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(-2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1034, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 368);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.OptionsPayment);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.AddPaymentWithReservation);
            this.Controls.Add(this.AllReservationNoPay);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddPayment";
            this.Text = "AddPayment";
            ((System.ComponentModel.ISupportInitialize)(this.AllReservationNoPay)).EndInit();
            this.OptionsPayment.ResumeLayout(false);
            this.OptionsPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllReservationNoPay;
        private System.Windows.Forms.Button AddPaymentWithReservation;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Panel OptionsPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypePaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdUsers;
        private System.Windows.Forms.TextBox IdReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PostPaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton NoPaid;
        private System.Windows.Forms.RadioButton YasPaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TimePaid;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Label label6;
    }
}