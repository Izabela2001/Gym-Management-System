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
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).BeginInit();
            this.SuspendLayout();
            // 
            // AddReservation
            // 
            this.AddReservation.Location = new System.Drawing.Point(24, 149);
            this.AddReservation.Name = "AddReservation";
            this.AddReservation.Size = new System.Drawing.Size(269, 40);
            this.AddReservation.TabIndex = 0;
            this.AddReservation.Text = "Dodaj rezerwacje";
            this.AddReservation.UseVisualStyleBackColor = true;
            this.AddReservation.Click += new System.EventHandler(this.AddReservation_Click);
            // 
            // Approve_Reservation
            // 
            this.Approve_Reservation.Location = new System.Drawing.Point(24, 195);
            this.Approve_Reservation.Name = "Approve_Reservation";
            this.Approve_Reservation.Size = new System.Drawing.Size(269, 46);
            this.Approve_Reservation.TabIndex = 1;
            this.Approve_Reservation.Text = "Akceptuj rezerwacje";
            this.Approve_Reservation.UseVisualStyleBackColor = true;
            this.Approve_Reservation.Click += new System.EventHandler(this.Approve_Reservation_Click);
            // 
            // UpdateReservation
            // 
            this.UpdateReservation.Location = new System.Drawing.Point(24, 247);
            this.UpdateReservation.Name = "UpdateReservation";
            this.UpdateReservation.Size = new System.Drawing.Size(269, 39);
            this.UpdateReservation.TabIndex = 2;
            this.UpdateReservation.Text = "Aktualizuj rezerwacje";
            this.UpdateReservation.UseVisualStyleBackColor = true;
            this.UpdateReservation.Click += new System.EventHandler(this.UpdateReservation_Click);
            // 
            // ReturnApp
            // 
            this.ReturnApp.Location = new System.Drawing.Point(24, 392);
            this.ReturnApp.Name = "ReturnApp";
            this.ReturnApp.Size = new System.Drawing.Size(269, 39);
            this.ReturnApp.TabIndex = 3;
            this.ReturnApp.Text = "Strona główna";
            this.ReturnApp.UseVisualStyleBackColor = true;
            this.ReturnApp.Click += new System.EventHandler(this.ReturnApp_Click);
            // 
            // ShowReservationAfter
            // 
            this.ShowReservationAfter.Location = new System.Drawing.Point(24, 80);
            this.ShowReservationAfter.Name = "ShowReservationAfter";
            this.ShowReservationAfter.Size = new System.Drawing.Size(269, 63);
            this.ShowReservationAfter.TabIndex = 4;
            this.ShowReservationAfter.Text = "Rezerwacje po terminie";
            this.ShowReservationAfter.UseVisualStyleBackColor = true;
            this.ShowReservationAfter.Click += new System.EventHandler(this.ShowReservationAfter_Click);
            // 
            // ReservationShow
            // 
            this.ReservationShow.AllowUserToAddRows = false;
            this.ReservationShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationShow.Location = new System.Drawing.Point(310, 26);
            this.ReservationShow.Name = "ReservationShow";
            this.ReservationShow.ReadOnly = true;
            this.ReservationShow.RowHeadersWidth = 51;
            this.ReservationShow.RowTemplate.Height = 24;
            this.ReservationShow.Size = new System.Drawing.Size(866, 369);
            this.ReservationShow.TabIndex = 5;
            // 
            // ToDayReservation
            // 
            this.ToDayReservation.Location = new System.Drawing.Point(24, 26);
            this.ToDayReservation.Name = "ToDayReservation";
            this.ToDayReservation.Size = new System.Drawing.Size(269, 48);
            this.ToDayReservation.TabIndex = 6;
            this.ToDayReservation.Text = "Dzisiejsze reserwacje";
            this.ToDayReservation.UseVisualStyleBackColor = true;
            this.ToDayReservation.Click += new System.EventHandler(this.ToDayReservation_Click);
            // 
            // AllReservation
            // 
            this.AllReservation.Location = new System.Drawing.Point(24, 292);
            this.AllReservation.Name = "AllReservation";
            this.AllReservation.Size = new System.Drawing.Size(269, 55);
            this.AllReservation.TabIndex = 7;
            this.AllReservation.Text = "Wyświetl wszystkie rezerwacje";
            this.AllReservation.UseVisualStyleBackColor = true;
            this.AllReservation.Click += new System.EventHandler(this.AllReservation_Click);
            // 
            // DeleteReservation
            // 
            this.DeleteReservation.Location = new System.Drawing.Point(24, 353);
            this.DeleteReservation.Name = "DeleteReservation";
            this.DeleteReservation.Size = new System.Drawing.Size(269, 33);
            this.DeleteReservation.TabIndex = 8;
            this.DeleteReservation.Text = "Usuń rezerwacje";
            this.DeleteReservation.UseVisualStyleBackColor = true;
            this.DeleteReservation.Click += new System.EventHandler(this.DeleteReservation_Click);
            // 
            // Return_Reservation
            // 
            this.Return_Reservation.AutoSize = true;
            this.Return_Reservation.Location = new System.Drawing.Point(316, 419);
            this.Return_Reservation.Name = "Return_Reservation";
            this.Return_Reservation.Size = new System.Drawing.Size(44, 16);
            this.Return_Reservation.TabIndex = 9;
            this.Return_Reservation.Text = "label1";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 665);
            this.Controls.Add(this.Return_Reservation);
            this.Controls.Add(this.DeleteReservation);
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
    }
}