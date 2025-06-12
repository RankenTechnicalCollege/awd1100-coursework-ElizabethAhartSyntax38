namespace LAB2
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
            lblNIGHT = new Label();
            txtBoxEntry1 = new TextBox();
            btnCalculate = new Button();
            lblNightlyCost = new Label();
            lblTotal = new Label();
            txtNIGHT = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // lblNIGHT
            // 
            lblNIGHT.AutoSize = true;
            lblNIGHT.Location = new Point(15, 18);
            lblNIGHT.Name = "lblNIGHT";
            lblNIGHT.Size = new Size(116, 20);
            lblNIGHT.TabIndex = 0;
            lblNIGHT.Text = "NIGHTS STAYED";
            // 
            // txtBoxEntry1
            // 
            txtBoxEntry1.Location = new Point(24, 51);
            txtBoxEntry1.Name = "txtBoxEntry1";
            txtBoxEntry1.Size = new Size(66, 27);
            txtBoxEntry1.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(24, 105);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(66, 98);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Click";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblNightlyCost
            // 
            lblNightlyCost.AutoSize = true;
            lblNightlyCost.Location = new Point(141, 105);
            lblNightlyCost.Name = "lblNightlyCost";
            lblNightlyCost.Size = new Size(93, 20);
            lblNightlyCost.TabIndex = 3;
            lblNightlyCost.Text = "Nightly Cost:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(141, 172);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(124, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total cost of stay:";
            // 
            // txtNIGHT
            // 
            txtNIGHT.Location = new Point(334, 98);
            txtNIGHT.Name = "txtNIGHT";
            txtNIGHT.Size = new Size(125, 27);
            txtNIGHT.TabIndex = 6;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(263, 134);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(196, 27);
            txtTax.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(334, 176);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 8;
            txtTotal.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtNIGHT);
            Controls.Add(lblTotal);
            Controls.Add(lblNightlyCost);
            Controls.Add(btnCalculate);
            Controls.Add(txtBoxEntry1);
            Controls.Add(lblNIGHT);
            Name = "Form1";
            Text = "\"The CAREFREE Resort\"";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNIGHT;
        private TextBox txtBoxEntry1;
        private Button btnCalculate;
        private Label lblNightlyCost;
        private Label lblTotal;
        private TextBox txtNIGHT;
        private TextBox txtTax;
        private TextBox txtTotal;
    }
}
