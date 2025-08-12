namespace LAB3
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
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            txtBox3 = new TextBox();
            txtBox4 = new TextBox();
            txtBox5 = new TextBox();
            txtBox6 = new TextBox();
            txtBox7 = new TextBox();
            txtBox8 = new TextBox();
            SuspendLayout();
            // 
            // txtBox1
            // 
            txtBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBox1.Location = new Point(249, 28);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(33, 32);
            txtBox1.TabIndex = 0;
            txtBox1.Text = "1";
            txtBox1.Click += TextboxClick;
            txtBox1.Enter += txtFocus;
            txtBox1.KeyDown += TextBoxKeyDown;
            txtBox1.Leave += txtLeave;
            // 
            // txtBox2
            // 
            txtBox2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBox2.Location = new Point(364, 64);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(33, 32);
            txtBox2.TabIndex = 1;
            txtBox2.Text = "2";
            txtBox2.Click += TextboxClick;
            txtBox2.Enter += txtFocus;
            txtBox2.KeyDown += TextBoxKeyDown;
            txtBox2.Leave += txtLeave;
            // 
            // txtBox3
            // 
            txtBox3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBox3.Location = new Point(392, 146);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(33, 32);
            txtBox3.TabIndex = 2;
            txtBox3.Text = "3";
            txtBox3.Click += TextboxClick;
            txtBox3.Enter += txtFocus;
            txtBox3.KeyDown += TextBoxKeyDown;
            txtBox3.Leave += txtLeave;
            // 
            // txtBox4
            // 
            txtBox4.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBox4.Location = new Point(364, 252);
            txtBox4.Name = "txtBox4";
            txtBox4.Size = new Size(33, 32);
            txtBox4.TabIndex = 3;
            txtBox4.Text = "4";
            txtBox4.Click += TextboxClick;
            txtBox4.Enter += txtFocus;
            txtBox4.KeyDown += TextBoxKeyDown;
            txtBox4.Leave += txtLeave;
            // 
            // txtBox5
            // 
            txtBox5.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBox5.Location = new Point(249, 306);
            txtBox5.Name = "txtBox5";
            txtBox5.Size = new Size(33, 32);
            txtBox5.TabIndex = 4;
            txtBox5.Text = "5";
            txtBox5.Click += TextboxClick;
            txtBox5.Enter += txtFocus;
            txtBox5.KeyDown += TextBoxKeyDown;
            txtBox5.Leave += txtLeave;
            // 
            // txtBox6
            // 
            txtBox6.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBox6.Location = new Point(157, 252);
            txtBox6.Name = "txtBox6";
            txtBox6.Size = new Size(33, 32);
            txtBox6.TabIndex = 5;
            txtBox6.Text = "6";
            txtBox6.Click += TextboxClick;
            txtBox6.Enter += txtFocus;
            txtBox6.KeyDown += TextBoxKeyDown;
            txtBox6.Leave += txtLeave;
            // 
            // txtBox7
            // 
            txtBox7.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBox7.Location = new Point(121, 146);
            txtBox7.Name = "txtBox7";
            txtBox7.Size = new Size(33, 32);
            txtBox7.TabIndex = 6;
            txtBox7.Text = "7";
            txtBox7.Click += TextboxClick;
            txtBox7.Enter += txtFocus;
            txtBox7.KeyDown += TextBoxKeyDown;
            txtBox7.Leave += txtLeave;
            // 
            // txtBox8
            // 
            txtBox8.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBox8.Location = new Point(157, 64);
            txtBox8.Name = "txtBox8";
            txtBox8.Size = new Size(33, 32);
            txtBox8.TabIndex = 7;
            txtBox8.Text = "8";
            txtBox8.Click += TextboxClick;
            txtBox8.Enter += txtFocus;
            txtBox8.KeyDown += TextBoxKeyDown;
            txtBox8.Leave += txtLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox8);
            Controls.Add(txtBox7);
            Controls.Add(txtBox6);
            Controls.Add(txtBox5);
            Controls.Add(txtBox4);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Name = "Form1";
            Text = "CLOCK";
            Leave += txtLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox1;
        private TextBox txtBox2;
        private TextBox txtBox3;
        private TextBox txtBox4;
        private TextBox txtBox5;
        private TextBox txtBox6;
        private TextBox txtBox7;
        private TextBox txtBox8;
    }
}
