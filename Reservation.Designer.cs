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
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).BeginInit();
            this.SuspendLayout();
            // 
            // AddReservation
            // 
            this.AddReservation.Location = new System.Drawing.Point(84, 149);
            this.AddReservation.Name = "AddReservation";
            this.AddReservation.Size = new System.Drawing.Size(269, 40);
            this.AddReservation.TabIndex = 0;
            this.AddReservation.Text = "Dodaj Reservacje";
            this.AddReservation.UseVisualStyleBackColor = true;
            this.AddReservation.Click += new System.EventHandler(this.AddReservation_Click);
            // 
            // Approve_Reservation
            // 
            this.Approve_Reservation.Location = new System.Drawing.Point(84, 195);
            this.Approve_Reservation.Name = "Approve_Reservation";
            this.Approve_Reservation.Size = new System.Drawing.Size(269, 46);
            this.Approve_Reservation.TabIndex = 1;
            this.Approve_Reservation.Text = "Akceptacja rezerwacji";
            this.Approve_Reservation.UseVisualStyleBackColor = true;
            this.Approve_Reservation.Click += new System.EventHandler(this.Approve_Reservation_Click);
            // 
            // UpdateReservation
            // 
            this.UpdateReservation.Location = new System.Drawing.Point(84, 247);
            this.UpdateReservation.Name = "UpdateReservation";
            this.UpdateReservation.Size = new System.Drawing.Size(269, 39);
            this.UpdateReservation.TabIndex = 2;
            this.UpdateReservation.Text = "Aktualizuj Reserwacje";
            this.UpdateReservation.UseVisualStyleBackColor = true;
            this.UpdateReservation.Click += new System.EventHandler(this.UpdateReservation_Click);
            // 
            // ReturnApp
            // 
            this.ReturnApp.Location = new System.Drawing.Point(84, 307);
            this.ReturnApp.Name = "ReturnApp";
            this.ReturnApp.Size = new System.Drawing.Size(269, 39);
            this.ReturnApp.TabIndex = 3;
            this.ReturnApp.Text = "Powrót";
            this.ReturnApp.UseVisualStyleBackColor = true;
            this.ReturnApp.Click += new System.EventHandler(this.ReturnApp_Click);
            // 
            // ShowReservationAfter
            // 
            this.ShowReservationAfter.Location = new System.Drawing.Point(84, 80);
            this.ShowReservationAfter.Name = "ShowReservationAfter";
            this.ShowReservationAfter.Size = new System.Drawing.Size(269, 63);
            this.ShowReservationAfter.TabIndex = 4;
            this.ShowReservationAfter.Text = "Wyświetl reservacje po terminie";
            this.ShowReservationAfter.UseVisualStyleBackColor = true;
            this.ShowReservationAfter.Click += new System.EventHandler(this.ShowReservationAfter_Click);
            // 
            // ReservationShow
            // 
            this.ReservationShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationShow.Location = new System.Drawing.Point(386, 113);
            this.ReservationShow.Name = "ReservationShow";
            this.ReservationShow.RowHeadersWidth = 51;
            this.ReservationShow.RowTemplate.Height = 24;
            this.ReservationShow.Size = new System.Drawing.Size(652, 173);
            this.ReservationShow.TabIndex = 5;
            // 
            // ToDayReservation
            // 
            this.ToDayReservation.Location = new System.Drawing.Point(84, 12);
            this.ToDayReservation.Name = "ToDayReservation";
            this.ToDayReservation.Size = new System.Drawing.Size(365, 48);
            this.ToDayReservation.TabIndex = 6;
            this.ToDayReservation.Text = "Dzisiejsze rezerwacje";
            this.ToDayReservation.UseVisualStyleBackColor = true;
            this.ToDayReservation.Click += new System.EventHandler(this.ToDayReservation_Click);
            // 
            // AllReservation
            // 
            this.AllReservation.Location = new System.Drawing.Point(84, 362);
            this.AllReservation.Name = "AllReservation";
            this.AllReservation.Size = new System.Drawing.Size(365, 39);
            this.AllReservation.TabIndex = 7;
            this.AllReservation.Text = "Wyświetl wszytskie rezerwacje";
            this.AllReservation.UseVisualStyleBackColor = true;
            this.AllReservation.Click += new System.EventHandler(this.AllReservation_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 544);
            this.Controls.Add(this.AllReservation);
            this.Controls.Add(this.ToDayReservation);
            this.Controls.Add(this.ReservationShow);
            this.Controls.Add(this.ShowReservationAfter);
            this.Controls.Add(this.ReturnApp);
            this.Controls.Add(this.UpdateReservation);
            this.Controls.Add(this.Approve_Reservation);
            this.Controls.Add(this.AddReservation);
            this.Name = "Reservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).EndInit();
            this.ResumeLayout(false);

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
    }
}