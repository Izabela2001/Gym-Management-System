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
            ((System.ComponentModel.ISupportInitialize)(this.ViewFitnessClasss)).BeginInit();
            this.SuspendLayout();
            // 
            // AllFitnessClass
            // 
            this.AllFitnessClass.Location = new System.Drawing.Point(52, 46);
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
            this.ViewFitnessClasss.Size = new System.Drawing.Size(405, 345);
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
            // FitnessClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}