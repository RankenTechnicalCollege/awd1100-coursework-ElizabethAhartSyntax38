namespace LAB4
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
            lblHeader = new Label();
            textBox1 = new TextBox();
            btbSubmit = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(40, 49);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(185, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ENTER A RANDOM MOVIE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 1;
            // 
            // btbSubmit
            // 
            btbSubmit.Location = new Point(78, 161);
            btbSubmit.Name = "btbSubmit";
            btbSubmit.Size = new Size(164, 128);
            btbSubmit.TabIndex = 2;
            btbSubmit.Text = "SUBMIT";
            btbSubmit.UseVisualStyleBackColor = true;
            btbSubmit.Click += btbSubmit_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(447, 120);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(225, 169);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btbSubmit);
            Controls.Add(textBox1);
            Controls.Add(lblHeader);
            Name = "Form1";
            Text = "Searchable DataBase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private TextBox textBox1;
        private Button btbSubmit;
        private RichTextBox richTextBox1;
    }
}
