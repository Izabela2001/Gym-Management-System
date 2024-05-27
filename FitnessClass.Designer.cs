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
            ((System.ComponentModel.ISupportInitialize)(this.ViewFitnessClasss)).BeginInit();
            this.SuspendLayout();
            // 
            // AllFitnessClass
            // 
            this.AllFitnessClass.Location = new System.Drawing.Point(52, 63);
            this.AllFitnessClass.Name = "AllFitnessClass";
            this.AllFitnessClass.Size = new System.Drawing.Size(287, 41);
            this.AllFitnessClass.TabIndex = 0;
            this.AllFitnessClass.Text = "Wyświetl zajęcia";
            this.AllFitnessClass.UseVisualStyleBackColor = true;
            this.AllFitnessClass.Click += new System.EventHandler(this.AllFitnessClass_Click);
            // 
            // ViewFitnessClasss
            // 
            this.ViewFitnessClasss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFitnessClasss.Location = new System.Drawing.Point(383, 46);
            this.ViewFitnessClasss.Name = "ViewFitnessClasss";
            this.ViewFitnessClasss.RowHeadersWidth = 51;
            this.ViewFitnessClasss.RowTemplate.Height = 24;
            this.ViewFitnessClasss.Size = new System.Drawing.Size(983, 345);
            this.ViewFitnessClasss.TabIndex = 1;
            // 
            // ActiveFitnessClass
            // 
            this.ActiveFitnessClass.Location = new System.Drawing.Point(52, 110);
            this.ActiveFitnessClass.Name = "ActiveFitnessClass";
            this.ActiveFitnessClass.Size = new System.Drawing.Size(287, 54);
            this.ActiveFitnessClass.TabIndex = 2;
            this.ActiveFitnessClass.Text = "Aktualne zajęcia";
            this.ActiveFitnessClass.UseVisualStyleBackColor = true;
            this.ActiveFitnessClass.Click += new System.EventHandler(this.ActiveFitnessClass_Click);
            // 
            // AfterTime
            // 
            this.AfterTime.Location = new System.Drawing.Point(52, 187);
            this.AfterTime.Name = "AfterTime";
            this.AfterTime.Size = new System.Drawing.Size(287, 39);
            this.AfterTime.TabIndex = 3;
            this.AfterTime.Text = "Wyświetl zajęcia po terminie";
            this.AfterTime.UseVisualStyleBackColor = true;
            this.AfterTime.Click += new System.EventHandler(this.AfterTime_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edytuj zajęcia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteFitnessClass
            // 
            this.DeleteFitnessClass.Location = new System.Drawing.Point(52, 278);
            this.DeleteFitnessClass.Name = "DeleteFitnessClass";
            this.DeleteFitnessClass.Size = new System.Drawing.Size(287, 50);
            this.DeleteFitnessClass.TabIndex = 5;
            this.DeleteFitnessClass.TabStop = false;
            this.DeleteFitnessClass.Text = "Usuń zajęcia";
            this.DeleteFitnessClass.UseVisualStyleBackColor = true;
            this.DeleteFitnessClass.Click += new System.EventHandler(this.DeleteFitnessClass_Click);
            // 
            // AddFitnessClass
            // 
            this.AddFitnessClass.Location = new System.Drawing.Point(52, 335);
            this.AddFitnessClass.Name = "AddFitnessClass";
            this.AddFitnessClass.Size = new System.Drawing.Size(287, 39);
            this.AddFitnessClass.TabIndex = 6;
            this.AddFitnessClass.Text = "Dodaj zajęcia";
            this.AddFitnessClass.UseVisualStyleBackColor = true;
            this.AddFitnessClass.Click += new System.EventHandler(this.AddFitnessClass_Click);
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(52, 380);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(287, 36);
            this.Main.TabIndex = 7;
            this.Main.Text = "Strona główna";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // FitnessClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 533);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.AddFitnessClass);
            this.Controls.Add(this.DeleteFitnessClass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AfterTime);
            this.Controls.Add(this.ActiveFitnessClass);
            this.Controls.Add(this.ViewFitnessClasss);
            this.Controls.Add(this.AllFitnessClass);
            this.Name = "FitnessClass";
            this.Text = "FitnessClass";
            ((System.ComponentModel.ISupportInitialize)(this.ViewFitnessClasss)).EndInit();
            this.ResumeLayout(false);

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
    }
}