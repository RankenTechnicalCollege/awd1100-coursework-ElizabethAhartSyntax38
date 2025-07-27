namespace EX2
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
            txtExemption = new TextBox();
            btnExemption = new Button();
            lblPrompt = new Label();
            lblPrompt2 = new Label();
            txtExemption2 = new TextBox();
            btnExemption2 = new Button();
            lblExemption3 = new Label();
            txtExemption3 = new TextBox();
            btnExemption3 = new Button();
            lblExemption4 = new Label();
            txtExemtion4 = new TextBox();
            btnExemption4 = new Button();
            SuspendLayout();
            // 
            // txtExemption
            // 
            txtExemption.Location = new Point(92, 32);
            txtExemption.Name = "txtExemption";
            txtExemption.Size = new Size(266, 27);
            txtExemption.TabIndex = 0;
            // 
            // btnExemption
            // 
            btnExemption.Location = new Point(376, 5);
            btnExemption.Name = "btnExemption";
            btnExemption.Size = new Size(162, 80);
            btnExemption.TabIndex = 1;
            btnExemption.Text = "FORMAT EXEMPTION";
            btnExemption.UseVisualStyleBackColor = true;
            btnExemption.Click += btnExemption_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(2, 9);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(164, 20);
            lblPrompt.TabIndex = 2;
            lblPrompt.Text = "INVESTMENT AMOUNT";
            // 
            // lblPrompt2
            // 
            lblPrompt2.AutoSize = true;
            lblPrompt2.Location = new Point(2, 82);
            lblPrompt2.Name = "lblPrompt2";
            lblPrompt2.Size = new Size(164, 20);
            lblPrompt2.TabIndex = 3;
            lblPrompt2.Text = "INVESTMENT AMOUNT";
            // 
            // txtExemption2
            // 
            txtExemption2.Location = new Point(92, 130);
            txtExemption2.Name = "txtExemption2";
            txtExemption2.Size = new Size(266, 27);
            txtExemption2.TabIndex = 4;
            // 
            // btnExemption2
            // 
            btnExemption2.Location = new Point(376, 113);
            btnExemption2.Name = "btnExemption2";
            btnExemption2.Size = new Size(162, 80);
            btnExemption2.TabIndex = 5;
            btnExemption2.Text = "Arithmetic Exemption";
            btnExemption2.UseVisualStyleBackColor = true;
            btnExemption2.Click += btnExemption2_Click;
            // 
            // lblExemption3
            // 
            lblExemption3.AutoSize = true;
            lblExemption3.Location = new Point(2, 189);
            lblExemption3.Name = "lblExemption3";
            lblExemption3.Size = new Size(164, 20);
            lblExemption3.TabIndex = 6;
            lblExemption3.Text = "INVESTMENT AMOUNT";
            // 
            // txtExemption3
            // 
            txtExemption3.Location = new Point(92, 235);
            txtExemption3.Name = "txtExemption3";
            txtExemption3.Size = new Size(266, 27);
            txtExemption3.TabIndex = 7;
            // 
            // btnExemption3
            // 
            btnExemption3.Location = new Point(376, 218);
            btnExemption3.Name = "btnExemption3";
            btnExemption3.Size = new Size(162, 80);
            btnExemption3.TabIndex = 8;
            btnExemption3.Text = "INVALID CAST";
            btnExemption3.UseVisualStyleBackColor = true;
            btnExemption3.Click += btnExemption3_Click;
            // 
            // lblExemption4
            // 
            lblExemption4.AutoSize = true;
            lblExemption4.Location = new Point(2, 300);
            lblExemption4.Name = "lblExemption4";
            lblExemption4.Size = new Size(164, 20);
            lblExemption4.TabIndex = 9;
            lblExemption4.Text = "INVESTMENT AMOUNT";
            // 
            // txtExemtion4
            // 
            txtExemtion4.Location = new Point(92, 341);
            txtExemtion4.Name = "txtExemtion4";
            txtExemtion4.Size = new Size(266, 27);
            txtExemtion4.TabIndex = 10;
            // 
            // btnExemption4
            // 
            btnExemption4.Location = new Point(376, 323);
            btnExemption4.Name = "btnExemption4";
            btnExemption4.Size = new Size(162, 80);
            btnExemption4.TabIndex = 11;
            btnExemption4.Text = "NULL REFERENCE";
            btnExemption4.UseVisualStyleBackColor = true;
            btnExemption4.Click += btnExemption4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExemption4);
            Controls.Add(txtExemtion4);
            Controls.Add(lblExemption4);
            Controls.Add(btnExemption3);
            Controls.Add(txtExemption3);
            Controls.Add(lblExemption3);
            Controls.Add(btnExemption2);
            Controls.Add(txtExemption2);
            Controls.Add(lblPrompt2);
            Controls.Add(lblPrompt);
            Controls.Add(btnExemption);
            Controls.Add(txtExemption);
            Name = "Form1";
            Text = "EXEMPTION SHOW";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExemption;
        private Button btnExemption;
        private Label lblPrompt;
        private Label lblPrompt2;
        private TextBox txtExemption2;
        private Button btnExemption2;
        private Label lblExemption3;
        private TextBox txtExemption3;
        private Button btnExemption3;
        private Label lblExemption4;
        private TextBox txtExemtion4;
        private Button btnExemption4;
    }
}
