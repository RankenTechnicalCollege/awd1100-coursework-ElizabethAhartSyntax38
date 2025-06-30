namespace lLab3
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
            txtbox1 = new TextBox();
            lbl1 = new Label();
            btnBid = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // txtbox1
            // 
            txtbox1.Location = new Point(31, 102);
            txtbox1.Name = "txtbox1";
            txtbox1.Size = new Size(125, 27);
            txtbox1.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 16F);
            lbl1.Location = new Point(24, 27);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(108, 37);
            lbl1.TabIndex = 1;
            lbl1.Text = "Auction";
            // 
            // btnBid
            // 
            btnBid.Location = new Point(234, 110);
            btnBid.Name = "btnBid";
            btnBid.Size = new Size(94, 29);
            btnBid.TabIndex = 2;
            btnBid.Text = "BID";
            btnBid.UseVisualStyleBackColor = true;
            btnBid.Click += btnBid_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 12F);
            lblDisplay.Location = new Point(32, 202);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(20, 28);
            lblDisplay.TabIndex = 3;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnBid);
            Controls.Add(lbl1);
            Controls.Add(txtbox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox1;
        private Label lbl1;
        private Button btnBid;
        private Label lblDisplay;
    }
}
