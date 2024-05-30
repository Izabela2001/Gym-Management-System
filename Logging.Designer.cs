namespace Gym_Management_System
{
    partial class Logging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logging));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Hasło = new System.Windows.Forms.TextBox();
            this.Logowanie = new System.Windows.Forms.Button();
            this.ZdjecieLogowania = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ZdjecieLogowania)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj hasło : ";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(129, 298);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(170, 20);
            this.Login.TabIndex = 2;
            // 
            // Hasło
            // 
            this.Hasło.Location = new System.Drawing.Point(129, 330);
            this.Hasło.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hasło.Name = "Hasło";
            this.Hasło.PasswordChar = '*';
            this.Hasło.Size = new System.Drawing.Size(170, 20);
            this.Hasło.TabIndex = 3;
            // 
            // Logowanie
            // 
            this.Logowanie.BackColor = System.Drawing.Color.Black;
            this.Logowanie.ForeColor = System.Drawing.Color.Snow;
            this.Logowanie.Location = new System.Drawing.Point(129, 366);
            this.Logowanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logowanie.Name = "Logowanie";
            this.Logowanie.Size = new System.Drawing.Size(111, 34);
            this.Logowanie.TabIndex = 4;
            this.Logowanie.Text = "Zaloguj się";
            this.Logowanie.UseVisualStyleBackColor = false;
            this.Logowanie.Click += new System.EventHandler(this.Logowanie_Click);
            // 
            // ZdjecieLogowania
            // 
            this.ZdjecieLogowania.Image = ((System.Drawing.Image)(resources.GetObject("ZdjecieLogowania.Image")));
            this.ZdjecieLogowania.ImageLocation = "";
            this.ZdjecieLogowania.InitialImage = ((System.Drawing.Image)(resources.GetObject("ZdjecieLogowania.InitialImage")));
            this.ZdjecieLogowania.Location = new System.Drawing.Point(68, 21);
            this.ZdjecieLogowania.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZdjecieLogowania.Name = "ZdjecieLogowania";
            this.ZdjecieLogowania.Size = new System.Drawing.Size(231, 254);
            this.ZdjecieLogowania.TabIndex = 5;
            this.ZdjecieLogowania.TabStop = false;
            this.ZdjecieLogowania.WaitOnLoad = true;
            // 
            // Logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(365, 446);
            this.Controls.Add(this.ZdjecieLogowania);
            this.Controls.Add(this.Logowanie);
            this.Controls.Add(this.Hasło);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Logging";
            this.Text = "Fitnesso - logowanie";
            ((System.ComponentModel.ISupportInitialize)(this.ZdjecieLogowania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Hasło;
        private System.Windows.Forms.Button Logowanie;
        private System.Windows.Forms.PictureBox ZdjecieLogowania;
    }
}