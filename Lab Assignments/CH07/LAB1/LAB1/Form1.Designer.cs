namespace LAB1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pcbox1 = new PictureBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            btnCalculate = new Button();
            lblWeightPrompt = new Label();
            lblHeightPrompt = new Label();
            lblDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbox1).BeginInit();
            SuspendLayout();
            // 
            // pcbox1
            // 
            pcbox1.BackColor = SystemColors.ActiveCaption;
            pcbox1.Image = (Image)resources.GetObject("pcbox1.Image");
            pcbox1.Location = new Point(390, 135);
            pcbox1.Name = "pcbox1";
            pcbox1.Size = new Size(398, 303);
            pcbox1.SizeMode = PictureBoxSizeMode.Zoom;
            pcbox1.TabIndex = 0;
            pcbox1.TabStop = false;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(106, 36);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(216, 27);
            txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(106, 91);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(216, 27);
            txtHeight.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(154, 156);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 67);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblWeightPrompt
            // 
            lblWeightPrompt.AutoSize = true;
            lblWeightPrompt.Location = new Point(3, 39);
            lblWeightPrompt.Name = "lblWeightPrompt";
            lblWeightPrompt.Size = new Size(97, 20);
            lblWeightPrompt.TabIndex = 4;
            lblWeightPrompt.Text = "WEIGHT (lbs)";
            // 
            // lblHeightPrompt
            // 
            lblHeightPrompt.AutoSize = true;
            lblHeightPrompt.Location = new Point(10, 98);
            lblHeightPrompt.Name = "lblHeightPrompt";
            lblHeightPrompt.Size = new Size(90, 20);
            lblHeightPrompt.TabIndex = 5;
            lblHeightPrompt.Text = "HEIGHT (in.)";
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Segoe UI Variable Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.Location = new Point(23, 249);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(324, 177);
            lblDisplay.TabIndex = 6;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(lblHeightPrompt);
            Controls.Add(lblWeightPrompt);
            Controls.Add(btnCalculate);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(pcbox1);
            Name = "Form1";
            Text = "BMI CALCULATOR";
            ((System.ComponentModel.ISupportInitialize)pcbox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbox1;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Button btnCalculate;
        private Label lblWeightPrompt;
        private Label lblHeightPrompt;
        private Label lblDisplay;
    }
}
