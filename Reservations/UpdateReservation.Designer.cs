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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateUserId = new System.Windows.Forms.TextBox();
            this.UpdateIdClass = new System.Windows.Forms.TextBox();
            this.UpdateDate = new System.Windows.Forms.DateTimePicker();
            this.Answer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationShow)).BeginInit();
            this.ReservationUpdatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Update_Reservation
            // 
            this.Update_Reservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_Reservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_Reservation.Location = new System.Drawing.Point(11, 330);
            this.Update_Reservation.Margin = new System.Windows.Forms.Padding(2);
            this.Update_Reservation.Name = "Update_Reservation";
            this.Update_Reservation.Size = new System.Drawing.Size(200, 45);
            this.Update_Reservation.TabIndex = 4;
            this.Update_Reservation.Text = "Edytuj rezerwacje";
            this.Update_Reservation.UseVisualStyleBackColor = false;
            this.Update_Reservation.Click += new System.EventHandler(this.Update_Reservation_Click);
            // 
            // ReservationShow
            // 
            this.ReservationShow.AllowUserToAddRows = false;
            this.ReservationShow.AllowUserToDeleteRows = false;
            this.ReservationShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationShow.Location = new System.Drawing.Point(7, 47);
            this.ReservationShow.Margin = new System.Windows.Forms.Padding(2);
            this.ReservationShow.Name = "ReservationShow";
            this.ReservationShow.ReadOnly = true;
            this.ReservationShow.RowHeadersWidth = 51;
            this.ReservationShow.RowTemplate.Height = 24;
            this.ReservationShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationShow.Size = new System.Drawing.Size(586, 141);
            this.ReservationShow.TabIndex = 6;
            this.ReservationShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationShow_CellContentClick);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Return.Location = new System.Drawing.Point(221, 1);
            this.Return.Margin = new System.Windows.Forms.Padding(2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(190, 30);
            this.Return.TabIndex = 7;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.Color.Snow;
            this.Main.Location = new System.Drawing.Point(413, 1);
            this.Main.Margin = new System.Windows.Forms.Padding(2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(190, 30);
            this.Main.TabIndex = 8;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
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
            this.ReservationUpdatePanel.Location = new System.Drawing.Point(11, 194);
            this.ReservationUpdatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.ReservationUpdatePanel.Name = "ReservationUpdatePanel";
            this.ReservationUpdatePanel.Size = new System.Drawing.Size(314, 132);
            this.ReservationUpdatePanel.TabIndex = 9;
            // 
            // ReservationPostUpdate
            // 
            this.ReservationPostUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReservationPostUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReservationPostUpdate.Location = new System.Drawing.Point(210, 86);
            this.ReservationPostUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ReservationPostUpdate.Name = "ReservationPostUpdate";
            this.ReservationPostUpdate.Size = new System.Drawing.Size(89, 34);
            this.ReservationPostUpdate.TabIndex = 3;
            this.ReservationPostUpdate.Text = "Aktualizuj";
            this.ReservationPostUpdate.UseVisualStyleBackColor = false;
            this.ReservationPostUpdate.Click += new System.EventHandler(this.ReservationPostUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Identyfikator użytkownika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identyfikator zajęć:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data rezerwacji: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(88, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aktualizuj wybrane dane";
            // 
            // UpdateUserId
            // 
            this.UpdateUserId.Location = new System.Drawing.Point(160, 105);
            this.UpdateUserId.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateUserId.Name = "UpdateUserId";
            this.UpdateUserId.Size = new System.Drawing.Size(43, 20);
            this.UpdateUserId.TabIndex = 2;
            // 
            // UpdateIdClass
            // 
            this.UpdateIdClass.Location = new System.Drawing.Point(160, 80);
            this.UpdateIdClass.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateIdClass.Name = "UpdateIdClass";
            this.UpdateIdClass.Size = new System.Drawing.Size(43, 20);
            this.UpdateIdClass.TabIndex = 1;
            // 
            // UpdateDate
            // 
            this.UpdateDate.Location = new System.Drawing.Point(146, 50);
            this.UpdateDate.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.Size = new System.Drawing.Size(151, 20);
            this.UpdateDate.TabIndex = 0;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(373, 282);
            this.Answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 13);
            this.Answer.TabIndex = 10;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1034, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // UpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.ReservationUpdatePanel);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.ReservationShow);
            this.Controls.Add(this.Update_Reservation);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DataGridView ReservationShow;
        private System.Windows.Forms.Label label5;
    }
}