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
            this.Answer = new System.Windows.Forms.Label();
            this.DataPay = new System.Windows.Forms.DateTimePicker();
            this.IdUser = new System.Windows.Forms.TextBox();
            this.TypePayment = new System.Windows.Forms.CheckedListBox();
            this.UpdatePaymentPost = new System.Windows.Forms.Button();
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
            this.UpdatePayment.Location = new System.Drawing.Point(268, 296);
            this.UpdatePayment.Name = "UpdatePayment";
            this.UpdatePayment.Size = new System.Drawing.Size(204, 42);
            this.UpdatePayment.TabIndex = 1;
            this.UpdatePayment.Text = "Edytuj płatność";
            this.UpdatePayment.UseVisualStyleBackColor = true;
            this.UpdatePayment.Click += new System.EventHandler(this.UpdatePayment_Click);
            // 
            // OptionsPay
            // 
            this.OptionsPay.Controls.Add(this.UpdatePaymentPost);
            this.OptionsPay.Controls.Add(this.TypePayment);
            this.OptionsPay.Controls.Add(this.IdUser);
            this.OptionsPay.Controls.Add(this.DataPay);
            this.OptionsPay.Location = new System.Drawing.Point(56, 362);
            this.OptionsPay.Name = "OptionsPay";
            this.OptionsPay.Size = new System.Drawing.Size(355, 162);
            this.OptionsPay.TabIndex = 2;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(470, 386);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(44, 16);
            this.Answer.TabIndex = 3;
            this.Answer.Text = "label1";
            // 
            // DataPay
            // 
            this.DataPay.Location = new System.Drawing.Point(132, 24);
            this.DataPay.Name = "DataPay";
            this.DataPay.Size = new System.Drawing.Size(200, 22);
            this.DataPay.TabIndex = 0;
            // 
            // IdUser
            // 
            this.IdUser.Location = new System.Drawing.Point(132, 69);
            this.IdUser.Name = "IdUser";
            this.IdUser.Size = new System.Drawing.Size(100, 22);
            this.IdUser.TabIndex = 1;
            // 
            // TypePayment
            // 
            this.TypePayment.FormattingEnabled = true;
            this.TypePayment.Location = new System.Drawing.Point(132, 97);
            this.TypePayment.Name = "TypePayment";
            this.TypePayment.Size = new System.Drawing.Size(120, 89);
            this.TypePayment.TabIndex = 2;
            // 
            // UpdatePaymentPost
            // 
            this.UpdatePaymentPost.Location = new System.Drawing.Point(32, 53);
            this.UpdatePaymentPost.Name = "UpdatePaymentPost";
            this.UpdatePaymentPost.Size = new System.Drawing.Size(75, 23);
            this.UpdatePaymentPost.TabIndex = 3;
            this.UpdatePaymentPost.Text = "button1";
            this.UpdatePaymentPost.UseVisualStyleBackColor = true;
            this.UpdatePaymentPost.Click += new System.EventHandler(this.UpdatePaymentPost_Click);
            // 
            // UpdatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
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
        private System.Windows.Forms.CheckedListBox TypePayment;
        private System.Windows.Forms.TextBox IdUser;
        private System.Windows.Forms.DateTimePicker DataPay;
        private System.Windows.Forms.Button UpdatePaymentPost;
    }
}