namespace lab5
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
            button1 = new Button();
            txtBox1 = new TextBox();
            lblPhrase = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(148, 240);
            button1.Name = "button1";
            button1.Size = new Size(259, 134);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(148, 173);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(442, 27);
            txtBox1.TabIndex = 1;
            // 
            // lblPhrase
            // 
            lblPhrase.AutoSize = true;
            lblPhrase.Location = new Point(149, 112);
            lblPhrase.Name = "lblPhrase";
            lblPhrase.Size = new Size(129, 20);
            lblPhrase.TabIndex = 2;
            lblPhrase.Text = "ENTER A PHRASE!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPhrase);
            Controls.Add(txtBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Name Strings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtBox1;
        private Label lblPhrase;
    }
}
