namespace lab2
{
    partial class FrmLab
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
            this.btnkilo = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnkilo
            // 
            this.btnkilo.Location = new System.Drawing.Point(0, 193);
            this.btnkilo.Name = "btnkilo";
            this.btnkilo.Size = new System.Drawing.Size(277, 145);
            this.btnkilo.TabIndex = 0;
            this.btnkilo.Text = "submit";
            this.btnkilo.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(12, 40);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(39, 16);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "miles";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // FrmLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnkilo);
            this.Name = "FrmLab";
            this.Text = "lab1kilofrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkilo;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox textBox1;
    }
}

