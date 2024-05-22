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
            ((System.ComponentModel.ISupportInitialize)(this.ShowPayment)).BeginInit();
            this.OptionsPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowPayment
            // 
            this.ShowPayment.AllowUserToAddRows = false;
            this.ShowPayment.AllowUserToDeleteRows = false;
            this.ShowPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowPayment.Location = new System.Drawing.Point(37, 32);
            this.ShowPayment.Name = "ShowPayment";
            this.ShowPayment.ReadOnly = true;
            this.ShowPayment.RowHeadersWidth = 51;
            this.ShowPayment.RowTemplate.Height = 24;
            this.ShowPayment.Size = new System.Drawing.Size(696, 245);
            this.ShowPayment.TabIndex = 0;
            // 
            // UpdatePayment
            // 
            this.UpdatePayment.Location = new System.Drawing.Point(260, 296);
            this.UpdatePayment.Name = "UpdatePayment";
            this.UpdatePayment.Size = new System.Drawing.Size(204, 42);
            this.UpdatePayment.TabIndex = 1;
            this.UpdatePayment.Text = "Edytuj płatność";
            this.UpdatePayment.UseVisualStyleBackColor = true;
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
            this.OptionsPay.Location = new System.Drawing.Point(37, 344);
            this.OptionsPay.Name = "OptionsPay";
            this.OptionsPay.Size = new System.Drawing.Size(427, 239);
            this.OptionsPay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Identyfikator rezerwacji:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rodzaj płatności:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Identyfikator użytkownika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data rezerwacji: ";
            // 
            // TypePayment
            // 
            this.TypePayment.FormattingEnabled = true;
            this.TypePayment.Location = new System.Drawing.Point(213, 103);
            this.TypePayment.Name = "TypePayment";
            this.TypePayment.Size = new System.Drawing.Size(121, 24);
            this.TypePayment.TabIndex = 5;
            // 
            // IdReservation
            // 
            this.IdReservation.Location = new System.Drawing.Point(213, 137);
            this.IdReservation.Name = "IdReservation";
            this.IdReservation.Size = new System.Drawing.Size(100, 22);
            this.IdReservation.TabIndex = 4;
            // 
            // UpdatePaymentPost
            // 
            this.UpdatePaymentPost.Location = new System.Drawing.Point(153, 194);
            this.UpdatePaymentPost.Name = "UpdatePaymentPost";
            this.UpdatePaymentPost.Size = new System.Drawing.Size(75, 23);
            this.UpdatePaymentPost.TabIndex = 3;
            this.UpdatePaymentPost.Text = "Aktualizuj";
            this.UpdatePaymentPost.UseVisualStyleBackColor = true;
            this.UpdatePaymentPost.Click += new System.EventHandler(this.UpdatePaymentPost_Click);
            // 
            // IdUser
            // 
            this.IdUser.Location = new System.Drawing.Point(213, 68);
            this.IdUser.Name = "IdUser";
            this.IdUser.Size = new System.Drawing.Size(100, 22);
            this.IdUser.TabIndex = 1;
            // 
            // DataPay
            // 
            this.DataPay.Location = new System.Drawing.Point(213, 36);
            this.DataPay.Name = "DataPay";
            this.DataPay.Size = new System.Drawing.Size(200, 22);
            this.DataPay.TabIndex = 0;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(484, 386);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 16);
            this.Answer.TabIndex = 3;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(58, 296);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(187, 42);
            this.Return.TabIndex = 4;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(478, 296);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(229, 42);
            this.Main.TabIndex = 5;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // UpdatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.OptionsPay);
            this.Controls.Add(this.UpdatePayment);
            this.Controls.Add(this.ShowPayment);
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
    }
}