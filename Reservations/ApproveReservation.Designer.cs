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
            this.Main = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_NoApproved)).BeginInit();
            this.SuspendLayout();
            // 
            // Reservation_NoApproved
            // 
            this.Reservation_NoApproved.AllowUserToAddRows = false;
            this.Reservation_NoApproved.AllowUserToDeleteRows = false;
            this.Reservation_NoApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reservation_NoApproved.Location = new System.Drawing.Point(11, 41);
            this.Reservation_NoApproved.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reservation_NoApproved.Name = "Reservation_NoApproved";
            this.Reservation_NoApproved.ReadOnly = true;
            this.Reservation_NoApproved.RowHeadersWidth = 51;
            this.Reservation_NoApproved.RowTemplate.Height = 24;
            this.Reservation_NoApproved.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Reservation_NoApproved.Size = new System.Drawing.Size(559, 218);
            this.Reservation_NoApproved.TabIndex = 0;
            // 
            // Approved
            // 
            this.Approved.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Approved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Approved.Location = new System.Drawing.Point(11, 263);
            this.Approved.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Approved.Name = "Approved";
            this.Approved.Size = new System.Drawing.Size(183, 38);
            this.Approved.TabIndex = 1;
            this.Approved.Text = "Akceptuj";
            this.Approved.UseVisualStyleBackColor = false;
            this.Approved.Click += new System.EventHandler(this.Approved_Click);
            // 
            // Result_Approved
            // 
            this.Result_Approved.AutoSize = true;
            this.Result_Approved.Location = new System.Drawing.Point(24, 314);
            this.Result_Approved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Result_Approved.Name = "Result_Approved";
            this.Result_Approved.Size = new System.Drawing.Size(0, 13);
            this.Result_Approved.TabIndex = 2;
            // 
            // Return_reservation
            // 
            this.Return_reservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return_reservation.ForeColor = System.Drawing.Color.Snow;
            this.Return_reservation.Location = new System.Drawing.Point(221, 1);
            this.Return_reservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Return_reservation.Name = "Return_reservation";
            this.Return_reservation.Size = new System.Drawing.Size(190, 30);
            this.Return_reservation.TabIndex = 3;
            this.Return_reservation.Text = "Wróć";
            this.Return_reservation.UseVisualStyleBackColor = false;
            this.Return_reservation.Click += new System.EventHandler(this.Return_reservation_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.Color.Snow;
            this.Main.Location = new System.Drawing.Point(414, 1);
            this.Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(170, 30);
            this.Main.TabIndex = 4;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // ApproveReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 307);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return_reservation);
            this.Controls.Add(this.Result_Approved);
            this.Controls.Add(this.Approved);
            this.Controls.Add(this.Reservation_NoApproved);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Label label1;
    }
}