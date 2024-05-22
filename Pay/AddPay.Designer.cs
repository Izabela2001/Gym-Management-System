namespace Gym_Management_System.Pay
{
    partial class AddPay
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
            this.PayNoA = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PayNoA)).BeginInit();
            this.SuspendLayout();
            // 
            // PayNoA
            // 
            this.PayNoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayNoA.Location = new System.Drawing.Point(55, 37);
            this.PayNoA.Name = "PayNoA";
            this.PayNoA.RowHeadersWidth = 51;
            this.PayNoA.RowTemplate.Height = 24;
            this.PayNoA.Size = new System.Drawing.Size(467, 388);
            this.PayNoA.TabIndex = 0;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(557, 37);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(196, 32);
            this.button.TabIndex = 1;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = true;
            // 
            // AddPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.PayNoA);
            this.Name = "AddPay";
            this.Text = "AddPay";
            ((System.ComponentModel.ISupportInitialize)(this.PayNoA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PayNoA;
        private System.Windows.Forms.Button button;
    }
}