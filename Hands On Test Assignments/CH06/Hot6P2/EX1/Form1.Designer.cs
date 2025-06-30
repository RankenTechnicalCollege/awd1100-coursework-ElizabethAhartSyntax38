namespace EX1
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
            btnSmall = new Button();
            btnMedium = new Button();
            btnLarge = new Button();
            lblSmall = new Label();
            lblSmallQuantiity = new Label();
            lblMediumQuant = new Label();
            lblLarge = new Label();
            lblLargeP = new Label();
            lblLargeQuant = new Label();
            rTxtBox1 = new RichTextBox();
            btnClear = new Button();
            btnInvoice = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(291, 28);
            label1.TabIndex = 0;
            label1.Text = ". What Size Shirts Do You Need?";
            // 
            // btnSmall
            // 
            btnSmall.Location = new Point(12, 100);
            btnSmall.Name = "btnSmall";
            btnSmall.Size = new Size(94, 29);
            btnSmall.TabIndex = 1;
            btnSmall.Text = "Small";
            btnSmall.UseVisualStyleBackColor = true;
            btnSmall.Click += btnSmall_Click;
            // 
            // btnMedium
            // 
            btnMedium.Location = new Point(145, 100);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(94, 29);
            btnMedium.TabIndex = 2;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnLarge
            // 
            btnLarge.Location = new Point(283, 100);
            btnLarge.Name = "btnLarge";
            btnLarge.Size = new Size(94, 29);
            btnLarge.TabIndex = 3;
            btnLarge.Text = "Large";
            btnLarge.UseVisualStyleBackColor = true;
            btnLarge.Click += btnLarge_Click;
            // 
            // lblSmall
            // 
            lblSmall.AutoSize = true;
            lblSmall.Location = new Point(20, 77);
            lblSmall.Name = "lblSmall";
            lblSmall.Size = new Size(86, 20);
            lblSmall.TabIndex = 4;
            lblSmall.Text = "$9.99 EACH";
            // 
            // lblSmallQuantiity
            // 
            lblSmallQuantiity.AutoSize = true;
            lblSmallQuantiity.Location = new Point(51, 132);
            lblSmallQuantiity.Name = "lblSmallQuantiity";
            lblSmallQuantiity.Size = new Size(17, 20);
            lblSmallQuantiity.TabIndex = 5;
            lblSmallQuantiity.Text = "2";
            // 
            // lblMediumQuant
            // 
            lblMediumQuant.AutoSize = true;
            lblMediumQuant.Location = new Point(168, 132);
            lblMediumQuant.Name = "lblMediumQuant";
            lblMediumQuant.Size = new Size(17, 20);
            lblMediumQuant.TabIndex = 6;
            lblMediumQuant.Text = "5";
            // 
            // lblLarge
            // 
            lblLarge.AutoSize = true;
            lblLarge.Location = new Point(145, 77);
            lblLarge.Name = "lblLarge";
            lblLarge.Size = new Size(94, 20);
            lblLarge.TabIndex = 7;
            lblLarge.Text = "$10.99 EACH";
            // 
            // lblLargeP
            // 
            lblLargeP.AutoSize = true;
            lblLargeP.Location = new Point(290, 77);
            lblLargeP.Name = "lblLargeP";
            lblLargeP.Size = new Size(94, 20);
            lblLargeP.TabIndex = 8;
            lblLargeP.Text = "$11.99 EACH";
            // 
            // lblLargeQuant
            // 
            lblLargeQuant.AutoSize = true;
            lblLargeQuant.Location = new Point(290, 132);
            lblLargeQuant.Name = "lblLargeQuant";
            lblLargeQuant.Size = new Size(17, 20);
            lblLargeQuant.TabIndex = 9;
            lblLargeQuant.Text = "7";
            // 
            // rTxtBox1
            // 
            rTxtBox1.Location = new Point(20, 213);
            rTxtBox1.Name = "rTxtBox1";
            rTxtBox1.Size = new Size(357, 173);
            rTxtBox1.TabIndex = 10;
            rTxtBox1.Text = "";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(556, 131);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 66);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear Order";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.Location = new Point(556, 306);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(151, 40);
            btnInvoice.TabIndex = 12;
            btnInvoice.Text = "Show Invoice for all three Deals";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvoice);
            Controls.Add(btnClear);
            Controls.Add(rTxtBox1);
            Controls.Add(lblLargeQuant);
            Controls.Add(lblLargeP);
            Controls.Add(lblLarge);
            Controls.Add(lblMediumQuant);
            Controls.Add(lblSmallQuantiity);
            Controls.Add(lblSmall);
            Controls.Add(btnLarge);
            Controls.Add(btnMedium);
            Controls.Add(btnSmall);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SUPER CUSTOM COOL SHIRTS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSmall;
        private Button btnMedium;
        private Button btnLarge;
        private Label lblSmall;
        private Label lblSmallQuantiity;
        private Label lblMediumQuant;
        private Label lblLarge;
        private Label lblLargeP;
        private Label lblLargeQuant;
        private RichTextBox rTxtBox1;
        private Button btnClear;
        private Button btnInvoice;
    }
}
