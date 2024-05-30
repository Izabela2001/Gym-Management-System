namespace Gym_Management_System.Fitness_Class
{
    partial class UpdateFitnessClasses
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
            this.Answer = new System.Windows.Forms.Label();
            this.FitnessClassesUpdatePanel = new System.Windows.Forms.Panel();
            this.FitnessClassesPostUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.UpdateTypeFitnessClass = new System.Windows.Forms.ComboBox();
            this.UpdateLevelOfAdvancement = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateEndDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateMaxPlaces = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.UpdateActivePlaces = new System.Windows.Forms.NumericUpDown();
            this.UpdateIdEmployee = new System.Windows.Forms.TextBox();
            this.Main = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.FitnessClassesShow = new System.Windows.Forms.DataGridView();
            this.Update_FitnessClasses = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FitnessClassesUpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateMaxPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateActivePlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FitnessClassesShow)).BeginInit();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(539, 285);
            this.Answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 13);
            this.Answer.TabIndex = 17;
            // 
            // FitnessClassesUpdatePanel
            // 
            this.FitnessClassesUpdatePanel.Controls.Add(this.FitnessClassesPostUpdate);
            this.FitnessClassesUpdatePanel.Controls.Add(this.label2);
            this.FitnessClassesUpdatePanel.Controls.Add(this.label1);
            this.FitnessClassesUpdatePanel.Controls.Add(this.label7);
            this.FitnessClassesUpdatePanel.Controls.Add(this.d);
            this.FitnessClassesUpdatePanel.Controls.Add(this.UpdateTypeFitnessClass);
            this.FitnessClassesUpdatePanel.Controls.Add(this.UpdateLevelOfAdvancement);
            this.FitnessClassesUpdatePanel.Controls.Add(this.label6);
            this.FitnessClassesUpdatePanel.Controls.Add(this.UpdateStartDate);
            this.FitnessClassesUpdatePanel.Controls.Add(this.label8);
            this.FitnessClassesUpdatePanel.Controls.Add(this.UpdateEndDate);
            this.FitnessClassesUpdatePanel.Controls.Add(this.label9);
            this.FitnessClassesUpdatePanel.Controls.Add(this.UpdateMaxPlaces);
            this.FitnessClassesUpdatePanel.Controls.Add(this.label10);
            this.FitnessClassesUpdatePanel.Controls.Add(this.UpdateActivePlaces);
            this.FitnessClassesUpdatePanel.Controls.Add(this.UpdateIdEmployee);
            this.FitnessClassesUpdatePanel.Location = new System.Drawing.Point(468, 253);
            this.FitnessClassesUpdatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.FitnessClassesUpdatePanel.Name = "FitnessClassesUpdatePanel";
            this.FitnessClassesUpdatePanel.Size = new System.Drawing.Size(390, 284);
            this.FitnessClassesUpdatePanel.TabIndex = 16;
            // 
            // FitnessClassesPostUpdate
            // 
            this.FitnessClassesPostUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FitnessClassesPostUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FitnessClassesPostUpdate.Location = new System.Drawing.Point(244, 245);
            this.FitnessClassesPostUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.FitnessClassesPostUpdate.Name = "FitnessClassesPostUpdate";
            this.FitnessClassesPostUpdate.Size = new System.Drawing.Size(131, 34);
            this.FitnessClassesPostUpdate.TabIndex = 3;
            this.FitnessClassesPostUpdate.Text = "Aktualizuj";
            this.FitnessClassesPostUpdate.UseVisualStyleBackColor = false;
            this.FitnessClassesPostUpdate.Click += new System.EventHandler(this.FitnessClassesPostUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Typ zajęć";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aktualizuj wybrane dane";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Poziom zaawansowania ";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(16, 188);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(74, 13);
            this.d.TabIndex = 51;
            this.d.Text = "Id pracownika";
            // 
            // UpdateTypeFitnessClass
            // 
            this.UpdateTypeFitnessClass.FormattingEnabled = true;
            this.UpdateTypeFitnessClass.Location = new System.Drawing.Point(175, 47);
            this.UpdateTypeFitnessClass.Name = "UpdateTypeFitnessClass";
            this.UpdateTypeFitnessClass.Size = new System.Drawing.Size(200, 21);
            this.UpdateTypeFitnessClass.TabIndex = 38;
            // 
            // UpdateLevelOfAdvancement
            // 
            this.UpdateLevelOfAdvancement.FormattingEnabled = true;
            this.UpdateLevelOfAdvancement.Location = new System.Drawing.Point(175, 219);
            this.UpdateLevelOfAdvancement.Name = "UpdateLevelOfAdvancement";
            this.UpdateLevelOfAdvancement.Size = new System.Drawing.Size(200, 21);
            this.UpdateLevelOfAdvancement.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Aktywne miejsca";
            // 
            // UpdateStartDate
            // 
            this.UpdateStartDate.Location = new System.Drawing.Point(175, 77);
            this.UpdateStartDate.Name = "UpdateStartDate";
            this.UpdateStartDate.Size = new System.Drawing.Size(200, 20);
            this.UpdateStartDate.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Maksymalna liczba miejsc";
            // 
            // UpdateEndDate
            // 
            this.UpdateEndDate.Location = new System.Drawing.Point(175, 106);
            this.UpdateEndDate.Name = "UpdateEndDate";
            this.UpdateEndDate.Size = new System.Drawing.Size(200, 20);
            this.UpdateEndDate.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Data zakończenia";
            // 
            // UpdateMaxPlaces
            // 
            this.UpdateMaxPlaces.Location = new System.Drawing.Point(176, 132);
            this.UpdateMaxPlaces.Name = "UpdateMaxPlaces";
            this.UpdateMaxPlaces.Size = new System.Drawing.Size(199, 20);
            this.UpdateMaxPlaces.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Data rozpoczęcia";
            // 
            // UpdateActivePlaces
            // 
            this.UpdateActivePlaces.Location = new System.Drawing.Point(176, 162);
            this.UpdateActivePlaces.Name = "UpdateActivePlaces";
            this.UpdateActivePlaces.Size = new System.Drawing.Size(199, 20);
            this.UpdateActivePlaces.TabIndex = 43;
            // 
            // UpdateIdEmployee
            // 
            this.UpdateIdEmployee.Location = new System.Drawing.Point(175, 188);
            this.UpdateIdEmployee.MaxLength = 5;
            this.UpdateIdEmployee.Name = "UpdateIdEmployee";
            this.UpdateIdEmployee.Size = new System.Drawing.Size(200, 20);
            this.UpdateIdEmployee.TabIndex = 44;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.Color.Snow;
            this.Main.Location = new System.Drawing.Point(679, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(190, 30);
            this.Main.TabIndex = 15;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Return.Location = new System.Drawing.Point(488, 1);
            this.Return.Margin = new System.Windows.Forms.Padding(2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(190, 30);
            this.Return.TabIndex = 14;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // FitnessClassesShow
            // 
            this.FitnessClassesShow.AllowUserToAddRows = false;
            this.FitnessClassesShow.AllowUserToDeleteRows = false;
            this.FitnessClassesShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FitnessClassesShow.Location = new System.Drawing.Point(6, 47);
            this.FitnessClassesShow.Margin = new System.Windows.Forms.Padding(2);
            this.FitnessClassesShow.Name = "FitnessClassesShow";
            this.FitnessClassesShow.ReadOnly = true;
            this.FitnessClassesShow.RowHeadersWidth = 51;
            this.FitnessClassesShow.RowTemplate.Height = 24;
            this.FitnessClassesShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FitnessClassesShow.Size = new System.Drawing.Size(852, 202);
            this.FitnessClassesShow.TabIndex = 13;
            // 
            // Update_FitnessClasses
            // 
            this.Update_FitnessClasses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_FitnessClasses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_FitnessClasses.Location = new System.Drawing.Point(6, 253);
            this.Update_FitnessClasses.Margin = new System.Windows.Forms.Padding(2);
            this.Update_FitnessClasses.Name = "Update_FitnessClasses";
            this.Update_FitnessClasses.Size = new System.Drawing.Size(169, 45);
            this.Update_FitnessClasses.TabIndex = 12;
            this.Update_FitnessClasses.Text = "Edytuj zajęcia";
            this.Update_FitnessClasses.UseVisualStyleBackColor = false;
            this.Update_FitnessClasses.Click += new System.EventHandler(this.Update_FitnesssClass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(0, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1034, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // UpdateFitnessClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 549);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.FitnessClassesUpdatePanel);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.FitnessClassesShow);
            this.Controls.Add(this.Update_FitnessClasses);
            this.Controls.Add(this.label5);
            this.Name = "UpdateFitnessClasses";
            this.Text = "UpdateFitnessClasses";
            this.FitnessClassesUpdatePanel.ResumeLayout(false);
            this.FitnessClassesUpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateMaxPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateActivePlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FitnessClassesShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Panel FitnessClassesUpdatePanel;
        private System.Windows.Forms.Button FitnessClassesPostUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.DataGridView FitnessClassesShow;
        private System.Windows.Forms.Button Update_FitnessClasses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.ComboBox UpdateTypeFitnessClass;
        private System.Windows.Forms.ComboBox UpdateLevelOfAdvancement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker UpdateStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker UpdateEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown UpdateMaxPlaces;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown UpdateActivePlaces;
        private System.Windows.Forms.TextBox UpdateIdEmployee;
    }
}