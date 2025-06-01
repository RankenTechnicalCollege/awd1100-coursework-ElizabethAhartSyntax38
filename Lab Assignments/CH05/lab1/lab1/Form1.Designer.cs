namespace lab1
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
            BtnAdmit = new Button();
            txtGpa = new TextBox();
            txtAdmissionScore = new TextBox();
            lblGPA = new Label();
            lblAdmissionScore = new Label();
            lblDidplay = new Label();
            SuspendLayout();
            // 
            // btnAdmit
            // 
            BtnAdmit.Location = new Point(62, 246);
            BtnAdmit.Name = "btnAdmit";
            BtnAdmit.Size = new Size(155, 109);
            BtnAdmit.TabIndex = 0;
            BtnAdmit.Text = "Admit";
            BtnAdmit.UseVisualStyleBackColor = true;
            BtnAdmit.Click += BtnAdmit_Click;
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(39, 138);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(125, 27);
            txtGpa.TabIndex = 1;
            txtGpa.TextChanged += txtGpa_TextChanged;
            // 
            // txtAdmissionScore
            // 
            txtAdmissionScore.Location = new Point(414, 138);
            txtAdmissionScore.Name = "txtAdmissionScore";
            txtAdmissionScore.Size = new Size(125, 27);
            txtAdmissionScore.TabIndex = 2;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(41, 87);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(129, 20);
            lblGPA.TabIndex = 3;
            lblGPA.Text = "What is Your GPA?";
            // 
            // lblAdmissionScore
            // 
            lblAdmissionScore.AutoSize = true;
            lblAdmissionScore.Location = new Point(420, 90);
            lblAdmissionScore.Name = "lblAdmissionScore";
            lblAdmissionScore.Size = new Size(212, 20);
            lblAdmissionScore.TabIndex = 4;
            lblAdmissionScore.Text = "What is your Admission Score?";
            // 
            // lblDidplay
            // 
            lblDidplay.AutoSize = true;
            lblDidplay.Location = new Point(388, 290);
            lblDidplay.Name = "lblDidplay";
            lblDidplay.Size = new Size(0, 20);
            lblDidplay.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDidplay);
            Controls.Add(lblAdmissionScore);
            Controls.Add(lblGPA);
            Controls.Add(txtAdmissionScore);
            Controls.Add(txtGpa);
            Controls.Add(BtnAdmit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdmit;
        private TextBox txtGpa;
        private TextBox txtAdmissionScore;
        private Label lblGPA;
        private Label lblAdmissionScore;
        private Label lblDidplay;
    }
}
