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
            lblPromptScore = new Label();
            txtTestScore = new TextBox();
            btnEnter = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // lblPromptScore
            // 
            lblPromptScore.AutoSize = true;
            lblPromptScore.Location = new Point(12, 18);
            lblPromptScore.Name = "lblPromptScore";
            lblPromptScore.Size = new Size(216, 20);
            lblPromptScore.TabIndex = 0;
            lblPromptScore.Text = "PLEASE ENTER A TEST SCORE : ";
            // 
            // txtTestScore
            // 
            txtTestScore.Location = new Point(234, 11);
            txtTestScore.Name = "txtTestScore";
            txtTestScore.Size = new Size(187, 27);
            txtTestScore.TabIndex = 1;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(256, 61);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(133, 48);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisplay.Location = new Point(12, 112);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(521, 329);
            lblDisplay.TabIndex = 3;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnEnter);
            Controls.Add(txtTestScore);
            Controls.Add(lblPromptScore);
            Name = "Form1";
            Text = "STATISTICS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPromptScore;
        private TextBox txtTestScore;
        private Button btnEnter;
        private Label lblDisplay;
    }
}
