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
            ((System.ComponentModel.ISupportInitialize)(this.AllReservationNoPay)).BeginInit();
            this.OptionsPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllReservationNoPay
            // 
            this.AllReservationNoPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllReservationNoPay.Location = new System.Drawing.Point(35, 27);
            this.AllReservationNoPay.Name = "AllReservationNoPay";
            this.AllReservationNoPay.RowHeadersWidth = 51;
            this.AllReservationNoPay.RowTemplate.Height = 24;
            this.AllReservationNoPay.Size = new System.Drawing.Size(768, 322);
            this.AllReservationNoPay.TabIndex = 0;
            // 
            // AddPaymentWithReservation
            // 
            this.AddPaymentWithReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPaymentWithReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPaymentWithReservation.Location = new System.Drawing.Point(835, 60);
            this.AddPaymentWithReservation.Name = "AddPaymentWithReservation";
            this.AddPaymentWithReservation.Size = new System.Drawing.Size(170, 42);
            this.AddPaymentWithReservation.TabIndex = 1;
            this.AddPaymentWithReservation.Text = "Dodaj płatność";
            this.AddPaymentWithReservation.UseVisualStyleBackColor = false;
            this.AddPaymentWithReservation.Click += new System.EventHandler(this.AddPaymentWithReservation_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(42, 394);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 16);
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
            this.OptionsPayment.Location = new System.Drawing.Point(835, 113);
            this.OptionsPayment.Name = "OptionsPayment";
            this.OptionsPayment.Size = new System.Drawing.Size(378, 327);
            this.OptionsPayment.TabIndex = 3;
            // 
            // PostPaid
            // 
            this.PostPaid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PostPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostPaid.Location = new System.Drawing.Point(130, 281);
            this.PostPaid.Name = "PostPaid";
            this.PostPaid.Size = new System.Drawing.Size(106, 34);
            this.PostPaid.TabIndex = 11;
            this.PostPaid.Text = "Dodaj";
            this.PostPaid.UseVisualStyleBackColor = false;
            this.PostPaid.Click += new System.EventHandler(this.PostPaid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Czy opłacone?";
            // 
            // NoPaid
            // 
            this.NoPaid.AutoSize = true;
            this.NoPaid.Location = new System.Drawing.Point(130, 254);
            this.NoPaid.Name = "NoPaid";
            this.NoPaid.Size = new System.Drawing.Size(118, 20);
            this.NoPaid.TabIndex = 9;
            this.NoPaid.TabStop = true;
            this.NoPaid.Text = "Nie zapłacone";
            this.NoPaid.UseVisualStyleBackColor = true;
            // 
            // YasPaid
            // 
            this.YasPaid.AutoSize = true;
            this.YasPaid.Location = new System.Drawing.Point(130, 227);
            this.YasPaid.Name = "YasPaid";
            this.YasPaid.Size = new System.Drawing.Size(96, 20);
            this.YasPaid.TabIndex = 8;
            this.YasPaid.TabStop = true;
            this.YasPaid.Text = "Zapłacone";
            this.YasPaid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data płatności:";
            // 
            // TimePaid
            // 
            this.TimePaid.Location = new System.Drawing.Point(130, 189);
            this.TimePaid.Name = "TimePaid";
            this.TimePaid.Size = new System.Drawing.Size(200, 22);
            this.TimePaid.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rodzaj płatności";
            // 
            // TypePaid
            // 
            this.TypePaid.FormattingEnabled = true;
            this.TypePaid.Location = new System.Drawing.Point(130, 147);
            this.TypePaid.Name = "TypePaid";
            this.TypePaid.Size = new System.Drawing.Size(121, 24);
            this.TypePaid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identyfikator użytkownika";
            // 
            // IdUsers
            // 
            this.IdUsers.Location = new System.Drawing.Point(70, 94);
            this.IdUsers.Name = "IdUsers";
            this.IdUsers.ReadOnly = true;
            this.IdUsers.Size = new System.Drawing.Size(100, 22);
            this.IdUsers.TabIndex = 2;
            // 
            // IdReservation
            // 
            this.IdReservation.Location = new System.Drawing.Point(70, 40);
            this.IdReservation.Name = "IdReservation";
            this.IdReservation.ReadOnly = true;
            this.IdReservation.Size = new System.Drawing.Size(100, 22);
            this.IdReservation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identyfikator rezerwacji:";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Return.Location = new System.Drawing.Point(835, 12);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(170, 38);
            this.Return.TabIndex = 4;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main.Location = new System.Drawing.Point(1048, 27);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(131, 48);
            this.Main.TabIndex = 5;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 465);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.OptionsPayment);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.AddPaymentWithReservation);
            this.Controls.Add(this.AllReservationNoPay);
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
    }
}