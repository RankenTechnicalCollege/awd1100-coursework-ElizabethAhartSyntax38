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
            lblName = new Label();
            button1 = new Button();
            lblPrompt = new Label();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            txtBox3 = new TextBox();
            lblDisplay1 = new Label();
            lblDisplay2 = new Label();
            lblClose = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(13, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(537, 135);
            button1.Name = "button1";
            button1.Size = new Size(182, 162);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(537, 29);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(175, 20);
            lblPrompt.TabIndex = 2;
            lblPrompt.Text = "PLEASE ENTER 3 SCORES";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(60, 78);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(125, 27);
            txtBox1.TabIndex = 3;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(60, 135);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(125, 27);
            txtBox2.TabIndex = 4;
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(60, 203);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(125, 27);
            txtBox3.TabIndex = 5;
            // 
            // lblDisplay1
            // 
            lblDisplay1.AutoSize = true;
            lblDisplay1.Location = new Point(249, 78);
            lblDisplay1.Name = "lblDisplay1";
            lblDisplay1.Size = new Size(0, 20);
            lblDisplay1.TabIndex = 6;
            // 
            // lblDisplay2
            // 
            lblDisplay2.AutoSize = true;
            lblDisplay2.Location = new Point(243, 143);
            lblDisplay2.Name = "lblDisplay2";
            lblDisplay2.Size = new Size(0, 20);
            lblDisplay2.TabIndex = 7;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Location = new Point(34, 339);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(355, 20);
            lblClose.TabIndex = 8;
            lblClose.Text = "\"TRACK YOUR STEPS WITH GRADE POINT AVERAGE!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblClose);
            Controls.Add(lblDisplay2);
            Controls.Add(lblDisplay1);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(lblPrompt);
            Controls.Add(button1);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button button1;
        private Label lblPrompt;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private TextBox txtBox3;
        private Label lblDisplay1;
        private Label lblDisplay2;
        private Label lblClose;
    }
}
