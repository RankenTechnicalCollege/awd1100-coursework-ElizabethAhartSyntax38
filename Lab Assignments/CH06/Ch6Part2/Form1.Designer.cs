namespace Ch6Part2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtboxNum1 = new TextBox();
            txtBoxNum2 = new TextBox();
            txtBoxNum3 = new TextBox();
            txtBoxNum4 = new TextBox();
            btnReverse = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // txtboxNum1
            // 
            txtboxNum1.Location = new Point(10, 145);
            txtboxNum1.Name = "txtboxNum1";
            txtboxNum1.Size = new Size(125, 27);
            txtboxNum1.TabIndex = 0;
            txtboxNum1.TextChanged += textBox1_TextChanged;
            // 
            // txtBoxNum2
            // 
            txtBoxNum2.Location = new Point(200, 145);
            txtBoxNum2.Name = "txtBoxNum2";
            txtBoxNum2.Size = new Size(125, 27);
            txtBoxNum2.TabIndex = 1;
            // 
            // txtBoxNum3
            // 
            txtBoxNum3.Location = new Point(406, 155);
            txtBoxNum3.Name = "txtBoxNum3";
            txtBoxNum3.Size = new Size(125, 27);
            txtBoxNum3.TabIndex = 2;
            // 
            // txtBoxNum4
            // 
            txtBoxNum4.Location = new Point(633, 155);
            txtBoxNum4.Name = "txtBoxNum4";
            txtBoxNum4.Size = new Size(125, 27);
            txtBoxNum4.TabIndex = 3;
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(310, 246);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(158, 49);
            btnReverse.TabIndex = 4;
            btnReverse.Text = "REVERSE";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 12F);
            lblDisplay.Location = new Point(66, 338);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(20, 28);
            lblDisplay.TabIndex = 5;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnReverse);
            Controls.Add(txtBoxNum4);
            Controls.Add(txtBoxNum3);
            Controls.Add(txtBoxNum2);
            Controls.Add(txtboxNum1);
            Name = "Form1";
            Text = "REVERSE4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxNum1;
        private TextBox txtBoxNum2;
        private TextBox txtBoxNum3;
        private TextBox txtBoxNum4;
        private Button btnReverse;
        private Label lblDisplay;
    }
}
