namespace Gym_Management_System
{
    partial class Reservation
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
            this.AddReservation = new System.Windows.Forms.Button();
            this.Approve_Reservation = new System.Windows.Forms.Button();
            this.UpdateReservation = new System.Windows.Forms.Button();
            this.ReturnApp = new System.Windows.Forms.Button();
            this.ShowReservationAfter = new System.Windows.Forms.Button();
            this.ReservationShow = new System.Windows.Forms.DataGridView();
            this.ToDayReservation = new System.Windows.Forms.Button();
            this.AllReservation = new System.Windows.Forms.Button();
            this.DeleteReservation = new System.Windows.Forms.Button();
            this.Return_Reservation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).BeginInit();
            this.SuspendLayout();
            // 
            // AddReservation
            // 
            this.AddReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddReservation.Location = new System.Drawing.Point(520, 184);
            this.AddReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddReservation.Name = "AddReservation";
            this.AddReservation.Size = new System.Drawing.Size(202, 38);
            this.AddReservation.TabIndex = 0;
            this.AddReservation.Text = "Dodaj rezerwacje";
            this.AddReservation.UseVisualStyleBackColor = false;
            this.AddReservation.Click += new System.EventHandler(this.AddReservation_Click);
            // 
            // Approve_Reservation
            // 
            this.Approve_Reservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Approve_Reservation.ForeColor = System.Drawing.SystemColors.Control;
            this.Approve_Reservation.Location = new System.Drawing.Point(520, 226);
            this.Approve_Reservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Approve_Reservation.Name = "Approve_Reservation";
            this.Approve_Reservation.Size = new System.Drawing.Size(202, 38);
            this.Approve_Reservation.TabIndex = 1;
            this.Approve_Reservation.Text = "Akceptuj rezerwacje";
            this.Approve_Reservation.UseVisualStyleBackColor = false;
            this.Approve_Reservation.Click += new System.EventHandler(this.Approve_Reservation_Click);
            // 
            // UpdateReservation
            // 
            this.UpdateReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateReservation.Location = new System.Drawing.Point(520, 268);
            this.UpdateReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateReservation.Name = "UpdateReservation";
            this.UpdateReservation.Size = new System.Drawing.Size(202, 38);
            this.UpdateReservation.TabIndex = 2;
            this.UpdateReservation.Text = "Aktualizuj rezerwacje";
            this.UpdateReservation.UseVisualStyleBackColor = false;
            this.UpdateReservation.Click += new System.EventHandler(this.UpdateReservation_Click);
            // 
            // ReturnApp
            // 
            this.ReturnApp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReturnApp.ForeColor = System.Drawing.Color.Snow;
            this.ReturnApp.Location = new System.Drawing.Point(530, 0);
            this.ReturnApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReturnApp.Name = "ReturnApp";
            this.ReturnApp.Size = new System.Drawing.Size(200, 30);
            this.ReturnApp.TabIndex = 3;
            this.ReturnApp.Text = "Strona główna";
            this.ReturnApp.UseVisualStyleBackColor = false;
            this.ReturnApp.Click += new System.EventHandler(this.ReturnApp_Click);
            // 
            // ShowReservationAfter
            // 
            this.ShowReservationAfter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowReservationAfter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowReservationAfter.Location = new System.Drawing.Point(520, 128);
            this.ShowReservationAfter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowReservationAfter.Name = "ShowReservationAfter";
            this.ShowReservationAfter.Size = new System.Drawing.Size(202, 38);
            this.ShowReservationAfter.TabIndex = 4;
            this.ShowReservationAfter.Text = "Rezerwacje po terminie";
            this.ShowReservationAfter.UseVisualStyleBackColor = false;
            this.ShowReservationAfter.Click += new System.EventHandler(this.ShowReservationAfter_Click);
            // 
            // ReservationShow
            // 
            this.ReservationShow.AllowUserToAddRows = false;
            this.ReservationShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationShow.Enabled = false;
            this.ReservationShow.Location = new System.Drawing.Point(20, 43);
            this.ReservationShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReservationShow.Name = "ReservationShow";
            this.ReservationShow.ReadOnly = true;
            this.ReservationShow.RowHeadersWidth = 51;
            this.ReservationShow.RowTemplate.Height = 24;
            this.ReservationShow.Size = new System.Drawing.Size(484, 305);
            this.ReservationShow.TabIndex = 5;
            this.ReservationShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationShow_CellContentClick);
            // 
            // ToDayReservation
            // 
            this.ToDayReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToDayReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToDayReservation.Location = new System.Drawing.Point(520, 85);
            this.ToDayReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToDayReservation.Name = "ToDayReservation";
            this.ToDayReservation.Size = new System.Drawing.Size(202, 39);
            this.ToDayReservation.TabIndex = 6;
            this.ToDayReservation.Text = "Dzisiejsze rezerwacje";
            this.ToDayReservation.UseVisualStyleBackColor = false;
            this.ToDayReservation.Click += new System.EventHandler(this.ToDayReservation_Click);
            // 
            // AllReservation
            // 
            this.AllReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllReservation.Location = new System.Drawing.Point(520, 43);
            this.AllReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllReservation.Name = "AllReservation";
            this.AllReservation.Size = new System.Drawing.Size(202, 38);
            this.AllReservation.TabIndex = 7;
            this.AllReservation.Text = "Wyświetl wszystkie rezerwacje";
            this.AllReservation.UseVisualStyleBackColor = false;
            this.AllReservation.Click += new System.EventHandler(this.AllReservation_Click);
            // 
            // DeleteReservation
            // 
            this.DeleteReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteReservation.Location = new System.Drawing.Point(520, 310);
            this.DeleteReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteReservation.Name = "DeleteReservation";
            this.DeleteReservation.Size = new System.Drawing.Size(202, 38);
            this.DeleteReservation.TabIndex = 8;
            this.DeleteReservation.TabStop = false;
            this.DeleteReservation.Text = "Usuń rezerwacje";
            this.DeleteReservation.UseVisualStyleBackColor = false;
            this.DeleteReservation.Click += new System.EventHandler(this.DeleteReservation_Click);
            // 
            // Return_Reservation
            // 
            this.Return_Reservation.AutoSize = true;
            this.Return_Reservation.Location = new System.Drawing.Point(422, 477);
            this.Return_Reservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Return_Reservation.Name = "Return_Reservation";
            this.Return_Reservation.Size = new System.Drawing.Size(0, 13);
            this.Return_Reservation.TabIndex = 9;
            this.Return_Reservation.Click += new System.EventHandler(this.Return_Reservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-7, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 366);
            this.Controls.Add(this.ReturnApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Return_Reservation);
            this.Controls.Add(this.DeleteReservation);
            this.Controls.Add(this.AllReservation);
            this.Controls.Add(this.ToDayReservation);
            this.Controls.Add(this.ReservationShow);
            this.Controls.Add(this.ShowReservationAfter);
            this.Controls.Add(this.UpdateReservation);
            this.Controls.Add(this.Approve_Reservation);
            this.Controls.Add(this.AddReservation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddReservation;
        private System.Windows.Forms.Button Approve_Reservation;
        private System.Windows.Forms.Button UpdateReservation;
        private System.Windows.Forms.Button ReturnApp;
        private System.Windows.Forms.Button ShowReservationAfter;
        private System.Windows.Forms.DataGridView ReservationShow;
        private System.Windows.Forms.Button ToDayReservation;
        private System.Windows.Forms.Button AllReservation;
        private System.Windows.Forms.Button DeleteReservation;

        private System.Windows.Forms.Label Return_Reservation;
        private System.Windows.Forms.Label label1;
    }
}