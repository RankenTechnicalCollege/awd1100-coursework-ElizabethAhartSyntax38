namespace Lab5
{
    partial class lblDisplay
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
            textBox1 = new TextBox();
            lblDisplayNum = new Label();
            btnMask = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 0;
            // 
            // lblDisplayNum
            // 
            lblDisplayNum.AutoSize = true;
            lblDisplayNum.Location = new Point(90, 165);
            lblDisplayNum.Name = "lblDisplayNum";
            lblDisplayNum.Size = new Size(15, 20);
            lblDisplayNum.TabIndex = 1;
            lblDisplayNum.Text = "-";
            // 
            // btnMask
            // 
            btnMask.Location = new Point(460, 119);
            btnMask.Name = "btnMask";
            btnMask.Size = new Size(96, 66);
            btnMask.TabIndex = 2;
            btnMask.Text = "MASK CARD";
            btnMask.UseVisualStyleBackColor = true;
            btnMask.Click += btnMask_Click;
            // 
            // lblDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMask);
            Controls.Add(lblDisplayNum);
            Controls.Add(textBox1);
            Name = "lblDisplay";
            Text = "CREDIT CARD MASKER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblDisplayNum;
        private Button btnMask;
    }
}
