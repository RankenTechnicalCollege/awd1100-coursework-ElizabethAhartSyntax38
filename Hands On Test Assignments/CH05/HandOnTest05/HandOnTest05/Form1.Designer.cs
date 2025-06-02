namespace HandOnTest05
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
            lblPromptInch = new Label();
            userInputInch = new TextBox();
            CmDisplay = new TextBox();
            lblCentDisplay = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // lblPromptInch
            // 
            lblPromptInch.AutoSize = true;
            lblPromptInch.Location = new Point(24, 79);
            lblPromptInch.Name = "lblPromptInch";
            lblPromptInch.Size = new Size(211, 20);
            lblPromptInch.TabIndex = 0;
            lblPromptInch.Text = "Please Enter Distance in Inches";
            // 
            // userInputInch
            // 
            userInputInch.Location = new Point(38, 120);
            userInputInch.Name = "userInputInch";
            userInputInch.Size = new Size(125, 27);
            userInputInch.TabIndex = 1;
            // 
            // CmDisplay
            // 
            CmDisplay.Location = new Point(481, 120);
            CmDisplay.Name = "CmDisplay";
            CmDisplay.Size = new Size(125, 27);
            CmDisplay.TabIndex = 2;
            // 
            // lblCentDisplay
            // 
            lblCentDisplay.AutoSize = true;
            lblCentDisplay.Location = new Point(481, 79);
            lblCentDisplay.Name = "lblCentDisplay";
            lblCentDisplay.Size = new Size(135, 20);
            lblCentDisplay.TabIndex = 3;
            lblCentDisplay.Text = "Centimeter Display";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(254, 184);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(217, 154);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(lblCentDisplay);
            Controls.Add(CmDisplay);
            Controls.Add(userInputInch);
            Controls.Add(lblPromptInch);
            Name = "Form1";
            Text = "EX1 Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPromptInch;
        private TextBox userInputInch;
        private TextBox CmDisplay;
        private Label lblCentDisplay;
        private Button btnConvert;
    }
}
