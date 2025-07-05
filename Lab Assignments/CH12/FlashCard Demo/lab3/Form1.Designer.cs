namespace lab3
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
            lblAcc = new Label();
            txtAccNum = new TextBox();
            lblPin = new Label();
            txtPin = new TextBox();
            lblWithdraw = new Label();
            txtWithdraw = new TextBox();
            lblDeposit = new Label();
            txtDeposit = new TextBox();
            txtDisplay = new RichTextBox();
            btnAccess = new Button();
            btnLogOut = new Button();
            btnEnter = new Button();
            lblName = new Label();
            txtName = new TextBox();
            btnDeposit = new Button();
            SuspendLayout();
            // 
            // lblAcc
            // 
            lblAcc.AutoSize = true;
            lblAcc.Location = new Point(12, 24);
            lblAcc.Name = "lblAcc";
            lblAcc.Size = new Size(96, 20);
            lblAcc.TabIndex = 0;
            lblAcc.Text = "Acct Number";
            // 
            // txtAccNum
            // 
            txtAccNum.Location = new Point(130, 21);
            txtAccNum.Name = "txtAccNum";
            txtAccNum.Size = new Size(125, 27);
            txtAccNum.TabIndex = 1;
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(12, 64);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(96, 20);
            lblPin.TabIndex = 2;
            lblPin.Text = "PIN NUMBER";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(130, 57);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(125, 27);
            txtPin.TabIndex = 3;
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Location = new Point(8, 252);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(147, 20);
            lblWithdraw.TabIndex = 4;
            lblWithdraw.Text = "MAKE WITHDRAW? :";
            // 
            // txtWithdraw
            // 
            txtWithdraw.Location = new Point(177, 249);
            txtWithdraw.Name = "txtWithdraw";
            txtWithdraw.Size = new Size(125, 27);
            txtWithdraw.TabIndex = 5;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(12, 286);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(125, 20);
            lblDeposit.TabIndex = 6;
            lblDeposit.Text = "MAKE DEPOSIT? :";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(177, 286);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(125, 27);
            txtDeposit.TabIndex = 7;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(502, 16);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(230, 217);
            txtDisplay.TabIndex = 8;
            txtDisplay.Text = "";
            // 
            // btnAccess
            // 
            btnAccess.Location = new Point(292, 37);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new Size(94, 29);
            btnAccess.TabIndex = 9;
            btnAccess.Text = "LOGIN( )";
            btnAccess.UseVisualStyleBackColor = true;
            btnAccess.Click += btnAccess_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(35, 353);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = "LOGOUT ( )";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(320, 243);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 29);
            btnEnter.TabIndex = 11;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 12;
            lblName.Text = "NAME";
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 13;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(320, 282);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(94, 29);
            btnDeposit.TabIndex = 14;
            btnDeposit.Text = "DEPOSIT";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeposit);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnEnter);
            Controls.Add(btnLogOut);
            Controls.Add(btnAccess);
            Controls.Add(txtDisplay);
            Controls.Add(txtDeposit);
            Controls.Add(lblDeposit);
            Controls.Add(txtWithdraw);
            Controls.Add(lblWithdraw);
            Controls.Add(txtPin);
            Controls.Add(lblPin);
            Controls.Add(txtAccNum);
            Controls.Add(lblAcc);
            Name = "Form1";
            Text = "BankACCOUNTS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcc;
        private TextBox txtAccNum;
        private Label lblPin;
        private TextBox txtPin;
        private Label lblWithdraw;
        private TextBox txtWithdraw;
        private Label lblDeposit;
        private TextBox txtDeposit;
        private RichTextBox txtDisplay;
        private Button btnAccess;
        private Button btnLogOut;
        private Button btnEnter;
        private Label lblName;
        private TextBox txtName;
        private Button btnDeposit;
    }
}
