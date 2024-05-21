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
            this.Return = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            this.ReservationUpdatePanel = new System.Windows.Forms.Panel();
            this.ReservationPostUpdate = new System.Windows.Forms.Button();
            this.UpdateUserId = new System.Windows.Forms.TextBox();
            this.UpdateIdClass = new System.Windows.Forms.TextBox();
            this.UpdateDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).BeginInit();
            this.ReservationUpdatePanel.SuspendLayout();
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
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(94, 281);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(243, 45);
            this.Return.TabIndex = 7;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(424, 281);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(252, 45);
            this.Main.TabIndex = 8;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // ReservationUpdatePanel
            // 
            this.ReservationUpdatePanel.Controls.Add(this.ReservationPostUpdate);
            this.ReservationUpdatePanel.Controls.Add(this.label4);
            this.ReservationUpdatePanel.Controls.Add(this.label3);
            this.ReservationUpdatePanel.Controls.Add(this.label2);
            this.ReservationUpdatePanel.Controls.Add(this.label1);
            this.ReservationUpdatePanel.Controls.Add(this.UpdateUserId);
            this.ReservationUpdatePanel.Controls.Add(this.UpdateIdClass);
            this.ReservationUpdatePanel.Controls.Add(this.UpdateDate);
            this.ReservationUpdatePanel.Location = new System.Drawing.Point(60, 332);
            this.ReservationUpdatePanel.Name = "ReservationUpdatePanel";
            this.ReservationUpdatePanel.Size = new System.Drawing.Size(419, 163);
            this.ReservationUpdatePanel.TabIndex = 9;
            // 
            // ReservationPostUpdate
            // 
            this.ReservationPostUpdate.Location = new System.Drawing.Point(275, 98);
            this.ReservationPostUpdate.Name = "ReservationPostUpdate";
            this.ReservationPostUpdate.Size = new System.Drawing.Size(119, 42);
            this.ReservationPostUpdate.TabIndex = 3;
            this.ReservationPostUpdate.Text = "Aktualizuj";
            this.ReservationPostUpdate.UseVisualStyleBackColor = true;
            this.ReservationPostUpdate.Click += new System.EventHandler(this.ReservationPostUpdate_Click);
            // 
            // UpdateUserId
            // 
            this.UpdateUserId.Location = new System.Drawing.Point(213, 129);
            this.UpdateUserId.Name = "UpdateUserId";
            this.UpdateUserId.Size = new System.Drawing.Size(56, 22);
            this.UpdateUserId.TabIndex = 2;
            // 
            // UpdateIdClass
            // 
            this.UpdateIdClass.Location = new System.Drawing.Point(213, 98);
            this.UpdateIdClass.Name = "UpdateIdClass";
            this.UpdateIdClass.Size = new System.Drawing.Size(56, 22);
            this.UpdateIdClass.TabIndex = 1;
            // 
            // UpdateDate
            // 
            this.UpdateDate.Location = new System.Drawing.Point(194, 61);
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.Size = new System.Drawing.Size(200, 22);
            this.UpdateDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aktualizuj wybrane dane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data rezerwacji: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identyfikator zajęć:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Identyfikator użytkownika:";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(497, 347);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(14, 16);
            this.Answer.TabIndex = 10;
            this.Answer.Text = "s";
            // 
            // UpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.ReservationUpdatePanel);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.ReservationShow);
            this.Controls.Add(this.Update_Reservation);
            this.Name = "UpdateReservation";
            this.Text = "UpdateReservation";
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).EndInit();
            this.ReservationUpdatePanel.ResumeLayout(false);
            this.ReservationUpdatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Update_Reservation;
        private System.Windows.Forms.DataGridView ReservationShow;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Panel ReservationUpdatePanel;
        private System.Windows.Forms.DateTimePicker UpdateDate;
        private System.Windows.Forms.TextBox UpdateIdClass;
        private System.Windows.Forms.Button ReservationPostUpdate;
        private System.Windows.Forms.TextBox UpdateUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Answer;
    }
}