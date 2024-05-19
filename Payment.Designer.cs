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
            this.DeletePayment = new System.Windows.Forms.Button();
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
            this.ShowPayment.Location = new System.Drawing.Point(346, 50);
            this.ShowPayment.Name = "ShowPayment";
            this.ShowPayment.RowHeadersWidth = 51;
            this.ShowPayment.RowTemplate.Height = 24;
            this.ShowPayment.Size = new System.Drawing.Size(494, 329);
            this.ShowPayment.TabIndex = 0;
            // 
            // ShowNoPaid
            // 
            this.ShowNoPaid.Location = new System.Drawing.Point(44, 50);
            this.ShowNoPaid.Name = "ShowNoPaid";
            this.ShowNoPaid.Size = new System.Drawing.Size(263, 54);
            this.ShowNoPaid.TabIndex = 1;
            this.ShowNoPaid.Text = "Wyświetl płatności nie zapłacone w terminie";
            this.ShowNoPaid.UseVisualStyleBackColor = true;
            this.ShowNoPaid.Click += new System.EventHandler(this.ShowNoPaid_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wyświetl płatności po terminie nie zapłacone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaidPayment
            // 
            this.PaidPayment.Location = new System.Drawing.Point(44, 175);
            this.PaidPayment.Name = "PaidPayment";
            this.PaidPayment.Size = new System.Drawing.Size(263, 66);
            this.PaidPayment.TabIndex = 3;
            this.PaidPayment.Text = "Wyświetl płatności opłacone";
            this.PaidPayment.UseVisualStyleBackColor = true;
            this.PaidPayment.Click += new System.EventHandler(this.PaidPayment_Click);
            // 
            // DeletePayment
            // 
            this.DeletePayment.Location = new System.Drawing.Point(44, 247);
            this.DeletePayment.Name = "DeletePayment";
            this.DeletePayment.Size = new System.Drawing.Size(263, 56);
            this.DeletePayment.TabIndex = 4;
            this.DeletePayment.Text = "Usuń płatność";
            this.DeletePayment.UseVisualStyleBackColor = true;
            // 
            // UpdatePayment
            // 
            this.UpdatePayment.Location = new System.Drawing.Point(44, 310);
            this.UpdatePayment.Name = "UpdatePayment";
            this.UpdatePayment.Size = new System.Drawing.Size(263, 52);
            this.UpdatePayment.TabIndex = 5;
            this.UpdatePayment.Text = "Edycja płatności";
            this.UpdatePayment.UseVisualStyleBackColor = true;
            // 
            // AddPayment
            // 
            this.AddPayment.Location = new System.Drawing.Point(44, 368);
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Size = new System.Drawing.Size(263, 39);
            this.AddPayment.TabIndex = 6;
            this.AddPayment.Text = "Dodaj płatność";
            this.AddPayment.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(44, 413);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(263, 45);
            this.Main.TabIndex = 7;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // ApprovedPayment
            // 
            this.ApprovedPayment.Location = new System.Drawing.Point(44, 466);
            this.ApprovedPayment.Name = "ApprovedPayment";
            this.ApprovedPayment.Size = new System.Drawing.Size(263, 36);
            this.ApprovedPayment.TabIndex = 8;
            this.ApprovedPayment.Text = "Akceptuj płatność";
            this.ApprovedPayment.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 586);
            this.Controls.Add(this.ApprovedPayment);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.AddPayment);
            this.Controls.Add(this.UpdatePayment);
            this.Controls.Add(this.DeletePayment);
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
        private System.Windows.Forms.Button DeletePayment;
        private System.Windows.Forms.Button UpdatePayment;
        private System.Windows.Forms.Button AddPayment;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button ApprovedPayment;
    }
}