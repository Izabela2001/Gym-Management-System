﻿namespace Gym_Management_System
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
            this.IdUserReservation = new System.Windows.Forms.TextBox();
            this.Dodaj_Reserwacje = new System.Windows.Forms.Button();
            this.List_FitnessClass = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpptionPaid = new System.Windows.Forms.GroupBox();
            this.TruePaid = new System.Windows.Forms.RadioButton();
            this.FalsePaid = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(36, 70);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(154, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Identyfikator użytkownika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identyfikator zajęć";
            // 
            // IdUserReservation
            // 
            this.IdUserReservation.Location = new System.Drawing.Point(209, 67);
            this.IdUserReservation.Name = "IdUserReservation";
            this.IdUserReservation.Size = new System.Drawing.Size(142, 22);
            this.IdUserReservation.TabIndex = 3;
            // 
            // Dodaj_Reserwacje
            // 
            this.Dodaj_Reserwacje.Location = new System.Drawing.Point(182, 538);
            this.Dodaj_Reserwacje.Name = "Dodaj_Reserwacje";
            this.Dodaj_Reserwacje.Size = new System.Drawing.Size(75, 23);
            this.Dodaj_Reserwacje.TabIndex = 4;
            this.Dodaj_Reserwacje.Text = "Dodaj";
            this.Dodaj_Reserwacje.UseVisualStyleBackColor = true;
            this.Dodaj_Reserwacje.Click += new System.EventHandler(this.Dodaj_Reserwacje_Click);
            // 
            // List_FitnessClass
            // 
            this.List_FitnessClass.FormattingEnabled = true;
            this.List_FitnessClass.Location = new System.Drawing.Point(209, 108);
            this.List_FitnessClass.Name = "List_FitnessClass";
            this.List_FitnessClass.Size = new System.Drawing.Size(174, 38);
            this.List_FitnessClass.TabIndex = 7;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Czy opłacone?";
            // 
            // OpptionPaid
            // 
            this.OpptionPaid.Location = new System.Drawing.Point(43, 252);
            this.OpptionPaid.Name = "OpptionPaid";
            this.OpptionPaid.Size = new System.Drawing.Size(395, 227);
            this.OpptionPaid.TabIndex = 11;
            this.OpptionPaid.TabStop = false;
            this.OpptionPaid.Text = "Właściowści";
            this.OpptionPaid.Enter += new System.EventHandler(this.OpptionPaid_Enter);
            // 
            // TruePaid
            // 
            this.TruePaid.AutoSize = true;
            this.TruePaid.Location = new System.Drawing.Point(209, 168);
            this.TruePaid.Name = "TruePaid";
            this.TruePaid.Size = new System.Drawing.Size(90, 20);
            this.TruePaid.TabIndex = 13;
            this.TruePaid.TabStop = true;
            this.TruePaid.Text = "Opłacone";
            this.TruePaid.UseVisualStyleBackColor = true;
            this.TruePaid.CheckedChanged += new System.EventHandler(this.TruePaid_CheckedChanged);
            // 
            // FalsePaid
            // 
            this.FalsePaid.AutoSize = true;
            this.FalsePaid.Location = new System.Drawing.Point(209, 201);
            this.FalsePaid.Name = "FalsePaid";
            this.FalsePaid.Size = new System.Drawing.Size(112, 20);
            this.FalsePaid.TabIndex = 14;
            this.FalsePaid.TabStop = true;
            this.FalsePaid.Text = "Nie opłacono";
            this.FalsePaid.UseVisualStyleBackColor = true;
            this.FalsePaid.CheckedChanged += new System.EventHandler(this.FalsePaid_CheckedChanged);
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 596);
            this.Controls.Add(this.FalsePaid);
            this.Controls.Add(this.TruePaid);
            this.Controls.Add(this.OpptionPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.List_FitnessClass);
            this.Controls.Add(this.Dodaj_Reserwacje);
            this.Controls.Add(this.IdUserReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Name = "AddReservation";
            this.Text = "AddReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdUserReservation;
        internal System.Windows.Forms.Button Dodaj_Reserwacje;
        private System.Windows.Forms.CheckedListBox List_FitnessClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox OpptionPaid;
        private System.Windows.Forms.RadioButton TruePaid;
        private System.Windows.Forms.RadioButton FalsePaid;
    }
}