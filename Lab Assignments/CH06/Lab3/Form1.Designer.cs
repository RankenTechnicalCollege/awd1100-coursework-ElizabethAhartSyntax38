namespace Lab3
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
            label1 = new Label();
            txtboxBid = new TextBox();
            btnBid = new Button();
            lblDisplay = new Label();
            lblDisplay2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 0;
            label1.Text = "Auction";
            // 
            // txtboxBid
            // 
            txtboxBid.Location = new Point(10, 93);
            txtboxBid.Name = "txtboxBid";
            txtboxBid.Size = new Size(149, 25);
            txtboxBid.TabIndex = 1;
            // 
            // btnBid
            // 
            btnBid.Location = new Point(208, 85);
            btnBid.Name = "btnBid";
            btnBid.Size = new Size(42, 33);
            btnBid.TabIndex = 2;
            btnBid.Text = "bid";
            btnBid.UseVisualStyleBackColor = true;
            btnBid.Click += btnBid_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 24F);
            lblDisplay.Location = new Point(12, 163);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(40, 54);
            lblDisplay.TabIndex = 3;
            lblDisplay.Text = "_";
            // 
            // lblDisplay2
            // 
            lblDisplay2.AutoSize = true;
            lblDisplay2.Font = new Font("Segoe UI", 12F);
            lblDisplay2.Location = new Point(322, 48);
            lblDisplay2.Name = "lblDisplay2";
            lblDisplay2.Size = new Size(20, 28);
            lblDisplay2.TabIndex = 4;
            lblDisplay2.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
            Controls.Add(lblDisplay2);
            Controls.Add(lblDisplay);
            Controls.Add(btnBid);
            Controls.Add(txtboxBid);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8F);
            Name = "Form1";
            Text = "Parse Bid ( )";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtboxBid;
        private Button btnBid;
        private Label lblDisplay;
        private Label lblDisplay2;
    }
}
