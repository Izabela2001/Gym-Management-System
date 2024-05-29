namespace Gym_Management_System
{
    partial class Payment
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
            this.ShowNoPaid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PaidPayment = new System.Windows.Forms.Button();
            this.UpdatePayment = new System.Windows.Forms.Button();
            this.AddPayment = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            this.ApprovedPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPayment
            // 
            this.ShowPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowPayment.Location = new System.Drawing.Point(332, 41);
            this.ShowPayment.Name = "ShowPayment";
            this.ShowPayment.RowHeadersWidth = 51;
            this.ShowPayment.RowTemplate.Height = 24;
            this.ShowPayment.Size = new System.Drawing.Size(1011, 377);
            this.ShowPayment.TabIndex = 0;
            // 
            // ShowNoPaid
            // 
            this.ShowNoPaid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowNoPaid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowNoPaid.Location = new System.Drawing.Point(44, 41);
            this.ShowNoPaid.Name = "ShowNoPaid";
            this.ShowNoPaid.Size = new System.Drawing.Size(263, 54);
            this.ShowNoPaid.TabIndex = 1;
            this.ShowNoPaid.Text = "Wyświetl płatności nie zapłacone w terminie";
            this.ShowNoPaid.UseVisualStyleBackColor = false;
            this.ShowNoPaid.Click += new System.EventHandler(this.ShowNoPaid_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(44, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wyświetl płatności po terminie nie zapłacone";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaidPayment
            // 
            this.PaidPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PaidPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaidPayment.Location = new System.Drawing.Point(44, 165);
            this.PaidPayment.Name = "PaidPayment";
            this.PaidPayment.Size = new System.Drawing.Size(263, 66);
            this.PaidPayment.TabIndex = 3;
            this.PaidPayment.Text = "Wyświetl płatności opłacone";
            this.PaidPayment.UseVisualStyleBackColor = false;
            this.PaidPayment.Click += new System.EventHandler(this.PaidPayment_Click);
            // 
            // UpdatePayment
            // 
            this.UpdatePayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdatePayment.ForeColor = System.Drawing.Color.Snow;
            this.UpdatePayment.Location = new System.Drawing.Point(44, 237);
            this.UpdatePayment.Name = "UpdatePayment";
            this.UpdatePayment.Size = new System.Drawing.Size(263, 52);
            this.UpdatePayment.TabIndex = 5;
            this.UpdatePayment.Text = "Edycja płatności";
            this.UpdatePayment.UseVisualStyleBackColor = false;
            this.UpdatePayment.Click += new System.EventHandler(this.UpdatePayment_Click);
            // 
            // AddPayment
            // 
            this.AddPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPayment.Location = new System.Drawing.Point(44, 295);
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Size = new System.Drawing.Size(263, 39);
            this.AddPayment.TabIndex = 6;
            this.AddPayment.Text = "Dodaj płatność";
            this.AddPayment.UseVisualStyleBackColor = false;
            this.AddPayment.Click += new System.EventHandler(this.AddPayment_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main.Location = new System.Drawing.Point(44, 382);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(263, 45);
            this.Main.TabIndex = 7;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // ApprovedPayment
            // 
            this.ApprovedPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApprovedPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApprovedPayment.Location = new System.Drawing.Point(44, 340);
            this.ApprovedPayment.Name = "ApprovedPayment";
            this.ApprovedPayment.Size = new System.Drawing.Size(263, 36);
            this.ApprovedPayment.TabIndex = 8;
            this.ApprovedPayment.Text = "Akceptuj płatność";
            this.ApprovedPayment.UseVisualStyleBackColor = false;
            this.ApprovedPayment.Click += new System.EventHandler(this.ApprovedPayment_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 494);
            this.Controls.Add(this.ApprovedPayment);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.AddPayment);
            this.Controls.Add(this.UpdatePayment);
            this.Controls.Add(this.PaidPayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowNoPaid);
            this.Controls.Add(this.ShowPayment);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.ShowPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowPayment;
        private System.Windows.Forms.Button ShowNoPaid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PaidPayment;
        private System.Windows.Forms.Button UpdatePayment;
        private System.Windows.Forms.Button AddPayment;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button ApprovedPayment;
    }
}