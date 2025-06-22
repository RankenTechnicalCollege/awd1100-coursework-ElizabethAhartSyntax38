namespace Lab7
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
            lblAccPrompt = new Label();
            txtAccount = new TextBox();
            lblPin = new Label();
            txtPin = new TextBox();
            btnLog = new Button();
            lblDisplayWelcome = new Label();
            lblDisplayAccountBal = new Label();
            txtboxDeposit = new TextBox();
            txtBoxwithdraw = new TextBox();
            lblDisplayPrompt = new Label();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAccPrompt
            // 
            lblAccPrompt.AutoSize = true;
            lblAccPrompt.Location = new Point(7, 11);
            lblAccPrompt.Name = "lblAccPrompt";
            lblAccPrompt.Size = new Size(148, 20);
            lblAccPrompt.TabIndex = 0;
            lblAccPrompt.Text = "ACCOUNT NUMBER :";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(161, 4);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(151, 27);
            txtAccount.TabIndex = 1;
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(7, 42);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(45, 20);
            lblPin.TabIndex = 2;
            lblPin.Text = "PIN #";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(161, 35);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(151, 27);
            txtPin.TabIndex = 3;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(13, 96);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(149, 48);
            btnLog.TabIndex = 4;
            btnLog.Text = "LOGIN ";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // lblDisplayWelcome
            // 
            lblDisplayWelcome.AutoSize = true;
            lblDisplayWelcome.Font = new Font("Segoe UI", 16F);
            lblDisplayWelcome.Location = new Point(374, 4);
            lblDisplayWelcome.Name = "lblDisplayWelcome";
            lblDisplayWelcome.Size = new Size(28, 37);
            lblDisplayWelcome.TabIndex = 5;
            lblDisplayWelcome.Text = "_";
            // 
            // lblDisplayAccountBal
            // 
            lblDisplayAccountBal.AutoSize = true;
            lblDisplayAccountBal.Font = new Font("Segoe UI", 14F);
            lblDisplayAccountBal.Location = new Point(380, 85);
            lblDisplayAccountBal.Name = "lblDisplayAccountBal";
            lblDisplayAccountBal.Size = new Size(24, 32);
            lblDisplayAccountBal.TabIndex = 6;
            lblDisplayAccountBal.Text = "_";
            // 
            // txtboxDeposit
            // 
            txtboxDeposit.Location = new Point(573, 318);
            txtboxDeposit.Name = "txtboxDeposit";
            txtboxDeposit.Size = new Size(125, 27);
            txtboxDeposit.TabIndex = 7;
            // 
            // txtBoxwithdraw
            // 
            txtBoxwithdraw.Location = new Point(573, 384);
            txtBoxwithdraw.Name = "txtBoxwithdraw";
            txtBoxwithdraw.Size = new Size(125, 27);
            txtBoxwithdraw.TabIndex = 8;
            // 
            // lblDisplayPrompt
            // 
            lblDisplayPrompt.AutoSize = true;
            lblDisplayPrompt.Font = new Font("Segoe UI", 12F);
            lblDisplayPrompt.Location = new Point(32, 247);
            lblDisplayPrompt.Name = "lblDisplayPrompt";
            lblDisplayPrompt.Size = new Size(20, 28);
            lblDisplayPrompt.TabIndex = 9;
            lblDisplayPrompt.Text = "_";
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI", 9F);
            btnDeposit.Location = new Point(428, 316);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(85, 29);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "DEPOSIT";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += button1_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(428, 382);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(85, 29);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(13, 382);
            button1.Name = "button1";
            button1.Size = new Size(222, 56);
            button1.TabIndex = 12;
            button1.Text = "LOGOUT ( *)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(lblDisplayPrompt);
            Controls.Add(txtBoxwithdraw);
            Controls.Add(txtboxDeposit);
            Controls.Add(lblDisplayAccountBal);
            Controls.Add(lblDisplayWelcome);
            Controls.Add(btnLog);
            Controls.Add(txtPin);
            Controls.Add(lblPin);
            Controls.Add(txtAccount);
            Controls.Add(lblAccPrompt);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "WeyLand BANK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccPrompt;
        private TextBox txtAccount;
        private Label lblPin;
        private TextBox txtPin;
        private Button btnLog;
        private Label lblDisplayWelcome;
        private Label lblDisplayAccountBal;
        private TextBox txtboxDeposit;
        private TextBox txtBoxwithdraw;
        private Label lblDisplayPrompt;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button button1;
    }
}
