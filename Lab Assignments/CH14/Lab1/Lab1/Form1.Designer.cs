namespace Lab1
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
            lblRecipient = new Label();
            lblSentDate = new Label();
            lblTrackingNumber = new Label();
            lblErrorMessage = new Label();
            btnSend = new Button();
            rTxtDisplay = new RichTextBox();
            txtRecipient = new TextBox();
            txtSent = new TextBox();
            txtTrackingNumber = new TextBox();
            SuspendLayout();
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Font = new Font("Segoe UI", 11F);
            lblRecipient.Location = new Point(12, 9);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(100, 25);
            lblRecipient.TabIndex = 0;
            lblRecipient.Text = "RECIPIENT";
            // 
            // lblSentDate
            // 
            lblSentDate.AutoSize = true;
            lblSentDate.Font = new Font("Segoe UI", 11F);
            lblSentDate.Location = new Point(12, 63);
            lblSentDate.Name = "lblSentDate";
            lblSentDate.Size = new Size(119, 25);
            lblSentDate.TabIndex = 1;
            lblSentDate.Text = "SENT DATE : ";
            // 
            // lblTrackingNumber
            // 
            lblTrackingNumber.AutoSize = true;
            lblTrackingNumber.Font = new Font("Segoe UI", 11F);
            lblTrackingNumber.Location = new Point(12, 118);
            lblTrackingNumber.Name = "lblTrackingNumber";
            lblTrackingNumber.Size = new Size(195, 25);
            lblTrackingNumber.TabIndex = 2;
            lblTrackingNumber.Text = "TRACKING NUMBER : ";
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Segoe UI", 11F);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(53, 159);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(329, 25);
            lblErrorMessage.TabIndex = 3;
            lblErrorMessage.Text = "ADDITIONAL FEE FOR CERTIFIED MAIL";
            lblErrorMessage.Visible = false;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(45, 224);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 4;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // rTxtDisplay
            // 
            rTxtDisplay.Font = new Font("Segoe UI", 12F);
            rTxtDisplay.Location = new Point(512, 57);
            rTxtDisplay.Name = "rTxtDisplay";
            rTxtDisplay.Size = new Size(255, 356);
            rTxtDisplay.TabIndex = 5;
            rTxtDisplay.Text = "";
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(213, 7);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(125, 27);
            txtRecipient.TabIndex = 6;
            // 
            // txtSent
            // 
            txtSent.Location = new Point(213, 64);
            txtSent.Name = "txtSent";
            txtSent.Size = new Size(125, 27);
            txtSent.TabIndex = 7;
            // 
            // txtTrackingNumber
            // 
            txtTrackingNumber.Location = new Point(213, 118);
            txtTrackingNumber.Name = "txtTrackingNumber";
            txtTrackingNumber.Size = new Size(125, 27);
            txtTrackingNumber.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTrackingNumber);
            Controls.Add(txtSent);
            Controls.Add(txtRecipient);
            Controls.Add(rTxtDisplay);
            Controls.Add(btnSend);
            Controls.Add(lblErrorMessage);
            Controls.Add(lblTrackingNumber);
            Controls.Add(lblSentDate);
            Controls.Add(lblRecipient);
            Name = "Form1";
            Text = "Letter Delivery Service";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecipient;
        private Label lblSentDate;
        private Label lblTrackingNumber;
        private Label lblErrorMessage;
        private Button btnSend;
        private RichTextBox rTxtDisplay;
        private TextBox txtRecipient;
        private TextBox txtSent;
        private TextBox txtTrackingNumber;
    }
}
