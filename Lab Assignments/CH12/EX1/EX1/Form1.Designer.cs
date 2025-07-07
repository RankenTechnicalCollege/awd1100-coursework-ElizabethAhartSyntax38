namespace EX1
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
            C = new Label();
            txtMd5 = new TextBox();
            lblDisplayPass = new Label();
            btnCrack = new Button();
            SuspendLayout();
            // 
            // C
            // 
            C.AutoSize = true;
            C.Location = new Point(32, 41);
            C.Name = "C";
            C.Size = new Size(85, 20);
            C.TabIndex = 0;
            C.Text = "MD5 HASH";
            // 
            // txtMd5
            // 
            txtMd5.Location = new Point(26, 86);
            txtMd5.Name = "txtMd5";
            txtMd5.Size = new Size(342, 27);
            txtMd5.TabIndex = 1;
            // 
            // lblDisplayPass
            // 
            lblDisplayPass.AutoSize = true;
            lblDisplayPass.Font = new Font("Segoe UI", 20F);
            lblDisplayPass.Location = new Point(50, 163);
            lblDisplayPass.Name = "lblDisplayPass";
            lblDisplayPass.Size = new Size(213, 46);
            lblDisplayPass.TabIndex = 2;
            lblDisplayPass.Text = "PASSWORD :";
            // 
            // btnCrack
            // 
            btnCrack.Location = new Point(506, 86);
            btnCrack.Name = "btnCrack";
            btnCrack.Size = new Size(104, 67);
            btnCrack.TabIndex = 3;
            btnCrack.Text = "CRACK";
            btnCrack.UseVisualStyleBackColor = true;
            btnCrack.Click += btnCrack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrack);
            Controls.Add(lblDisplayPass);
            Controls.Add(txtMd5);
            Controls.Add(C);
            Name = "Form1";
            Text = "PASSWORD CRACKER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label C;
        private TextBox txtMd5;
        private Label lblDisplayPass;
        private Button btnCrack;
    }
}
