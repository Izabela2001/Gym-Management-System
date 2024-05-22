namespace Gym_Management_System.Pay
{
    partial class ApprovedPay
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
            this.AllPayment = new System.Windows.Forms.DataGridView();
            this.Approved_payment = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPayment
            // 
            this.AllPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPayment.Location = new System.Drawing.Point(41, 34);
            this.AllPayment.Name = "AllPayment";
            this.AllPayment.RowHeadersWidth = 51;
            this.AllPayment.Size = new System.Drawing.Size(716, 261);
            this.AllPayment.TabIndex = 0;
            // 
            // Approved_payment
            // 
            this.Approved_payment.Location = new System.Drawing.Point(287, 316);
            this.Approved_payment.Name = "Approved_payment";
            this.Approved_payment.Size = new System.Drawing.Size(194, 56);
            this.Approved_payment.TabIndex = 1;
            this.Approved_payment.Text = "Akceptuj płatność";
            this.Approved_payment.UseVisualStyleBackColor = true;
            this.Approved_payment.Click += new System.EventHandler(this.Approved_payment_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(38, 393);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 16);
            this.Answer.TabIndex = 2;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(81, 316);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(185, 56);
            this.Return.TabIndex = 3;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(504, 316);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(202, 56);
            this.Main.TabIndex = 4;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // ApprovedPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Approved_payment);
            this.Controls.Add(this.AllPayment);
            this.Name = "ApprovedPay";
            this.Text = "ApprovedPay";
            ((System.ComponentModel.ISupportInitialize)(this.AllPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllPayment;
        private System.Windows.Forms.Button Approved_payment;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Main;
    }
}