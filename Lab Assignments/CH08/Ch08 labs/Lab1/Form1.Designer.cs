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
            lblZip = new Label();
            lblDelivery = new Label();
            txtBox1 = new TextBox();
            lblDisplay = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(96, 89);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(73, 20);
            lblZip.TabIndex = 0;
            lblZip.Text = "ZIP CODE";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Location = new Point(329, 87);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(114, 20);
            lblDelivery.TabIndex = 1;
            lblDelivery.Text = "Delivery Charge";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(73, 127);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(125, 27);
            txtBox1.TabIndex = 2;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(334, 119);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 20);
            lblDisplay.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(75, 203);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 105);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblDisplay);
            Controls.Add(txtBox1);
            Controls.Add(lblDelivery);
            Controls.Add(lblZip);
            Name = "Form1";
            Text = "Delivery Charges";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZip;
        private Label lblDelivery;
        private TextBox txtBox1;
        private Label lblDisplay;
        private Button btnCalculate;
    }
}
