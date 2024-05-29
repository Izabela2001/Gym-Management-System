namespace Gym_Management_System
{
    partial class AddReservation
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dodaj_Reserwacje = new System.Windows.Forms.Button();
            this.List_FitnessClass = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpptionPaid = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.List_TypePayment = new System.Windows.Forms.CheckedListBox();
            this.TruePaid = new System.Windows.Forms.RadioButton();
            this.FalsePaid = new System.Windows.Forms.RadioButton();
            this.Return_Reservation = new System.Windows.Forms.Button();
            this.IdUserReservation = new System.Windows.Forms.MaskedTextBox();
            this.Main = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Result_add = new System.Windows.Forms.Label();
            this.OpptionPaid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(27, 57);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(133, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Identyfikator użytkownika: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identyfikator zajęć";
            // 
            // Dodaj_Reserwacje
            // 
            this.Dodaj_Reserwacje.Location = new System.Drawing.Point(124, 288);
            this.Dodaj_Reserwacje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dodaj_Reserwacje.Name = "Dodaj_Reserwacje";
            this.Dodaj_Reserwacje.Size = new System.Drawing.Size(88, 35);
            this.Dodaj_Reserwacje.TabIndex = 4;
            this.Dodaj_Reserwacje.Text = "Dodaj";
            this.Dodaj_Reserwacje.UseVisualStyleBackColor = true;
            this.Dodaj_Reserwacje.Click += new System.EventHandler(this.Dodaj_Reserwacje_Click);
            // 
            // List_FitnessClass
            // 
            this.List_FitnessClass.FormattingEnabled = true;
            this.List_FitnessClass.Location = new System.Drawing.Point(157, 88);
            this.List_FitnessClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.List_FitnessClass.Name = "List_FitnessClass";
            this.List_FitnessClass.ScrollAlwaysVisible = true;
            this.List_FitnessClass.Size = new System.Drawing.Size(141, 34);
            this.List_FitnessClass.TabIndex = 7;
            this.List_FitnessClass.SelectedIndexChanged += new System.EventHandler(this.List_FitnessClass_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Czy opłacone?";
            // 
            // OpptionPaid
            // 
            this.OpptionPaid.Controls.Add(this.label3);
            this.OpptionPaid.Controls.Add(this.List_TypePayment);
            this.OpptionPaid.Location = new System.Drawing.Point(29, 195);
            this.OpptionPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpptionPaid.Name = "OpptionPaid";
            this.OpptionPaid.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpptionPaid.Size = new System.Drawing.Size(294, 89);
            this.OpptionPaid.TabIndex = 11;
            this.OpptionPaid.TabStop = false;
            this.OpptionPaid.Text = "Właściowści";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rodzaj płatności";
            // 
            // List_TypePayment
            // 
            this.List_TypePayment.FormattingEnabled = true;
            this.List_TypePayment.Location = new System.Drawing.Point(110, 37);
            this.List_TypePayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.List_TypePayment.Name = "List_TypePayment";
            this.List_TypePayment.Size = new System.Drawing.Size(159, 19);
            this.List_TypePayment.TabIndex = 0;
            // 
            // TruePaid
            // 
            this.TruePaid.AutoSize = true;
            this.TruePaid.Location = new System.Drawing.Point(157, 136);
            this.TruePaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TruePaid.Name = "TruePaid";
            this.TruePaid.Size = new System.Drawing.Size(73, 17);
            this.TruePaid.TabIndex = 13;
            this.TruePaid.TabStop = true;
            this.TruePaid.Text = "Opłacone";
            this.TruePaid.UseVisualStyleBackColor = true;
            this.TruePaid.CheckedChanged += new System.EventHandler(this.TruePaid_CheckedChanged);
            // 
            // FalsePaid
            // 
            this.FalsePaid.AutoSize = true;
            this.FalsePaid.Location = new System.Drawing.Point(157, 163);
            this.FalsePaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FalsePaid.Name = "FalsePaid";
            this.FalsePaid.Size = new System.Drawing.Size(90, 17);
            this.FalsePaid.TabIndex = 14;
            this.FalsePaid.TabStop = true;
            this.FalsePaid.Text = "Nie opłacono";
            this.FalsePaid.UseVisualStyleBackColor = true;
            this.FalsePaid.CheckedChanged += new System.EventHandler(this.FalsePaid_CheckedChanged);
            // 
            // Return_Reservation
            // 
            this.Return_Reservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return_Reservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Return_Reservation.Location = new System.Drawing.Point(322, -1);
            this.Return_Reservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Return_Reservation.Name = "Return_Reservation";
            this.Return_Reservation.Size = new System.Drawing.Size(102, 35);
            this.Return_Reservation.TabIndex = 16;
            this.Return_Reservation.Text = "Wróć";
            this.Return_Reservation.UseVisualStyleBackColor = false;
            this.Return_Reservation.Click += new System.EventHandler(this.Return_Reservation_Click);
            // 
            // IdUserReservation
            // 
            this.IdUserReservation.Location = new System.Drawing.Point(157, 57);
            this.IdUserReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdUserReservation.Mask = "00000";
            this.IdUserReservation.Name = "IdUserReservation";
            this.IdUserReservation.Size = new System.Drawing.Size(76, 20);
            this.IdUserReservation.TabIndex = 17;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Main.Location = new System.Drawing.Point(419, -1);
            this.Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(110, 35);
            this.Main.TabIndex = 18;
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
            this.label4.Location = new System.Drawing.Point(1, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1034, 33);
            this.label4.TabIndex = 19;
            this.label4.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // Result_add
            // 
            this.Result_add.AutoSize = true;
            this.Result_add.Location = new System.Drawing.Point(29, 332);
            this.Result_add.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Result_add.Name = "Result_add";
            this.Result_add.Size = new System.Drawing.Size(35, 13);
            this.Result_add.TabIndex = 15;
            this.Result_add.Text = "label3";
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 484);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.IdUserReservation);
            this.Controls.Add(this.Return_Reservation);
            this.Controls.Add(this.Result_add);
            this.Controls.Add(this.FalsePaid);
            this.Controls.Add(this.TruePaid);
            this.Controls.Add(this.OpptionPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.List_FitnessClass);
            this.Controls.Add(this.Dodaj_Reserwacje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddReservation";
            this.Text = "AddReservation";
            this.OpptionPaid.ResumeLayout(false);
            this.OpptionPaid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button Dodaj_Reserwacje;
        private System.Windows.Forms.CheckedListBox List_FitnessClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox OpptionPaid;
        private System.Windows.Forms.RadioButton TruePaid;
        private System.Windows.Forms.RadioButton FalsePaid;
        private System.Windows.Forms.CheckedListBox List_TypePayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Return_Reservation;
        private System.Windows.Forms.MaskedTextBox IdUserReservation;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Result_add;
    }
}