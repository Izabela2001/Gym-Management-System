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
            ((System.ComponentModel.ISupportInitialize)(this.AllPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPayment
            // 
            this.AllPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPayment.Location = new System.Drawing.Point(41, 34);
            this.AllPayment.Name = "AllPayment";
            this.AllPayment.RowHeadersWidth = 51;
            this.AllPayment.Size = new System.Drawing.Size(370, 261);
            this.AllPayment.TabIndex = 0;
            // 
            // Approved_payment
            // 
            this.Approved_payment.Location = new System.Drawing.Point(510, 55);
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
            this.Answer.Location = new System.Drawing.Point(84, 323);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(44, 16);
            this.Answer.TabIndex = 2;
            this.Answer.Text = "label1";
            // 
            // ApprovedPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}