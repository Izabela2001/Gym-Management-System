namespace Gym_Management_System.Pay
{
    partial class UpdatePay
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
            this.ShowPayment = new System.Windows.Forms.DataGridView();
            this.UpdatePayment = new System.Windows.Forms.Button();
            this.OptionsPay = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypePayment = new System.Windows.Forms.ComboBox();
            this.IdReservation = new System.Windows.Forms.TextBox();
            this.UpdatePaymentPost = new System.Windows.Forms.Button();
            this.IdUser = new System.Windows.Forms.TextBox();
            this.DataPay = new System.Windows.Forms.DateTimePicker();
            this.Answer = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPayment)).BeginInit();
            this.OptionsPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowPayment
            // 
            this.ShowPayment.AllowUserToAddRows = false;
            this.ShowPayment.AllowUserToDeleteRows = false;
            this.ShowPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowPayment.Location = new System.Drawing.Point(5, 44);
            this.ShowPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowPayment.Name = "ShowPayment";
            this.ShowPayment.ReadOnly = true;
            this.ShowPayment.RowHeadersWidth = 51;
            this.ShowPayment.RowTemplate.Height = 24;
            this.ShowPayment.Size = new System.Drawing.Size(477, 199);
            this.ShowPayment.TabIndex = 0;
            // 
            // UpdatePayment
            // 
            this.UpdatePayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdatePayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdatePayment.Location = new System.Drawing.Point(5, 247);
            this.UpdatePayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdatePayment.Name = "UpdatePayment";
            this.UpdatePayment.Size = new System.Drawing.Size(200, 35);
            this.UpdatePayment.TabIndex = 1;
            this.UpdatePayment.Text = "Edytuj płatność";
            this.UpdatePayment.UseVisualStyleBackColor = false;
            this.UpdatePayment.Click += new System.EventHandler(this.UpdatePayment_Click);
            // 
            // OptionsPay
            // 
            this.OptionsPay.Controls.Add(this.label4);
            this.OptionsPay.Controls.Add(this.label3);
            this.OptionsPay.Controls.Add(this.label2);
            this.OptionsPay.Controls.Add(this.label1);
            this.OptionsPay.Controls.Add(this.TypePayment);
            this.OptionsPay.Controls.Add(this.IdReservation);
            this.OptionsPay.Controls.Add(this.UpdatePaymentPost);
            this.OptionsPay.Controls.Add(this.IdUser);
            this.OptionsPay.Controls.Add(this.DataPay);
            this.OptionsPay.Location = new System.Drawing.Point(486, 44);
            this.OptionsPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptionsPay.Name = "OptionsPay";
            this.OptionsPay.Size = new System.Drawing.Size(321, 199);
            this.OptionsPay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Identyfikator rezerwacji:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rodzaj płatności:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Identyfikator użytkownika:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data rezerwacji: ";
            // 
            // TypePayment
            // 
            this.TypePayment.FormattingEnabled = true;
            this.TypePayment.Location = new System.Drawing.Point(160, 76);
            this.TypePayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypePayment.Name = "TypePayment";
            this.TypePayment.Size = new System.Drawing.Size(151, 21);
            this.TypePayment.TabIndex = 5;
            // 
            // IdReservation
            // 
            this.IdReservation.Location = new System.Drawing.Point(160, 108);
            this.IdReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdReservation.Name = "IdReservation";
            this.IdReservation.Size = new System.Drawing.Size(151, 20);
            this.IdReservation.TabIndex = 4;
            // 
            // UpdatePaymentPost
            // 
            this.UpdatePaymentPost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdatePaymentPost.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdatePaymentPost.Location = new System.Drawing.Point(66, 146);
            this.UpdatePaymentPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdatePaymentPost.Name = "UpdatePaymentPost";
            this.UpdatePaymentPost.Size = new System.Drawing.Size(200, 35);
            this.UpdatePaymentPost.TabIndex = 3;
            this.UpdatePaymentPost.Text = "Aktualizuj";
            this.UpdatePaymentPost.UseVisualStyleBackColor = false;
            this.UpdatePaymentPost.Click += new System.EventHandler(this.UpdatePaymentPost_Click);
            // 
            // IdUser
            // 
            this.IdUser.Location = new System.Drawing.Point(160, 45);
            this.IdUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdUser.Name = "IdUser";
            this.IdUser.Size = new System.Drawing.Size(151, 20);
            this.IdUser.TabIndex = 1;
            // 
            // DataPay
            // 
            this.DataPay.Location = new System.Drawing.Point(160, 18);
            this.DataPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataPay.Name = "DataPay";
            this.DataPay.Size = new System.Drawing.Size(151, 20);
            this.DataPay.TabIndex = 0;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(597, 330);
            this.Answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 13);
            this.Answer.TabIndex = 3;
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Return.Location = new System.Drawing.Point(466, 1);
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
            this.Main.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Main.Location = new System.Drawing.Point(637, 1);
            this.Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(170, 30);
            this.Main.TabIndex = 5;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1034, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // UpdatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 290);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.OptionsPay);
            this.Controls.Add(this.UpdatePayment);
            this.Controls.Add(this.ShowPayment);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdatePay";
            this.Text = "UpdatePay";
            ((System.ComponentModel.ISupportInitialize)(this.ShowPayment)).EndInit();
            this.OptionsPay.ResumeLayout(false);
            this.OptionsPay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowPayment;
        private System.Windows.Forms.Button UpdatePayment;
        private System.Windows.Forms.Panel OptionsPay;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox IdUser;
        private System.Windows.Forms.DateTimePicker DataPay;
        private System.Windows.Forms.Button UpdatePaymentPost;
        private System.Windows.Forms.TextBox IdReservation;
        private System.Windows.Forms.ComboBox TypePayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Label label5;
    }
}