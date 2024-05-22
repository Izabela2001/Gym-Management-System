namespace Gym_Management_System.Pay
{
    partial class AddPay
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
            this.NoPayid = new System.Windows.Forms.DataGridView();
            this.AddPayment = new System.Windows.Forms.Button();
            this.OptionsPayment = new System.Windows.Forms.Panel();
            this.NoPaid = new System.Windows.Forms.RadioButton();
            this.YesPaid = new System.Windows.Forms.RadioButton();
            this.DataPay = new System.Windows.Forms.DateTimePicker();
            this.TypePayment = new System.Windows.Forms.ComboBox();
            this.IdUser = new System.Windows.Forms.TextBox();
            this.IdReservation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.AddP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoPayid)).BeginInit();
            this.OptionsPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoPayid
            // 
            this.NoPayid.AllowUserToAddRows = false;
            this.NoPayid.AllowUserToDeleteRows = false;
            this.NoPayid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoPayid.Location = new System.Drawing.Point(29, 22);
            this.NoPayid.Name = "NoPayid";
            this.NoPayid.ReadOnly = true;
            this.NoPayid.RowHeadersWidth = 51;
            this.NoPayid.RowTemplate.Height = 24;
            this.NoPayid.Size = new System.Drawing.Size(516, 366);
            this.NoPayid.TabIndex = 0;
            this.NoPayid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoPayid_CellContentClick);
            // 
            // AddPayment
            // 
            this.AddPayment.Location = new System.Drawing.Point(684, 22);
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Size = new System.Drawing.Size(196, 32);
            this.AddPayment.TabIndex = 1;
            this.AddPayment.Text = "Dodaj płatność";
            this.AddPayment.UseVisualStyleBackColor = true;
            this.AddPayment.Click += new System.EventHandler(this.AddPayment_Click);
            // 
            // OptionsPayment
            // 
            this.OptionsPayment.Controls.Add(this.AddP);
            this.OptionsPayment.Controls.Add(this.label5);
            this.OptionsPayment.Controls.Add(this.label4);
            this.OptionsPayment.Controls.Add(this.label3);
            this.OptionsPayment.Controls.Add(this.label2);
            this.OptionsPayment.Controls.Add(this.NoPaid);
            this.OptionsPayment.Controls.Add(this.YesPaid);
            this.OptionsPayment.Controls.Add(this.DataPay);
            this.OptionsPayment.Controls.Add(this.TypePayment);
            this.OptionsPayment.Controls.Add(this.IdUser);
            this.OptionsPayment.Controls.Add(this.IdReservation);
            this.OptionsPayment.Controls.Add(this.label1);
            this.OptionsPayment.Location = new System.Drawing.Point(589, 60);
            this.OptionsPayment.Name = "OptionsPayment";
            this.OptionsPayment.Size = new System.Drawing.Size(368, 336);
            this.OptionsPayment.TabIndex = 2;
            // 
            // NoPaid
            // 
            this.NoPaid.AutoSize = true;
            this.NoPaid.Location = new System.Drawing.Point(189, 251);
            this.NoPaid.Name = "NoPaid";
            this.NoPaid.Size = new System.Drawing.Size(112, 20);
            this.NoPaid.TabIndex = 9;
            this.NoPaid.TabStop = true;
            this.NoPaid.Text = "Nie opłacone";
            this.NoPaid.UseVisualStyleBackColor = true;
            // 
            // YesPaid
            // 
            this.YesPaid.AutoSize = true;
            this.YesPaid.Location = new System.Drawing.Point(189, 225);
            this.YesPaid.Name = "YesPaid";
            this.YesPaid.Size = new System.Drawing.Size(90, 20);
            this.YesPaid.TabIndex = 8;
            this.YesPaid.TabStop = true;
            this.YesPaid.Text = "Opłacone";
            this.YesPaid.UseVisualStyleBackColor = true;
            this.YesPaid.CheckedChanged += new System.EventHandler(this.YesPaid_CheckedChanged);
            // 
            // DataPay
            // 
            this.DataPay.Location = new System.Drawing.Point(142, 151);
            this.DataPay.Name = "DataPay";
            this.DataPay.Size = new System.Drawing.Size(200, 22);
            this.DataPay.TabIndex = 7;
            // 
            // TypePayment
            // 
            this.TypePayment.FormattingEnabled = true;
            this.TypePayment.Location = new System.Drawing.Point(180, 184);
            this.TypePayment.Name = "TypePayment";
            this.TypePayment.Size = new System.Drawing.Size(121, 24);
            this.TypePayment.TabIndex = 6;
            // 
            // IdUser
            // 
            this.IdUser.Location = new System.Drawing.Point(67, 100);
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            this.IdUser.Size = new System.Drawing.Size(100, 22);
            this.IdUser.TabIndex = 2;
            // 
            // IdReservation
            // 
            this.IdReservation.Location = new System.Drawing.Point(69, 45);
            this.IdReservation.Name = "IdReservation";
            this.IdReservation.ReadOnly = true;
            this.IdReservation.Size = new System.Drawing.Size(100, 22);
            this.IdReservation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identyfikator rezerwacji";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(26, 425);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(44, 16);
            this.Answer.TabIndex = 3;
            this.Answer.Text = "label1";
            // 
            // AddP
            // 
            this.AddP.Location = new System.Drawing.Point(102, 284);
            this.AddP.Name = "AddP";
            this.AddP.Size = new System.Drawing.Size(158, 44);
            this.AddP.TabIndex = 4;
            this.AddP.Text = "Dodaj";
            this.AddP.UseVisualStyleBackColor = true;
            this.AddP.Click += new System.EventHandler(this.AddP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Identyfikator użytkownika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data płatności:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rodzaj płatności:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Czy opłacone?";
            // 
            // AddPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.OptionsPayment);
            this.Controls.Add(this.AddPayment);
            this.Controls.Add(this.NoPayid);
            this.Name = "AddPay";
            this.Text = "AddPay";
            ((System.ComponentModel.ISupportInitialize)(this.NoPayid)).EndInit();
            this.OptionsPayment.ResumeLayout(false);
            this.OptionsPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NoPayid;
        private System.Windows.Forms.Button AddPayment;
        private System.Windows.Forms.Panel OptionsPayment;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox IdReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddP;
        private System.Windows.Forms.TextBox IdUser;
        private System.Windows.Forms.ComboBox TypePayment;
        private System.Windows.Forms.DateTimePicker DataPay;
        private System.Windows.Forms.RadioButton NoPaid;
        private System.Windows.Forms.RadioButton YesPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}