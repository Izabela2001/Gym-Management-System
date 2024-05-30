namespace Gym_Management_System
{
    partial class FitnessClass
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
            this.AllFitnessClass = new System.Windows.Forms.Button();
            this.ViewFitnessClasss = new System.Windows.Forms.DataGridView();
            this.ActiveFitnessClass = new System.Windows.Forms.Button();
            this.AfterTime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteFitnessClass = new System.Windows.Forms.Button();
            this.AddFitnessClass = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFitnessClasss)).BeginInit();
            this.SuspendLayout();
            // 
            // AllFitnessClass
            // 
            this.AllFitnessClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllFitnessClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllFitnessClass.Location = new System.Drawing.Point(893, 49);
            this.AllFitnessClass.Margin = new System.Windows.Forms.Padding(2);
            this.AllFitnessClass.Name = "AllFitnessClass";
            this.AllFitnessClass.Size = new System.Drawing.Size(202, 38);
            this.AllFitnessClass.TabIndex = 0;
            this.AllFitnessClass.Text = "Wyświetl wszystkie zajęcia";
            this.AllFitnessClass.UseVisualStyleBackColor = false;
            this.AllFitnessClass.Click += new System.EventHandler(this.AllFitnessClass_Click);
            // 
            // ViewFitnessClasss
            // 
            this.ViewFitnessClasss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFitnessClasss.Location = new System.Drawing.Point(6, 45);
            this.ViewFitnessClasss.Margin = new System.Windows.Forms.Padding(2);
            this.ViewFitnessClasss.Name = "ViewFitnessClasss";
            this.ViewFitnessClasss.ReadOnly = true;
            this.ViewFitnessClasss.RowHeadersWidth = 51;
            this.ViewFitnessClasss.RowTemplate.Height = 24;
            this.ViewFitnessClasss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewFitnessClasss.Size = new System.Drawing.Size(872, 416);
            this.ViewFitnessClasss.TabIndex = 1;
            // 
            // ActiveFitnessClass
            // 
            this.ActiveFitnessClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ActiveFitnessClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActiveFitnessClass.Location = new System.Drawing.Point(893, 91);
            this.ActiveFitnessClass.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveFitnessClass.Name = "ActiveFitnessClass";
            this.ActiveFitnessClass.Size = new System.Drawing.Size(202, 38);
            this.ActiveFitnessClass.TabIndex = 2;
            this.ActiveFitnessClass.Text = "Wyświetl aktualne zajęcia";
            this.ActiveFitnessClass.UseVisualStyleBackColor = false;
            this.ActiveFitnessClass.Click += new System.EventHandler(this.ActiveFitnessClass_Click);
            // 
            // AfterTime
            // 
            this.AfterTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AfterTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AfterTime.Location = new System.Drawing.Point(893, 133);
            this.AfterTime.Margin = new System.Windows.Forms.Padding(2);
            this.AfterTime.Name = "AfterTime";
            this.AfterTime.Size = new System.Drawing.Size(202, 38);
            this.AfterTime.TabIndex = 3;
            this.AfterTime.Text = "Wyświetl zajęcia po terminie";
            this.AfterTime.UseVisualStyleBackColor = false;
            this.AfterTime.Click += new System.EventHandler(this.AfterTime_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(893, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edytuj zajęcia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteFitnessClass
            // 
            this.DeleteFitnessClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteFitnessClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteFitnessClass.Location = new System.Drawing.Point(893, 276);
            this.DeleteFitnessClass.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteFitnessClass.Name = "DeleteFitnessClass";
            this.DeleteFitnessClass.Size = new System.Drawing.Size(202, 38);
            this.DeleteFitnessClass.TabIndex = 5;
            this.DeleteFitnessClass.TabStop = false;
            this.DeleteFitnessClass.Text = "Usuń zajęcia";
            this.DeleteFitnessClass.UseVisualStyleBackColor = false;
            this.DeleteFitnessClass.Click += new System.EventHandler(this.DeleteFitnessClass_Click);
            // 
            // AddFitnessClass
            // 
            this.AddFitnessClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddFitnessClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFitnessClass.Location = new System.Drawing.Point(893, 192);
            this.AddFitnessClass.Margin = new System.Windows.Forms.Padding(2);
            this.AddFitnessClass.Name = "AddFitnessClass";
            this.AddFitnessClass.Size = new System.Drawing.Size(202, 38);
            this.AddFitnessClass.TabIndex = 6;
            this.AddFitnessClass.Text = "Dodaj zajęcia";
            this.AddFitnessClass.UseVisualStyleBackColor = false;
            this.AddFitnessClass.Click += new System.EventHandler(this.AddFitnessClass_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Main.Location = new System.Drawing.Point(906, 1);
            this.Main.Margin = new System.Windows.Forms.Padding(2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(200, 30);
            this.Main.TabIndex = 7;
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
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1277, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = " Fitnesso                                                                        " +
    "                                                      ";
            // 
            // FitnessClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 472);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.AddFitnessClass);
            this.Controls.Add(this.DeleteFitnessClass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AfterTime);
            this.Controls.Add(this.ActiveFitnessClass);
            this.Controls.Add(this.ViewFitnessClasss);
            this.Controls.Add(this.AllFitnessClass);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FitnessClass";
            this.Text = "FitnessClass";
            ((System.ComponentModel.ISupportInitialize)(this.ViewFitnessClasss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllFitnessClass;
        private System.Windows.Forms.DataGridView ViewFitnessClasss;
        private System.Windows.Forms.Button ActiveFitnessClass;
        private System.Windows.Forms.Button AfterTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteFitnessClass;
        private System.Windows.Forms.Button AddFitnessClass;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Label label1;
    }
}