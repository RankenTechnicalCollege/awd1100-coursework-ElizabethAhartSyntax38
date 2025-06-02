namespace EX3
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
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            btnCalculate = new Button();
            lblArea = new Label();
            lblWeekFee = new Label();
            lblSeason = new Label();
            lblTotalCost = new Label();
            lblDisplayCost = new Label();
            lblDisplayWKS = new Label();
            lblDisplayFEE = new Label();
            lblDisplayArea = new Label();
            SuspendLayout();
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(52, 62);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(130, 20);
            lblLength.TabIndex = 0;
            lblLength.Text = "\"Enter\" length (FT)";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(353, 62);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(128, 20);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "\"Enter\" Width (FT)";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(52, 95);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(125, 27);
            txtBox1.TabIndex = 2;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(353, 91);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(125, 27);
            txtBox2.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(657, 59);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(104, 59);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(95, 198);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 20);
            lblArea.TabIndex = 5;
            lblArea.Text = "Area";
            // 
            // lblWeekFee
            // 
            lblWeekFee.AutoSize = true;
            lblWeekFee.Location = new Point(95, 235);
            lblWeekFee.Name = "lblWeekFee";
            lblWeekFee.Size = new Size(86, 20);
            lblWeekFee.TabIndex = 6;
            lblWeekFee.Text = "Weekly Fee:";
            // 
            // lblSeason
            // 
            lblSeason.AutoSize = true;
            lblSeason.Location = new Point(32, 274);
            lblSeason.Name = "lblSeason";
            lblSeason.Size = new Size(150, 20);
            lblSeason.TabIndex = 7;
            lblSeason.Text = "Season Length (WKS)";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(95, 315);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(78, 20);
            lblTotalCost.TabIndex = 8;
            lblTotalCost.Text = "Total Cost:";
            // 
            // lblDisplayCost
            // 
            lblDisplayCost.AutoSize = true;
            lblDisplayCost.Location = new Point(206, 315);
            lblDisplayCost.Name = "lblDisplayCost";
            lblDisplayCost.Size = new Size(0, 20);
            lblDisplayCost.TabIndex = 12;
            // 
            // lblDisplayWKS
            // 
            lblDisplayWKS.AutoSize = true;
            lblDisplayWKS.Location = new Point(206, 274);
            lblDisplayWKS.Name = "lblDisplayWKS";
            lblDisplayWKS.Size = new Size(0, 20);
            lblDisplayWKS.TabIndex = 11;
            // 
            // lblDisplayFEE
            // 
            lblDisplayFEE.AutoSize = true;
            lblDisplayFEE.Location = new Point(206, 235);
            lblDisplayFEE.Name = "lblDisplayFEE";
            lblDisplayFEE.Size = new Size(0, 20);
            lblDisplayFEE.TabIndex = 10;
            // 
            // lblDisplayArea
            // 
            lblDisplayArea.AutoSize = true;
            lblDisplayArea.Location = new Point(206, 198);
            lblDisplayArea.Name = "lblDisplayArea";
            lblDisplayArea.Size = new Size(0, 20);
            lblDisplayArea.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplayCost);
            Controls.Add(lblDisplayWKS);
            Controls.Add(lblDisplayFEE);
            Controls.Add(lblDisplayArea);
            Controls.Add(lblTotalCost);
            Controls.Add(lblSeason);
            Controls.Add(lblWeekFee);
            Controls.Add(lblArea);
            Controls.Add(btnCalculate);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Name = "Form1";
            Text = "Greg Lawn Mowing Service";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLength;
        private Label lblWidth;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private Button btnCalculate;
        private Label lblArea;
        private Label lblWeekFee;
        private Label lblSeason;
        private Label lblTotalCost;
        private Label lblDisplayCost;
        private Label lblDisplayWKS;
        private Label lblDisplayFEE;
        private Label lblDisplayArea;
    }
}
