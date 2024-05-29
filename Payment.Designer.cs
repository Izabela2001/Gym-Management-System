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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPayment
            // 
            this.ShowPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowPayment.Enabled = false;
            this.ShowPayment.Location = new System.Drawing.Point(6, 48);
            this.ShowPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowPayment.Name = "ShowPayment";
            this.ShowPayment.RowHeadersWidth = 51;
            this.ShowPayment.RowTemplate.Height = 24;
            this.ShowPayment.Size = new System.Drawing.Size(590, 306);
            this.ShowPayment.TabIndex = 0;
            // 
            // ShowNoPaid
            // 
            this.ShowNoPaid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowNoPaid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowNoPaid.Location = new System.Drawing.Point(609, 46);
            this.ShowNoPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowNoPaid.Name = "ShowNoPaid";
            this.ShowNoPaid.Size = new System.Drawing.Size(200, 45);
            this.ShowNoPaid.TabIndex = 1;
            this.ShowNoPaid.Text = "Wyświetl nieopłacone w terminie płatności";
            this.ShowNoPaid.UseVisualStyleBackColor = false;
            this.ShowNoPaid.Click += new System.EventHandler(this.ShowNoPaid_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(609, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wyświetl płatności po terminie nie zapłacone";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaidPayment
            // 
            this.PaidPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PaidPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaidPayment.Location = new System.Drawing.Point(609, 144);
            this.PaidPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PaidPayment.Name = "PaidPayment";
            this.PaidPayment.Size = new System.Drawing.Size(200, 45);
            this.PaidPayment.TabIndex = 3;
            this.PaidPayment.Text = "Wyświetl płatności opłacone";
            this.PaidPayment.UseVisualStyleBackColor = false;
            this.PaidPayment.Click += new System.EventHandler(this.PaidPayment_Click);
            // 
            // UpdatePayment
            // 
            this.UpdatePayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdatePayment.ForeColor = System.Drawing.Color.Snow;
            this.UpdatePayment.Location = new System.Drawing.Point(609, 209);
            this.UpdatePayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdatePayment.Name = "UpdatePayment";
            this.UpdatePayment.Size = new System.Drawing.Size(200, 45);
            this.UpdatePayment.TabIndex = 5;
            this.UpdatePayment.Text = "Edycja płatności";
            this.UpdatePayment.UseVisualStyleBackColor = false;
            this.UpdatePayment.Click += new System.EventHandler(this.UpdatePayment_Click);
            // 
            // AddPayment
            // 
            this.AddPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPayment.Location = new System.Drawing.Point(609, 258);
            this.AddPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Size = new System.Drawing.Size(200, 45);
            this.AddPayment.TabIndex = 6;
            this.AddPayment.Text = "Dodaj płatność";
            this.AddPayment.UseVisualStyleBackColor = false;
            this.AddPayment.Click += new System.EventHandler(this.AddPayment_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main.Location = new System.Drawing.Point(618, 1);
            this.Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(200, 30);
            this.Main.TabIndex = 7;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // ApprovedPayment
            // 
            this.ApprovedPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApprovedPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApprovedPayment.Location = new System.Drawing.Point(609, 307);
            this.ApprovedPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApprovedPayment.Name = "ApprovedPayment";
            this.ApprovedPayment.Size = new System.Drawing.Size(200, 45);
            this.ApprovedPayment.TabIndex = 8;
            this.ApprovedPayment.Text = "Akceptuj płatność";
            this.ApprovedPayment.UseVisualStyleBackColor = false;
            this.ApprovedPayment.Click += new System.EventHandler(this.ApprovedPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 363);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApprovedPayment);
            this.Controls.Add(this.AddPayment);
            this.Controls.Add(this.UpdatePayment);
            this.Controls.Add(this.PaidPayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowNoPaid);
            this.Controls.Add(this.ShowPayment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.ShowPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}