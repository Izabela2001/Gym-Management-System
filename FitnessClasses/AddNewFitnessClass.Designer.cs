namespace Gym_Management_System.FitnessClasses
{
    partial class AddNewFitnessClass
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
            this.Return = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            this.TypeFitnessClass = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(82, 352);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(148, 37);
            this.Return.TabIndex = 0;
            this.Return.Text = "Wróć";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(255, 352);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(176, 37);
            this.Main.TabIndex = 1;
            this.Main.Text = "Strona Główna";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // TypeFitnessClass
            // 
            this.TypeFitnessClass.FormattingEnabled = true;
            this.TypeFitnessClass.Location = new System.Drawing.Point(208, 61);
            this.TypeFitnessClass.Name = "TypeFitnessClass";
            this.TypeFitnessClass.Size = new System.Drawing.Size(235, 21);
            this.TypeFitnessClass.TabIndex = 2;
            // 
            // AddNewFitnessClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeFitnessClass);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Return);
            this.Name = "AddNewFitnessClass";
            this.Text = "AddNewFitnessClass";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.CheckedListBox TypeFitnessClass;
    }
}