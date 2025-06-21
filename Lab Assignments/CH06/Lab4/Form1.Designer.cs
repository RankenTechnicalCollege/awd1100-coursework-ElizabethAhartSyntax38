namespace Lab4
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
            lblLength = new Label();
            lblWidth = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            lblTotalArea = new Label();
            lblDisplayTotalArea = new Label();
            lblTotalCost = new Label();
            LblDisplayTotalCost = new Label();
            SuspendLayout();
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(21, 58);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(64, 20);
            lblLength.TabIndex = 0;
            lblLength.Text = "LENGTH";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(204, 57);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(56, 20);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "WIDTH";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(12, 81);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(125, 27);
            txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(204, 81);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(436, 81);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(130, 131);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotalArea
            // 
            lblTotalArea.AutoSize = true;
            lblTotalArea.Location = new Point(23, 213);
            lblTotalArea.Name = "lblTotalArea";
            lblTotalArea.Size = new Size(119, 20);
            lblTotalArea.TabIndex = 5;
            lblTotalArea.Text = "Total Area Sqft : ";
            // 
            // lblDisplayTotalArea
            // 
            lblDisplayTotalArea.AutoSize = true;
            lblDisplayTotalArea.Location = new Point(211, 210);
            lblDisplayTotalArea.Name = "lblDisplayTotalArea";
            lblDisplayTotalArea.Size = new Size(15, 20);
            lblDisplayTotalArea.TabIndex = 6;
            lblDisplayTotalArea.Text = "_";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(35, 261);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(90, 20);
            lblTotalCost.TabIndex = 7;
            lblTotalCost.Text = "Total Cost  : ";
            // 
            // LblDisplayTotalCost
            // 
            LblDisplayTotalCost.AutoSize = true;
            LblDisplayTotalCost.Location = new Point(204, 261);
            LblDisplayTotalCost.Name = "LblDisplayTotalCost";
            LblDisplayTotalCost.Size = new Size(15, 20);
            LblDisplayTotalCost.TabIndex = 8;
            LblDisplayTotalCost.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblDisplayTotalCost);
            Controls.Add(lblTotalCost);
            Controls.Add(lblDisplayTotalArea);
            Controls.Add(lblTotalArea);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Name = "Form1";
            Text = "Calculate Esitimate For Paint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLength;
        private Label lblWidth;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnCalculate;
        private Label lblTotalArea;
        private Label lblDisplayTotalArea;
        private Label lblTotalCost;
        private Label LblDisplayTotalCost;
    }
}
