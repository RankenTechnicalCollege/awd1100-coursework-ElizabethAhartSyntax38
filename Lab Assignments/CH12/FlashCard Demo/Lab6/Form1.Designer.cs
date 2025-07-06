namespace Lab6
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
            lblLength = new Label();
            lblWidth = new Label();
            txtName = new TextBox();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnAdd = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(32, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 0;
            lblName.Text = "NAME";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(29, 153);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(54, 20);
            lblLength.TabIndex = 1;
            lblLength.Text = "Length";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(29, 261);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(49, 20);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Width";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(12, 196);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(125, 27);
            txtLength.TabIndex = 4;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(12, 316);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(224, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 68);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Segoe UI", 12F);
            lblDisplay.Location = new Point(226, 179);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(285, 194);
            lblDisplay.TabIndex = 7;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnAdd);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(txtName);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Tilling Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLength;
        private Label lblWidth;
        private TextBox txtName;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnAdd;
        private Label lblDisplay;
    }
}
