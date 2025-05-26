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
            num1 = new TextBox();
            num2 = new TextBox();
            num3 = new TextBox();
            num4 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Location = new Point(12, 150);
            num1.Name = "num1";
            num1.Size = new Size(71, 27);
            num1.TabIndex = 0;
            // 
            // num2
            // 
            num2.Location = new Point(111, 150);
            num2.Name = "num2";
            num2.Size = new Size(70, 27);
            num2.TabIndex = 1;
            num2.TextChanged += textBox2_TextChanged;
            // 
            // num3
            // 
            num3.Location = new Point(227, 150);
            num3.Name = "num3";
            num3.Size = new Size(66, 27);
            num3.TabIndex = 2;
            // 
            // num4
            // 
            num4.Location = new Point(325, 150);
            num4.Name = "num4";
            num4.Size = new Size(76, 27);
            num4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 69);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter number of Eggs";
            // 
            // button1
            // 
            button1.Location = new Point(63, 206);
            button1.Name = "button1";
            button1.Size = new Size(252, 29);
            button1.TabIndex = 5;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(33, 290);
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
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1;
        private TextBox num2;
        private TextBox num3;
        private TextBox num4;
        private Label label1;
        private Button button1;
        private Label lblDisplay;
    }
    
}
