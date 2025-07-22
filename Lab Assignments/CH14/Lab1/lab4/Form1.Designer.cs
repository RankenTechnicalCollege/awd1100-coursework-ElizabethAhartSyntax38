namespace lab4
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
            lblAccount = new Label();
            lblPIn = new Label();
            txtAccount = new TextBox();
            txtPin = new TextBox();
            btnLogin = new Button();
            grpBoxDeposit = new GroupBox();
            btnPrint = new Button();
            lblPromptDeposit = new Label();
            txtWithDraw = new TextBox();
            txtDeposit = new TextBox();
            lblWithdraw = new Label();
            lblDeposit = new Label();
            lblWelcome = new Label();
            rchPrinter = new RichTextBox();
            btnLogOut = new Button();
            grpBoxDeposit.SuspendLayout();
            SuspendLayout();
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(17, 18);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(141, 20);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "ACCOUNT NUMBER";
            // 
            // lblPIn
            // 
            lblPIn.AutoSize = true;
            lblPIn.Location = new Point(21, 53);
            lblPIn.Name = "lblPIn";
            lblPIn.Size = new Size(94, 20);
            lblPIn.TabIndex = 1;
            lblPIn.Text = "PIN NUNBER";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(179, 11);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(125, 27);
            txtAccount.TabIndex = 2;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(131, 50);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(125, 27);
            txtPin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(15, 102);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN ( )";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // grpBoxDeposit
            // 
            grpBoxDeposit.Controls.Add(btnPrint);
            grpBoxDeposit.Controls.Add(lblPromptDeposit);
            grpBoxDeposit.Controls.Add(txtWithDraw);
            grpBoxDeposit.Controls.Add(txtDeposit);
            grpBoxDeposit.Controls.Add(lblWithdraw);
            grpBoxDeposit.Controls.Add(lblDeposit);
            grpBoxDeposit.Controls.Add(lblWelcome);
            grpBoxDeposit.Location = new Point(15, 149);
            grpBoxDeposit.Name = "grpBoxDeposit";
            grpBoxDeposit.Size = new Size(546, 289);
            grpBoxDeposit.TabIndex = 5;
            grpBoxDeposit.TabStop = false;
            grpBoxDeposit.Text = "grpBoxDeposit";
            grpBoxDeposit.Visible = false;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(267, 229);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(174, 39);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "PRINT STATEMENT";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblPromptDeposit
            // 
            lblPromptDeposit.AutoSize = true;
            lblPromptDeposit.Location = new Point(286, 119);
            lblPromptDeposit.Name = "lblPromptDeposit";
            lblPromptDeposit.Size = new Size(95, 20);
            lblPromptDeposit.TabIndex = 5;
            lblPromptDeposit.Text = "How Much ? ";
            // 
            // txtWithDraw
            // 
            txtWithDraw.Location = new Point(268, 189);
            txtWithDraw.Name = "txtWithDraw";
            txtWithDraw.Size = new Size(125, 27);
            txtWithDraw.TabIndex = 4;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(267, 142);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(125, 27);
            txtDeposit.TabIndex = 3;
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Location = new Point(6, 192);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(215, 20);
            lblWithdraw.TabIndex = 2;
            lblWithdraw.Text = "Would you Like to Withdraw ?  ";
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(6, 149);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(225, 20);
            lblDeposit.TabIndex = 1;
            lblDeposit.Text = "WOULD YOU LIKE TO DEPOSIT ? ";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Ravie", 9F, FontStyle.Bold | FontStyle.Italic);
            lblWelcome.Location = new Point(2, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(544, 101);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "lblDisplayWelcome";
            // 
            // rchPrinter
            // 
            rchPrinter.Location = new Point(567, 11);
            rchPrinter.Name = "rchPrinter";
            rchPrinter.Size = new Size(210, 427);
            rchPrinter.TabIndex = 6;
            rchPrinter.Text = "";
            rchPrinter.Visible = false;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(336, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 108);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "LOGOUT( )";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Visible = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogOut);
            Controls.Add(rchPrinter);
            Controls.Add(grpBoxDeposit);
            Controls.Add(btnLogin);
            Controls.Add(txtPin);
            Controls.Add(txtAccount);
            Controls.Add(lblPIn);
            Controls.Add(lblAccount);
            Name = "Form1";
            Text = "BANK";
            grpBoxDeposit.ResumeLayout(false);
            grpBoxDeposit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccount;
        private Label lblPIn;
        private TextBox txtAccount;
        private TextBox txtPin;
        private Button btnLogin;
        private GroupBox grpBoxDeposit;
        private Label lblWelcome;
        private Label lblDeposit;
        private Label lblPromptDeposit;
        private TextBox txtWithDraw;
        private TextBox txtDeposit;
        private Label lblWithdraw;
        private Button btnPrint;
        private RichTextBox rchPrinter;
        private Button btnLogOut;
    }
}
