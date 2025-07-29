namespace Lab3
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassWord = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(12, 19);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(93, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "USERNAME :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(134, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(249, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(12, 66);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(94, 20);
            lblPassWord.TabIndex = 2;
            lblPassWord.Text = "PASSWORD :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(134, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(134, 128);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(249, 56);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN ( )";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 12F);
            lblDisplay.Location = new Point(468, 41);
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
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassWord);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Name = "Form1";
            Text = "ACCOUNT MANAGEMENT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassWord;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblDisplay;
    }
}
