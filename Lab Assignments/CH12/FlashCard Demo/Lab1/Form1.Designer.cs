namespace Lab1
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
            lblPrompt = new Label();
            txtBoxDefine = new TextBox();
            button1 = new Button();
            lblDisplay = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtYear = new TextBox();
            lblName = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            btnADD = new Button();
            lblDisplay2 = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Segoe UI", 12F);
            lblPrompt.Location = new Point(303, 12);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(308, 28);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter a Word to see The definition";
            // 
            // txtBoxDefine
            // 
            txtBoxDefine.Location = new Point(309, 53);
            txtBoxDefine.Name = "txtBoxDefine";
            txtBoxDefine.Size = new Size(302, 27);
            txtBoxDefine.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(664, 38);
            button1.Name = "button1";
            button1.Size = new Size(117, 57);
            button1.TabIndex = 2;
            button1.Text = "Show FlashCard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Segoe UI", 12F);
            lblDisplay.Location = new Point(281, 98);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(500, 91);
            lblDisplay.TabIndex = 3;
            lblDisplay.Text = "_";
            // 
            // txtName
            // 
            txtName.AccessibleName = "GroupBox1";
            txtName.Location = new Point(171, 220);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 27);
            txtName.TabIndex = 4;
            txtName.Visible = false;
            // 
            // txtDescription
            // 
            txtDescription.AccessibleName = "GroupBox1";
            txtDescription.Location = new Point(142, 267);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(269, 27);
            txtDescription.TabIndex = 5;
            txtDescription.Visible = false;
            // 
            // txtYear
            // 
            txtYear.AccessibleName = "GroupBox1";
            txtYear.Location = new Point(181, 324);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(230, 27);
            txtYear.TabIndex = 6;
            txtYear.Visible = false;
            // 
            // lblName
            // 
            lblName.AccessibleName = "GroupBox1";
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(11, 216);
            lblName.Name = "lblName";
            lblName.Size = new Size(164, 28);
            lblName.TabIndex = 7;
            lblName.Text = "Enter New Word :";
            lblName.Visible = false;
            // 
            // lbl3
            // 
            lbl3.AccessibleName = "GroupBox1";
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 12F);
            lbl3.Location = new Point(11, 267);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(107, 28);
            lbl3.TabIndex = 8;
            lbl3.Text = "Definition :";
            lbl3.Visible = false;
            // 
            // lbl4
            // 
            lbl4.AccessibleName = "GroupBox1";
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 9F);
            lbl4.Location = new Point(11, 327);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(164, 20);
            lbl4.TabIndex = 9;
            lbl4.Text = "Trending Topic or Year :";
            lbl4.Visible = false;
            lbl4.Click += label4_Click;
            // 
            // btnADD
            // 
            btnADD.AccessibleName = "GroupBox1";
            btnADD.Location = new Point(95, 375);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(161, 46);
            btnADD.TabIndex = 10;
            btnADD.Text = "ADD FlashCard";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Visible = false;
            btnADD.Click += btnADD_Click;
            // 
            // lblDisplay2
            // 
            lblDisplay2.AccessibleName = "GroupBox1";
            lblDisplay2.Font = new Font("Segoe UI", 9F);
            lblDisplay2.Location = new Point(441, 220);
            lblDisplay2.Name = "lblDisplay2";
            lblDisplay2.Size = new Size(299, 171);
            lblDisplay2.TabIndex = 11;
            lblDisplay2.Text = "_";
            lblDisplay2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay2);
            Controls.Add(btnADD);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lblName);
            Controls.Add(txtYear);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblDisplay);
            Controls.Add(button1);
            Controls.Add(txtBoxDefine);
            Controls.Add(lblPrompt);
            Name = "Form1";
            Text = "FlashCards";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtBoxDefine;
        private Button button1;
        private Label lblDisplay;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtYear;
        private Label lblName;
        private Label lbl3;
        private Label lbl4;
        private Button btnADD;
        private Label lblDisplay2;
    }
}
