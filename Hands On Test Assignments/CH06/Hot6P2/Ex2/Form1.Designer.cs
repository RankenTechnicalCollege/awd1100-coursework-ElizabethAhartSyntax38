namespace Ex2
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
            lblQUAN = new Label();
            txtQuan = new TextBox();
            lblDiscountCode = new Label();
            txtDiscountCode = new TextBox();
            btnOrder = new Button();
            lblDisplayDiscount = new Label();
            rTxtBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // lblQUAN
            // 
            lblQUAN.AutoSize = true;
            lblQUAN.Location = new Point(12, 23);
            lblQUAN.Name = "lblQUAN";
            lblQUAN.Size = new Size(86, 20);
            lblQUAN.TabIndex = 0;
            lblQUAN.Text = "QUANTITY :";
            // 
            // txtQuan
            // 
            txtQuan.Location = new Point(190, 20);
            txtQuan.Name = "txtQuan";
            txtQuan.Size = new Size(196, 27);
            txtQuan.TabIndex = 1;
            // 
            // lblDiscountCode
            // 
            lblDiscountCode.AutoSize = true;
            lblDiscountCode.Location = new Point(12, 75);
            lblDiscountCode.Name = "lblDiscountCode";
            lblDiscountCode.Size = new Size(131, 20);
            lblDiscountCode.TabIndex = 2;
            lblDiscountCode.Text = "DISCOUNT CODE :";
            // 
            // txtDiscountCode
            // 
            txtDiscountCode.Location = new Point(194, 76);
            txtDiscountCode.Name = "txtDiscountCode";
            txtDiscountCode.Size = new Size(192, 27);
            txtDiscountCode.TabIndex = 3;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(501, 42);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(131, 53);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblDisplayDiscount
            // 
            lblDisplayDiscount.AutoSize = true;
            lblDisplayDiscount.Font = new Font("Segoe UI", 12F);
            lblDisplayDiscount.Location = new Point(111, 167);
            lblDisplayDiscount.Name = "lblDisplayDiscount";
            lblDisplayDiscount.Size = new Size(20, 28);
            lblDisplayDiscount.TabIndex = 5;
            lblDisplayDiscount.Text = "_";
            // 
            // rTxtBox1
            // 
            rTxtBox1.Location = new Point(273, 241);
            rTxtBox1.Name = "rTxtBox1";
            rTxtBox1.Size = new Size(166, 161);
            rTxtBox1.TabIndex = 6;
            rTxtBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rTxtBox1);
            Controls.Add(lblDisplayDiscount);
            Controls.Add(btnOrder);
            Controls.Add(txtDiscountCode);
            Controls.Add(lblDiscountCode);
            Controls.Add(txtQuan);
            Controls.Add(lblQUAN);
            Name = "Form1";
            Text = "CRAZY Kranks T-Shirt FACTORY!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQUAN;
        private TextBox txtQuan;
        private Label lblDiscountCode;
        private TextBox txtDiscountCode;
        private Button btnOrder;
        private Label lblDisplayDiscount;
        private RichTextBox rTxtBox1;
    }
}
