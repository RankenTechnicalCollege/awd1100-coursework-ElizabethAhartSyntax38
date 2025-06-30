namespace ch6_Lab4
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
            txtBox1 = new TextBox();
            btnEnter = new Button();
            label1 = new Label();
            lblLowest = new Label();
            lblHigh = new Label();
            lblSum = new Label();
            lblAverage = new Label();
            lblDisplayAverage = new Label();
            lblDisplaySum = new Label();
            lblDisplayHigh = new Label();
            lblDisplayLow = new Label();
            lblDisplayNumEnt = new Label();
            SuspendLayout();
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(79, 95);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(125, 27);
            txtBox1.TabIndex = 0;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(340, 44);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 29);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 195);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 2;
            label1.Text = "Numbers Entered";
            // 
            // lblLowest
            // 
            lblLowest.AutoSize = true;
            lblLowest.Location = new Point(118, 245);
            lblLowest.Name = "lblLowest";
            lblLowest.Size = new Size(64, 20);
            lblLowest.TabIndex = 3;
            lblLowest.Text = "LOWEST";
            // 
            // lblHigh
            // 
            lblHigh.AutoSize = true;
            lblHigh.Location = new Point(118, 265);
            lblHigh.Name = "lblHigh";
            lblHigh.Size = new Size(60, 20);
            lblHigh.TabIndex = 4;
            lblHigh.Text = "Highest";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(118, 285);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(47, 20);
            lblSum.TabIndex = 5;
            lblSum.Text = "SUM :";
            lblSum.Click += label4_Click;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(118, 316);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(64, 20);
            lblAverage.TabIndex = 6;
            lblAverage.Text = "Average";
            // 
            // lblDisplayAverage
            // 
            lblDisplayAverage.AutoSize = true;
            lblDisplayAverage.Location = new Point(266, 316);
            lblDisplayAverage.Name = "lblDisplayAverage";
            lblDisplayAverage.Size = new Size(50, 20);
            lblDisplayAverage.TabIndex = 11;
            lblDisplayAverage.Text = "label6";
            // 
            // lblDisplaySum
            // 
            lblDisplaySum.AutoSize = true;
            lblDisplaySum.Location = new Point(266, 285);
            lblDisplaySum.Name = "lblDisplaySum";
            lblDisplaySum.Size = new Size(50, 20);
            lblDisplaySum.TabIndex = 10;
            lblDisplaySum.Text = "label7";
            // 
            // lblDisplayHigh
            // 
            lblDisplayHigh.AutoSize = true;
            lblDisplayHigh.Location = new Point(266, 265);
            lblDisplayHigh.Name = "lblDisplayHigh";
            lblDisplayHigh.Size = new Size(50, 20);
            lblDisplayHigh.TabIndex = 9;
            lblDisplayHigh.Text = "label8";
            // 
            // lblDisplayLow
            // 
            lblDisplayLow.AutoSize = true;
            lblDisplayLow.Location = new Point(266, 245);
            lblDisplayLow.Name = "lblDisplayLow";
            lblDisplayLow.Size = new Size(50, 20);
            lblDisplayLow.TabIndex = 8;
            lblDisplayLow.Text = "label9";
            // 
            // lblDisplayNumEnt
            // 
            lblDisplayNumEnt.AutoSize = true;
            lblDisplayNumEnt.Location = new Point(266, 195);
            lblDisplayNumEnt.Name = "lblDisplayNumEnt";
            lblDisplayNumEnt.Size = new Size(15, 20);
            lblDisplayNumEnt.TabIndex = 7;
            lblDisplayNumEnt.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplayAverage);
            Controls.Add(lblDisplaySum);
            Controls.Add(lblDisplayHigh);
            Controls.Add(lblDisplayLow);
            Controls.Add(lblDisplayNumEnt);
            Controls.Add(lblAverage);
            Controls.Add(lblSum);
            Controls.Add(lblHigh);
            Controls.Add(lblLowest);
            Controls.Add(label1);
            Controls.Add(btnEnter);
            Controls.Add(txtBox1);
            Name = "Form1";
            Text = "Integer stats";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox1;
        private Button btnEnter;
        private Label label1;
        private Label lblLowest;
        private Label lblHigh;
        private Label lblSum;
        private Label lblAverage;
        private Label lblDisplayAverage;
        private Label lblDisplaySum;
        private Label lblDisplayHigh;
        private Label lblDisplayLow;
        private Label lblDisplayNumEnt;
    }
}
