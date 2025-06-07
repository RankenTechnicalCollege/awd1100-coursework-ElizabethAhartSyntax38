namespace Lab2
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
            lblName = new Label();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            txtBox3 = new TextBox();
            btnSubmit = new Button();
            lblDisplay1 = new Label();
            lblDisplay2 = new Label();
            lblDisplay3 = new Label();
            lblDisplay4 = new Label();
            lblDisplay6 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(151, 20);
            lblName.TabIndex = 0;
            lblName.Text = "BASKETBALL SCORES";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(12, 95);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(225, 27);
            txtBox1.TabIndex = 1;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(12, 207);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(230, 27);
            txtBox2.TabIndex = 2;
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(12, 320);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(230, 27);
            txtBox3.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(458, 233);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(330, 175);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "!! Click to DUNK !!";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblDisplay1
            // 
            lblDisplay1.AutoSize = true;
            lblDisplay1.Location = new Point(422, 9);
            lblDisplay1.Name = "lblDisplay1";
            lblDisplay1.Size = new Size(0, 20);
            lblDisplay1.TabIndex = 5;
            // 
            // lblDisplay2
            // 
            lblDisplay2.AutoSize = true;
            lblDisplay2.Location = new Point(529, 92);
            lblDisplay2.Name = "lblDisplay2";
            lblDisplay2.Size = new Size(0, 20);
            lblDisplay2.TabIndex = 6;
            // 
            // lblDisplay3
            // 
            lblDisplay3.AutoSize = true;
            lblDisplay3.Location = new Point(661, 193);
            lblDisplay3.Name = "lblDisplay3";
            lblDisplay3.Size = new Size(0, 20);
            lblDisplay3.TabIndex = 7;
            // 
            // lblDisplay4
            // 
            lblDisplay4.AutoSize = true;
            lblDisplay4.Location = new Point(62, 262);
            lblDisplay4.Name = "lblDisplay4";
            lblDisplay4.Size = new Size(0, 20);
            lblDisplay4.TabIndex = 8;
            // 
            // lblDisplay6
            // 
            lblDisplay6.AutoSize = true;
            lblDisplay6.Location = new Point(16, 36);
            lblDisplay6.Name = "lblDisplay6";
            lblDisplay6.Size = new Size(0, 20);
            lblDisplay6.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay6);
            Controls.Add(lblDisplay4);
            Controls.Add(lblDisplay3);
            Controls.Add(lblDisplay2);
            Controls.Add(lblDisplay1);
            Controls.Add(btnSubmit);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "LAB2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private TextBox txtBox3;
        private Button btnSubmit;
        private Label lblDisplay1;
        private Label lblDisplay2;
        private Label lblDisplay3;
        private Label lblDisplay4;
        private Label lblDisplay6;
    }
}
