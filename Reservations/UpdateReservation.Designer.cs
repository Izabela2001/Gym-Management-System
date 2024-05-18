namespace Gym_Management_System.Reservations
{
    partial class UpdateReservation
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
            this.Update_Reservation = new System.Windows.Forms.Button();
            this.ReservationShow = new System.Windows.Forms.DataGridView();
            this.OpptionsUpdate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_Reservation
            // 
            this.Update_Reservation.Location = new System.Drawing.Point(210, 219);
            this.Update_Reservation.Name = "Update_Reservation";
            this.Update_Reservation.Size = new System.Drawing.Size(365, 43);
            this.Update_Reservation.TabIndex = 4;
            this.Update_Reservation.Text = "Edytuj rezerwacje";
            this.Update_Reservation.UseVisualStyleBackColor = true;
            this.Update_Reservation.Click += new System.EventHandler(this.Update_Reservation_Click);
            // 
            // ReservationShow
            // 
            this.ReservationShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationShow.Location = new System.Drawing.Point(60, 26);
            this.ReservationShow.Name = "ReservationShow";
            this.ReservationShow.RowHeadersWidth = 51;
            this.ReservationShow.RowTemplate.Height = 24;
            this.ReservationShow.Size = new System.Drawing.Size(652, 173);
            this.ReservationShow.TabIndex = 6;
            // 
            // OpptionsUpdate
            // 
            this.OpptionsUpdate.Location = new System.Drawing.Point(66, 268);
            this.OpptionsUpdate.Name = "OpptionsUpdate";
            this.OpptionsUpdate.Size = new System.Drawing.Size(646, 143);
            this.OpptionsUpdate.TabIndex = 7;
            // 
            // UpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpptionsUpdate);
            this.Controls.Add(this.ReservationShow);
            this.Controls.Add(this.Update_Reservation);
            this.Name = "UpdateReservation";
            this.Text = "UpdateReservation";
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Update_Reservation;
        private System.Windows.Forms.DataGridView ReservationShow;
        private System.Windows.Forms.Panel OpptionsUpdate;
    }
}