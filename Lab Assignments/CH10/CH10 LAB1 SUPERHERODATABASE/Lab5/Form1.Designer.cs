namespace Lab5
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
            rchTxt1 = new RichTextBox();
            lblPromptAdd = new Label();
            txtAdd = new TextBox();
            btnAdd = new Button();
            lblPromptRemove = new Label();
            txtRemove = new TextBox();
            btnRemove = new Button();
            lblRemove = new Label();
            SuspendLayout();
            // 
            // rchTxt1
            // 
            rchTxt1.Location = new Point(377, 31);
            rchTxt1.Name = "rchTxt1";
            rchTxt1.Size = new Size(345, 378);
            rchTxt1.TabIndex = 0;
            rchTxt1.Text = "";
            // 
            // lblPromptAdd
            // 
            lblPromptAdd.AutoSize = true;
            lblPromptAdd.Location = new Point(12, 57);
            lblPromptAdd.Name = "lblPromptAdd";
            lblPromptAdd.Size = new Size(116, 20);
            lblPromptAdd.TabIndex = 1;
            lblPromptAdd.Text = "ADD STUDENT?";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(168, 54);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(159, 27);
            txtAdd.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(233, 97);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 45);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPromptRemove
            // 
            lblPromptRemove.AutoSize = true;
            lblPromptRemove.Location = new Point(12, 183);
            lblPromptRemove.Name = "lblPromptRemove";
            lblPromptRemove.Size = new Size(142, 20);
            lblPromptRemove.TabIndex = 4;
            lblPromptRemove.Text = "REMOVE STUDENT?";
            // 
            // txtRemove
            // 
            txtRemove.Location = new Point(12, 222);
            txtRemove.Name = "txtRemove";
            txtRemove.Size = new Size(159, 27);
            txtRemove.TabIndex = 5;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F);
            btnRemove.ForeColor = SystemColors.ActiveCaptionText;
            btnRemove.Location = new Point(12, 278);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(116, 57);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove ?";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblRemove
            // 
            lblRemove.AutoSize = true;
            lblRemove.ForeColor = Color.Red;
            lblRemove.Location = new Point(12, 255);
            lblRemove.Name = "lblRemove";
            lblRemove.Size = new Size(294, 20);
            lblRemove.TabIndex = 7;
            lblRemove.Text = "ARE YOU SURE REMOVE YOUR NEW ADD ?";
            lblRemove.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRemove);
            Controls.Add(btnRemove);
            Controls.Add(txtRemove);
            Controls.Add(lblPromptRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtAdd);
            Controls.Add(lblPromptAdd);
            Controls.Add(rchTxt1);
            Name = "Form1";
            Text = "STUDENT DATABASE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rchTxt1;
        private Label lblPromptAdd;
        private TextBox txtAdd;
        private Button btnAdd;
        private Label lblPromptRemove;
        private TextBox txtRemove;
        private Button btnRemove;
        private Label lblRemove;
    }
}
