namespace Ex1
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
            grpCreate = new GroupBox();
            btnCreate = new Button();
            chkLONG = new CheckBox();
            chkShort = new CheckBox();
            txtAmount = new TextBox();
            txtName = new TextBox();
            lblType = new Label();
            lblAmount = new Label();
            lblName = new Label();
            grpManage = new GroupBox();
            btnPay = new Button();
            lblDisplay = new Label();
            lblDisplayAmount = new Label();
            lblDisplayName = new Label();
            lblDisplayLoan = new Label();
            grpCreate.SuspendLayout();
            grpManage.SuspendLayout();
            SuspendLayout();
            // 
            // grpCreate
            // 
            grpCreate.Controls.Add(btnCreate);
            grpCreate.Controls.Add(chkLONG);
            grpCreate.Controls.Add(chkShort);
            grpCreate.Controls.Add(txtAmount);
            grpCreate.Controls.Add(txtName);
            grpCreate.Controls.Add(lblType);
            grpCreate.Controls.Add(lblAmount);
            grpCreate.Controls.Add(lblName);
            grpCreate.Location = new Point(32, 31);
            grpCreate.Name = "grpCreate";
            grpCreate.Size = new Size(334, 182);
            grpCreate.TabIndex = 0;
            grpCreate.TabStop = false;
            grpCreate.Text = "CREATE LOAN";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 8.5F);
            btnCreate.Location = new Point(199, 111);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(113, 49);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "CREATE LOAN";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // chkLONG
            // 
            chkLONG.AutoSize = true;
            chkLONG.Location = new Point(6, 136);
            chkLONG.Name = "chkLONG";
            chkLONG.Size = new Size(111, 24);
            chkLONG.TabIndex = 6;
            chkLONG.Text = "LONG TERM";
            chkLONG.UseVisualStyleBackColor = true;
            // 
            // chkShort
            // 
            chkShort.AutoSize = true;
            chkShort.Location = new Point(8, 107);
            chkShort.Name = "chkShort";
            chkShort.Size = new Size(119, 24);
            chkShort.TabIndex = 5;
            chkShort.Text = "SHORT TERM";
            chkShort.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(101, 54);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(6, 84);
            lblType.Name = "lblType";
            lblType.Size = new Size(103, 20);
            lblType.TabIndex = 2;
            lblType.Text = "TYPE Of LOAN";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(6, 55);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(83, 20);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "AMOUNT : ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 20);
            lblName.TabIndex = 0;
            lblName.Text = "NAME : ";
            // 
            // grpManage
            // 
            grpManage.Controls.Add(btnPay);
            grpManage.Controls.Add(lblDisplay);
            grpManage.Controls.Add(lblDisplayAmount);
            grpManage.Controls.Add(lblDisplayName);
            grpManage.Location = new Point(465, 217);
            grpManage.Name = "grpManage";
            grpManage.Size = new Size(311, 212);
            grpManage.TabIndex = 1;
            grpManage.TabStop = false;
            grpManage.Text = "MANAGE LOAN";
            grpManage.Visible = false;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 8.5F);
            btnPay.Location = new Point(179, 127);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(113, 49);
            btnPay.TabIndex = 15;
            btnPay.Text = "MAKE PAYMENT";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(6, 127);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(15, 20);
            lblDisplay.TabIndex = 10;
            lblDisplay.Text = "_";
            // 
            // lblDisplayAmount
            // 
            lblDisplayAmount.AutoSize = true;
            lblDisplayAmount.Location = new Point(2, 71);
            lblDisplayAmount.Name = "lblDisplayAmount";
            lblDisplayAmount.Size = new Size(83, 20);
            lblDisplayAmount.TabIndex = 9;
            lblDisplayAmount.Text = "AMOUNT : ";
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Location = new Point(2, 39);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(62, 20);
            lblDisplayName.TabIndex = 8;
            lblDisplayName.Text = "NAME : ";
            // 
            // lblDisplayLoan
            // 
            lblDisplayLoan.Font = new Font("Segoe UI", 12F);
            lblDisplayLoan.Location = new Point(40, 246);
            lblDisplayLoan.Name = "lblDisplayLoan";
            lblDisplayLoan.Size = new Size(340, 183);
            lblDisplayLoan.TabIndex = 2;
            lblDisplayLoan.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplayLoan);
            Controls.Add(grpManage);
            Controls.Add(grpCreate);
            Name = "Form1";
            Text = "Bank Loan";
            grpCreate.ResumeLayout(false);
            grpCreate.PerformLayout();
            grpManage.ResumeLayout(false);
            grpManage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCreate;
        private CheckBox chkLONG;
        private CheckBox chkShort;
        private TextBox txtAmount;
        private TextBox txtName;
        private Label lblType;
        private Label lblAmount;
        private Label lblName;
        private Button btnCreate;
        private GroupBox grpManage;
        private Button btnPay;
        private Label lblDisplay;
        private Label lblDisplayAmount;
        private Label lblDisplayName;
        private Label lblDisplayLoan;
    }
}
