namespace Lab1_2_3
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
            lblGpa = new Label();
            textBox1 = new TextBox();
            lblScore = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            btnSubmit = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Location = new Point(22, 69);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(115, 20);
            lblGpa.TabIndex = 0;
            lblGpa.Text = "Highschool Gpa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(422, 69);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(119, 20);
            lblScore.TabIndex = 2;
            lblScore.Text = "Admission Score";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(434, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(406, 20);
            label1.TabIndex = 4;
            label1.Text = "Please Enter H.S Gpa and Admission Score and Press Submit";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(247, 186);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(121, 109);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(39, 353);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 20);
            lblDisplay.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(lblScore);
            Controls.Add(textBox1);
            Controls.Add(lblGpa);
            Name = "Form1";
            Text = "Eligibilty for College";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGpa;
        private TextBox textBox1;
        private Label lblScore;
        private TextBox textBox2;
        private Label label1;
        private Button btnSubmit;
        private Label lblDisplay;
    }
}
