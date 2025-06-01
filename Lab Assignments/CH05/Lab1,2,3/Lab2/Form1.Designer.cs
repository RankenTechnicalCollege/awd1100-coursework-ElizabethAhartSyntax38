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
            lblWindSpeed = new Label();
            LblEstimate = new Label();
            label1 = new Label();
            txtWindSpeed = new TextBox();
            TxtCategory = new TextBox();
            btnClick = new Button();
            SuspendLayout();
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.AutoSize = true;
            lblWindSpeed.Location = new Point(36, 102);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(90, 20);
            lblWindSpeed.TabIndex = 0;
            lblWindSpeed.Text = "Wind Speed";
            // 
            // LblEstimate
            // 
            LblEstimate.AutoSize = true;
            LblEstimate.Location = new Point(315, 102);
            LblEstimate.Name = "LblEstimate";
            LblEstimate.Size = new Size(66, 20);
            LblEstimate.TabIndex = 1;
            LblEstimate.Text = "Estimate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 100);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // txtWindSpeed
            // 
            txtWindSpeed.Location = new Point(36, 153);
            txtWindSpeed.Name = "txtWindSpeed";
            txtWindSpeed.Size = new Size(125, 27);
            txtWindSpeed.TabIndex = 3;
            // 
            // TxtCategory
            // 
            TxtCategory.Location = new Point(575, 153);
            TxtCategory.Name = "TxtCategory";
            TxtCategory.Size = new Size(125, 27);
            TxtCategory.TabIndex = 4;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(315, 153);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(94, 29);
            btnClick.TabIndex = 5;
            btnClick.Text = "click";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClick);
            Controls.Add(TxtCategory);
            Controls.Add(txtWindSpeed);
            Controls.Add(label1);
            Controls.Add(LblEstimate);
            Controls.Add(lblWindSpeed);
            Name = "Form1";
            Text = "Hurricane Scale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWindSpeed;
        private Label LblEstimate;
        private Label label1;
        private TextBox txtWindSpeed;
        private TextBox TxtCategory;
        private Button btnClick;
    }
}
