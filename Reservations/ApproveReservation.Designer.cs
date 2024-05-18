namespace Gym_Management_System
{
    partial class ApproveReservation
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
            this.Reservation_NoApproved = new System.Windows.Forms.DataGridView();
            this.Approved = new System.Windows.Forms.Button();
            this.Result_Approved = new System.Windows.Forms.Label();
            this.Return_reservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_NoApproved)).BeginInit();
            this.SuspendLayout();
            // 
            // Reservation_NoApproved
            // 
            this.Reservation_NoApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reservation_NoApproved.Location = new System.Drawing.Point(12, 12);
            this.Reservation_NoApproved.Name = "Reservation_NoApproved";
            this.Reservation_NoApproved.RowHeadersWidth = 51;
            this.Reservation_NoApproved.RowTemplate.Height = 24;
            this.Reservation_NoApproved.Size = new System.Drawing.Size(758, 268);
            this.Reservation_NoApproved.TabIndex = 0;
            // 
            // Approved
            // 
            this.Approved.Location = new System.Drawing.Point(25, 311);
            this.Approved.Name = "Approved";
            this.Approved.Size = new System.Drawing.Size(244, 47);
            this.Approved.TabIndex = 1;
            this.Approved.Text = "Akceptuj";
            this.Approved.UseVisualStyleBackColor = true;
            this.Approved.Click += new System.EventHandler(this.Approved_Click);
            // 
            // Result_Approved
            // 
            this.Result_Approved.AutoSize = true;
            this.Result_Approved.Location = new System.Drawing.Point(22, 376);
            this.Result_Approved.Name = "Result_Approved";
            this.Result_Approved.Size = new System.Drawing.Size(44, 16);
            this.Result_Approved.TabIndex = 2;
            this.Result_Approved.Text = "label1";
            // 
            // Return_reservation
            // 
            this.Return_reservation.Location = new System.Drawing.Point(298, 312);
            this.Return_reservation.Name = "Return_reservation";
            this.Return_reservation.Size = new System.Drawing.Size(259, 45);
            this.Return_reservation.TabIndex = 3;
            this.Return_reservation.Text = "Wróć";
            this.Return_reservation.UseVisualStyleBackColor = true;
            this.Return_reservation.Click += new System.EventHandler(this.Return_reservation_Click);
            // 
            // ApproveReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return_reservation);
            this.Controls.Add(this.Result_Approved);
            this.Controls.Add(this.Approved);
            this.Controls.Add(this.Reservation_NoApproved);
            this.Name = "ApproveReservation";
            this.Text = "ApproveReservation";
            this.Load += new System.EventHandler(this.ApproveReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_NoApproved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Reservation_NoApproved;
        private System.Windows.Forms.Button Approved;
        private System.Windows.Forms.Label Result_Approved;
        private System.Windows.Forms.Button Return_reservation;
    }
}