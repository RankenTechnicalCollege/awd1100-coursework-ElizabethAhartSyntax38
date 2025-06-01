namespace lab2
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
            lblestimate = new Label();
            lblCategory = new Label();
            txtBox1 = new TextBox();
            lblWindspeedPrompt = new Label();
            btnClick = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.AutoSize = true;
            lblWindSpeed.Location = new Point(39, 96);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(126, 20);
            lblWindSpeed.TabIndex = 0;
            lblWindSpeed.Text = "Wind Speed MPH";
            // 
            // lblestimate
            // 
            lblestimate.AutoSize = true;
            lblestimate.Location = new Point(300, 99);
            lblestimate.Name = "lblestimate";
            lblestimate.Size = new Size(66, 20);
            lblestimate.TabIndex = 1;
            lblestimate.Text = "Estimate";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(546, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(39, 141);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(125, 27);
            txtBox1.TabIndex = 3;
            txtBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblWindspeedPrompt
            // 
            lblWindspeedPrompt.AutoSize = true;
            lblWindspeedPrompt.Location = new Point(39, 42);
            lblWindspeedPrompt.Name = "lblWindspeedPrompt";
            lblWindspeedPrompt.Size = new Size(182, 20);
            lblWindspeedPrompt.TabIndex = 6;
            lblWindspeedPrompt.Text = "Please Enter a WindSpeed";
            // 
            // btnClick
            // 
            btnClick.Location = new Point(289, 141);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(116, 36);
            btnClick.TabIndex = 7;
            btnClick.Text = "Click";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(559, 138);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 20);
            lblDisplay.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnClick);
            Controls.Add(lblWindspeedPrompt);
            Controls.Add(txtBox1);
            Controls.Add(lblCategory);
            Controls.Add(lblestimate);
            Controls.Add(lblWindSpeed);
            Name = "Form1";
            Text = "Hurricane Scale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWindSpeed;
        private Label lblestimate;
        private Label lblCategory;
        private TextBox txtBox1;
        private Label lblWindspeedPrompt;
        private Button btnClick;
        private Label lblDisplay;
    }
}
