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
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPayment
            // 
            this.AllPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPayment.Location = new System.Drawing.Point(7, 41);
            this.AllPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllPayment.Name = "AllPayment";
            this.AllPayment.RowHeadersWidth = 51;
            this.AllPayment.Size = new System.Drawing.Size(558, 212);
            this.AllPayment.TabIndex = 0;
            // 
            // Approved_payment
            // 
            this.Approved_payment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Approved_payment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Approved_payment.Location = new System.Drawing.Point(7, 257);
            this.Approved_payment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Approved_payment.Name = "Approved_payment";
            this.Approved_payment.Size = new System.Drawing.Size(200, 45);
            this.Approved_payment.TabIndex = 1;
            this.Approved_payment.Text = "Akceptuj płatność";
            this.Approved_payment.UseVisualStyleBackColor = false;
            this.Approved_payment.Click += new System.EventHandler(this.Approved_payment_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(28, 319);
            this.Answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 13);
            this.Answer.TabIndex = 2;
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Return.Location = new System.Drawing.Point(272, 1);
            this.Return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(150, 30);
            this.Return.TabIndex = 3;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.SystemColors.Control;
            this.Main.Location = new System.Drawing.Point(424, 1);
            this.Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(150, 30);
            this.Main.TabIndex = 4;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1034, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // ApprovedPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 313);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Approved_payment);
            this.Controls.Add(this.AllPayment);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label4;
    }
}