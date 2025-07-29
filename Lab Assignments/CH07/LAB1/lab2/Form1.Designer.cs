namespace lab2
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
            lblItemPrompt = new Label();
            txtItemNumber = new TextBox();
            lblQuanity = new Label();
            txtQuantity = new TextBox();
            lblDAYS = new Label();
            txtDeliveryDays = new TextBox();
            btnValidate = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // lblItemPrompt
            // 
            lblItemPrompt.AutoSize = true;
            lblItemPrompt.Location = new Point(12, 26);
            lblItemPrompt.Name = "lblItemPrompt";
            lblItemPrompt.Size = new Size(171, 20);
            lblItemPrompt.TabIndex = 0;
            lblItemPrompt.Text = "ITEM NUMBER [100,999]";
            // 
            // txtItemNumber
            // 
            txtItemNumber.Location = new Point(243, 22);
            txtItemNumber.Name = "txtItemNumber";
            txtItemNumber.Size = new Size(224, 27);
            txtItemNumber.TabIndex = 1;
            // 
            // lblQuanity
            // 
            lblQuanity.AutoSize = true;
            lblQuanity.Location = new Point(12, 82);
            lblQuanity.Name = "lblQuanity";
            lblQuanity.Size = new Size(112, 20);
            lblQuanity.TabIndex = 2;
            lblQuanity.Text = "QUANITY [1,12]";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(243, 79);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(224, 27);
            txtQuantity.TabIndex = 3;
            // 
            // lblDAYS
            // 
            lblDAYS.AutoSize = true;
            lblDAYS.Location = new Point(12, 146);
            lblDAYS.Name = "lblDAYS";
            lblDAYS.Size = new Size(204, 20);
            lblDAYS.TabIndex = 4;
            lblDAYS.Text = "Estimated delivery Days[1,30]";
            // 
            // txtDeliveryDays
            // 
            txtDeliveryDays.Location = new Point(243, 143);
            txtDeliveryDays.Name = "txtDeliveryDays";
            txtDeliveryDays.Size = new Size(224, 27);
            txtDeliveryDays.TabIndex = 5;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(547, 26);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(186, 106);
            btnValidate.TabIndex = 6;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(473, 271);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(15, 20);
            lblDisplay.TabIndex = 7;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnValidate);
            Controls.Add(txtDeliveryDays);
            Controls.Add(lblDAYS);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuanity);
            Controls.Add(txtItemNumber);
            Controls.Add(lblItemPrompt);
            Name = "Form1";
            Text = "ORDER VALIDATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemPrompt;
        private TextBox txtItemNumber;
        private Label lblQuanity;
        private TextBox txtQuantity;
        private Label lblDAYS;
        private TextBox txtDeliveryDays;
        private Button btnValidate;
        private Label lblDisplay;
    }
}
