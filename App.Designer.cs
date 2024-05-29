namespace Gym_Management_System
{
    partial class App
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
            this.Display = new System.Windows.Forms.DataGridView();
            this.Display_reservation = new System.Windows.Forms.Button();
            this.Display_payment = new System.Windows.Forms.Button();
            this.Display_fitnessClass = new System.Windows.Forms.Button();
            this.Display_TypeClass = new System.Windows.Forms.Button();
            this.Add_Rese = new System.Windows.Forms.Button();
            this.Display_OptionButton = new System.Windows.Forms.RadioButton();
            this.Display_Options = new System.Windows.Forms.Panel();
            this.management = new System.Windows.Forms.RadioButton();
            this.ManagmentOptions = new System.Windows.Forms.Panel();
            this.ManagingPayment = new System.Windows.Forms.Button();
            this.ManagingReservation = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.Display_Options.SuspendLayout();
            this.ManagmentOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Display.Location = new System.Drawing.Point(11, 42);
            this.Display.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Display.RowTemplate.Height = 24;
            this.Display.Size = new System.Drawing.Size(879, 363);
            this.Display.TabIndex = 0;
            this.Display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Display_CellContentClick);
            // 
            // Display_reservation
            // 
            this.Display_reservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display_reservation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Display_reservation.Location = new System.Drawing.Point(44, 48);
            this.Display_reservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display_reservation.Name = "Display_reservation";
            this.Display_reservation.Size = new System.Drawing.Size(220, 35);
            this.Display_reservation.TabIndex = 1;
            this.Display_reservation.Text = "Wyświetl rezerwacje";
            this.Display_reservation.UseVisualStyleBackColor = false;
            this.Display_reservation.Click += new System.EventHandler(this.Display_reservation_Click);
            // 
            // Display_payment
            // 
            this.Display_payment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display_payment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Display_payment.Location = new System.Drawing.Point(44, 126);
            this.Display_payment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display_payment.Name = "Display_payment";
            this.Display_payment.Size = new System.Drawing.Size(220, 35);
            this.Display_payment.TabIndex = 2;
            this.Display_payment.Text = "Wyświtel płatności";
            this.Display_payment.UseVisualStyleBackColor = false;
            this.Display_payment.Click += new System.EventHandler(this.Display_payment_Click);
            // 
            // Display_fitnessClass
            // 
            this.Display_fitnessClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display_fitnessClass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Display_fitnessClass.Location = new System.Drawing.Point(44, 9);
            this.Display_fitnessClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display_fitnessClass.Name = "Display_fitnessClass";
            this.Display_fitnessClass.Size = new System.Drawing.Size(220, 35);
            this.Display_fitnessClass.TabIndex = 3;
            this.Display_fitnessClass.Text = "Wyświetl zajęcia";
            this.Display_fitnessClass.UseVisualStyleBackColor = false;
            this.Display_fitnessClass.Click += new System.EventHandler(this.Display_fitnessClass_Click);
            // 
            // Display_TypeClass
            // 
            this.Display_TypeClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display_TypeClass.ForeColor = System.Drawing.Color.Snow;
            this.Display_TypeClass.Location = new System.Drawing.Point(44, 87);
            this.Display_TypeClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display_TypeClass.Name = "Display_TypeClass";
            this.Display_TypeClass.Size = new System.Drawing.Size(220, 35);
            this.Display_TypeClass.TabIndex = 4;
            this.Display_TypeClass.Text = "Wyświetl typ zajęć";
            this.Display_TypeClass.UseVisualStyleBackColor = false;
            this.Display_TypeClass.Click += new System.EventHandler(this.Display_TypeClass_Click);
            // 
            // Add_Rese
            // 
            this.Add_Rese.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_Rese.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Rese.Location = new System.Drawing.Point(44, 12);
            this.Add_Rese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_Rese.Name = "Add_Rese";
            this.Add_Rese.Size = new System.Drawing.Size(220, 35);
            this.Add_Rese.TabIndex = 5;
            this.Add_Rese.Text = "Zarządzaj rezerwacjami";
            this.Add_Rese.UseVisualStyleBackColor = false;
            this.Add_Rese.Click += new System.EventHandler(this.Add_Rese_Click);
            // 
            // Display_OptionButton
            // 
            this.Display_OptionButton.AutoSize = true;
            this.Display_OptionButton.Location = new System.Drawing.Point(1003, 42);
            this.Display_OptionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display_OptionButton.Name = "Display_OptionButton";
            this.Display_OptionButton.Size = new System.Drawing.Size(87, 17);
            this.Display_OptionButton.TabIndex = 6;
            this.Display_OptionButton.TabStop = true;
            this.Display_OptionButton.Text = "Wyświetlanie";
            this.Display_OptionButton.UseVisualStyleBackColor = true;
            this.Display_OptionButton.CheckedChanged += new System.EventHandler(this.Display_OptionButton_CheckedChanged);
            // 
            // Display_Options
            // 
            this.Display_Options.Controls.Add(this.Display_fitnessClass);
            this.Display_Options.Controls.Add(this.Display_reservation);
            this.Display_Options.Controls.Add(this.Display_TypeClass);
            this.Display_Options.Controls.Add(this.Display_payment);
            this.Display_Options.Location = new System.Drawing.Point(894, 63);
            this.Display_Options.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display_Options.Name = "Display_Options";
            this.Display_Options.Size = new System.Drawing.Size(308, 174);
            this.Display_Options.TabIndex = 7;
            // 
            // management
            // 
            this.management.AutoSize = true;
            this.management.Location = new System.Drawing.Point(1003, 241);
            this.management.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.management.Name = "management";
            this.management.Size = new System.Drawing.Size(86, 17);
            this.management.TabIndex = 8;
            this.management.TabStop = true;
            this.management.Text = "Zarządzanie ";
            this.management.UseVisualStyleBackColor = true;
            this.management.CheckedChanged += new System.EventHandler(this.management_CheckedChanged);
            // 
            // ManagmentOptions
            // 
            this.ManagmentOptions.Controls.Add(this.ManagingPayment);
            this.ManagmentOptions.Controls.Add(this.ManagingReservation);
            this.ManagmentOptions.Controls.Add(this.Add_Rese);
            this.ManagmentOptions.Location = new System.Drawing.Point(894, 266);
            this.ManagmentOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagmentOptions.Name = "ManagmentOptions";
            this.ManagmentOptions.Size = new System.Drawing.Size(308, 139);
            this.ManagmentOptions.TabIndex = 9;
            // 
            // ManagingPayment
            // 
            this.ManagingPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManagingPayment.ForeColor = System.Drawing.SystemColors.Window;
            this.ManagingPayment.Location = new System.Drawing.Point(44, 90);
            this.ManagingPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagingPayment.Name = "ManagingPayment";
            this.ManagingPayment.Size = new System.Drawing.Size(220, 35);
            this.ManagingPayment.TabIndex = 7;
            this.ManagingPayment.Text = "Zarządzaj płatnościami";
            this.ManagingPayment.UseVisualStyleBackColor = false;
            this.ManagingPayment.Click += new System.EventHandler(this.ManagingPayment_Click);
            // 
            // ManagingReservation
            // 
            this.ManagingReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManagingReservation.ForeColor = System.Drawing.Color.Snow;
            this.ManagingReservation.Location = new System.Drawing.Point(44, 51);
            this.ManagingReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagingReservation.Name = "ManagingReservation";
            this.ManagingReservation.Size = new System.Drawing.Size(220, 35);
            this.ManagingReservation.TabIndex = 6;
            this.ManagingReservation.Text = "Zarządaj zajęciami";
            this.ManagingReservation.UseVisualStyleBackColor = false;
            this.ManagingReservation.Click += new System.EventHandler(this.ManagingReservation_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout.Location = new System.Drawing.Point(1042, 2);
            this.Logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(200, 30);
            this.Logout.TabIndex = 10;
            this.Logout.Text = "Wyloguj";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1358, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = " Fitnesso                                                                        " +
    "                                                               ";
            // 
            // App
            // 
            this.AcceptButton = this.Logout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 421);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ManagmentOptions);
            this.Controls.Add(this.management);
            this.Controls.Add(this.Display_Options);
            this.Controls.Add(this.Display_OptionButton);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.Display_Options.ResumeLayout(false);
            this.ManagmentOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Display;
        private System.Windows.Forms.Button Display_reservation;
        private System.Windows.Forms.Button Display_payment;
        private System.Windows.Forms.Button Display_fitnessClass;
        private System.Windows.Forms.Button Display_TypeClass;
        private System.Windows.Forms.Button Add_Rese;
        private System.Windows.Forms.RadioButton Display_OptionButton;
        private System.Windows.Forms.Panel Display_Options;
        private System.Windows.Forms.RadioButton management;
        private System.Windows.Forms.Panel ManagmentOptions;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ManagingPayment;
        private System.Windows.Forms.Button ManagingReservation;
        private System.Windows.Forms.Label label4;
    }
}