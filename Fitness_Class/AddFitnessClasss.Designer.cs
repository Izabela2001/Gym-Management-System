namespace Gym_Management_System.Fitness_Class
{
    partial class AddFitnessClasss
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
            this.label4 = new System.Windows.Forms.Label();
            this.cb_IdTypeFitness = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.num_MaxPlaces = new System.Windows.Forms.NumericUpDown();
            this.num_ActivePlaces = new System.Windows.Forms.NumericUpDown();
            this.tB_IdEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Return_Class = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            this.bt_AddFitnessClass = new System.Windows.Forms.Button();
            this.cB_LevelOfAdvancement = new System.Windows.Forms.ComboBox();
            this.d = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ActivePlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-1, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1034, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = " Fitnesso                                                                        " +
    "                           ";
            // 
            // cb_IdTypeFitness
            // 
            this.cb_IdTypeFitness.FormattingEnabled = true;
            this.cb_IdTypeFitness.Location = new System.Drawing.Point(160, 50);
            this.cb_IdTypeFitness.Name = "cb_IdTypeFitness";
            this.cb_IdTypeFitness.Size = new System.Drawing.Size(200, 21);
            this.cb_IdTypeFitness.TabIndex = 21;
            this.cb_IdTypeFitness.SelectedIndexChanged += new System.EventHandler(this.cb_IdTypeFitness_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Typ zajęć";
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Location = new System.Drawing.Point(160, 80);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dt_StartDate.TabIndex = 23;
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Location = new System.Drawing.Point(160, 109);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dt_EndDate.TabIndex = 24;
            // 
            // num_MaxPlaces
            // 
            this.num_MaxPlaces.Location = new System.Drawing.Point(161, 135);
            this.num_MaxPlaces.Name = "num_MaxPlaces";
            this.num_MaxPlaces.Size = new System.Drawing.Size(199, 20);
            this.num_MaxPlaces.TabIndex = 25;
            // 
            // num_ActivePlaces
            // 
            this.num_ActivePlaces.Location = new System.Drawing.Point(161, 165);
            this.num_ActivePlaces.Name = "num_ActivePlaces";
            this.num_ActivePlaces.Size = new System.Drawing.Size(199, 20);
            this.num_ActivePlaces.TabIndex = 26;
            // 
            // tB_IdEmployee
            // 
            this.tB_IdEmployee.Location = new System.Drawing.Point(160, 191);
            this.tB_IdEmployee.MaxLength = 5;
            this.tB_IdEmployee.Name = "tB_IdEmployee";
            this.tB_IdEmployee.Size = new System.Drawing.Size(200, 20);
            this.tB_IdEmployee.TabIndex = 27;
            this.tB_IdEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_IdEmployee_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data rozpoczęcia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data zakończenia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Maksymalna liczba miejsc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Aktywne miejsca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Poziom zaawansowania ";
            // 
            // Return_Class
            // 
            this.Return_Class.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return_Class.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Return_Class.Location = new System.Drawing.Point(193, -3);
            this.Return_Class.Margin = new System.Windows.Forms.Padding(2);
            this.Return_Class.Name = "Return_Class";
            this.Return_Class.Size = new System.Drawing.Size(102, 35);
            this.Return_Class.TabIndex = 33;
            this.Return_Class.Text = "Wróć";
            this.Return_Class.UseVisualStyleBackColor = false;
            this.Return_Class.Click += new System.EventHandler(this.Return_Class_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Main.Location = new System.Drawing.Point(294, -3);
            this.Main.Margin = new System.Windows.Forms.Padding(2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(110, 35);
            this.Main.TabIndex = 34;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // bt_AddFitnessClass
            // 
            this.bt_AddFitnessClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_AddFitnessClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_AddFitnessClass.Location = new System.Drawing.Point(12, 249);
            this.bt_AddFitnessClass.Name = "bt_AddFitnessClass";
            this.bt_AddFitnessClass.Size = new System.Drawing.Size(182, 35);
            this.bt_AddFitnessClass.TabIndex = 35;
            this.bt_AddFitnessClass.Text = "Dodaj";
            this.bt_AddFitnessClass.UseVisualStyleBackColor = false;
            this.bt_AddFitnessClass.Click += new System.EventHandler(this.AddFtinessClass);
            // 
            // cB_LevelOfAdvancement
            // 
            this.cB_LevelOfAdvancement.FormattingEnabled = true;
            this.cB_LevelOfAdvancement.Location = new System.Drawing.Point(160, 222);
            this.cB_LevelOfAdvancement.Name = "cB_LevelOfAdvancement";
            this.cB_LevelOfAdvancement.Size = new System.Drawing.Size(200, 21);
            this.cB_LevelOfAdvancement.TabIndex = 36;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(17, 198);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(74, 13);
            this.d.TabIndex = 37;
            this.d.Text = "Id pracownika";
            // 
            // AddFitnessClasss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 325);
            this.Controls.Add(this.d);
            this.Controls.Add(this.cB_LevelOfAdvancement);
            this.Controls.Add(this.bt_AddFitnessClass);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return_Class);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_IdEmployee);
            this.Controls.Add(this.num_ActivePlaces);
            this.Controls.Add(this.num_MaxPlaces);
            this.Controls.Add(this.dt_EndDate);
            this.Controls.Add(this.dt_StartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_IdTypeFitness);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddFitnessClasss";
            this.Text = "AddFitnessClasss";
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ActivePlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_IdTypeFitness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
        private System.Windows.Forms.NumericUpDown num_MaxPlaces;
        private System.Windows.Forms.NumericUpDown num_ActivePlaces;
        private System.Windows.Forms.TextBox tB_IdEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Return_Class;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button bt_AddFitnessClass;
        private System.Windows.Forms.ComboBox cB_LevelOfAdvancement;
        private System.Windows.Forms.Label d;
    }
}