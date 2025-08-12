namespace Lab6
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
            rchDisplay = new RichTextBox();
            lblStudentId = new Label();
            lblFIRSTNAME = new Label();
            lblLASTNAME = new Label();
            lblEMAILAddress = new Label();
            txtID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // rchDisplay
            // 
            rchDisplay.Location = new Point(495, 39);
            rchDisplay.Name = "rchDisplay";
            rchDisplay.Size = new Size(268, 322);
            rchDisplay.TabIndex = 0;
            rchDisplay.Text = "";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(12, 27);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(109, 20);
            lblStudentId.TabIndex = 1;
            lblStudentId.Text = "STUDENT _ID : ";
            // 
            // lblFIRSTNAME
            // 
            lblFIRSTNAME.AutoSize = true;
            lblFIRSTNAME.Location = new Point(12, 75);
            lblFIRSTNAME.Name = "lblFIRSTNAME";
            lblFIRSTNAME.Size = new Size(102, 20);
            lblFIRSTNAME.TabIndex = 2;
            lblFIRSTNAME.Text = "FIRST NAME : ";
            // 
            // lblLASTNAME
            // 
            lblLASTNAME.AutoSize = true;
            lblLASTNAME.Location = new Point(12, 125);
            lblLASTNAME.Name = "lblLASTNAME";
            lblLASTNAME.Size = new Size(99, 20);
            lblLASTNAME.TabIndex = 3;
            lblLASTNAME.Text = "LAST NAME : ";
            // 
            // lblEMAILAddress
            // 
            lblEMAILAddress.AutoSize = true;
            lblEMAILAddress.Location = new Point(1, 173);
            lblEMAILAddress.Name = "lblEMAILAddress";
            lblEMAILAddress.Size = new Size(131, 20);
            lblEMAILAddress.TabIndex = 4;
            lblEMAILAddress.Text = "EMAIL ADDRESS : ";
            // 
            // txtID
            // 
            txtID.Location = new Point(149, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(174, 27);
            txtID.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(149, 75);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(149, 122);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(174, 27);
            txtLastName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 27);
            txtEmail.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(lblEMAILAddress);
            Controls.Add(lblLASTNAME);
            Controls.Add(lblFIRSTNAME);
            Controls.Add(lblStudentId);
            Controls.Add(rchDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rchDisplay;
        private Label lblStudentId;
        private Label lblFIRSTNAME;
        private Label lblLASTNAME;
        private Label lblEMAILAddress;
        private TextBox txtID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
    }
}
