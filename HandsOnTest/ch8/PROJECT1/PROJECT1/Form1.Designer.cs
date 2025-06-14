namespace PROJECT1
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
            lblName = new Label();
            txtBox1 = new TextBox();
            btnSearch = new Button();
            LblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblDisplayFirst = new Label();
            lblDisplayLast = new Label();
            lblDisplayPhone = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 169);
            lblName.Name = "lblName";
            lblName.Size = new Size(185, 20);
            lblName.TabIndex = 0;
            lblName.Text = "First Name : OR Last Name";
            lblName.Click += lblName_Click;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(12, 212);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(249, 27);
            txtBox1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(397, 162);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 77);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // LblFirstName
            // 
            LblFirstName.AutoSize = true;
            LblFirstName.Location = new Point(20, 271);
            LblFirstName.Name = "LblFirstName";
            LblFirstName.Size = new Size(87, 20);
            LblFirstName.TabIndex = 3;
            LblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(20, 306);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 349);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(115, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone Number :";
            // 
            // lblDisplayFirst
            // 
            lblDisplayFirst.AutoSize = true;
            lblDisplayFirst.Location = new Point(182, 271);
            lblDisplayFirst.Name = "lblDisplayFirst";
            lblDisplayFirst.Size = new Size(15, 20);
            lblDisplayFirst.TabIndex = 6;
            lblDisplayFirst.Text = "_";
            // 
            // lblDisplayLast
            // 
            lblDisplayLast.AutoSize = true;
            lblDisplayLast.Location = new Point(176, 309);
            lblDisplayLast.Name = "lblDisplayLast";
            lblDisplayLast.Size = new Size(15, 20);
            lblDisplayLast.TabIndex = 7;
            lblDisplayLast.Text = "_";
            // 
            // lblDisplayPhone
            // 
            lblDisplayPhone.AutoSize = true;
            lblDisplayPhone.Location = new Point(178, 349);
            lblDisplayPhone.Name = "lblDisplayPhone";
            lblDisplayPhone.Size = new Size(15, 20);
            lblDisplayPhone.TabIndex = 8;
            lblDisplayPhone.Text = "_";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(316, 397);
            lblError.Name = "lblError";
            lblError.Size = new Size(15, 20);
            lblError.TabIndex = 9;
            lblError.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(lblDisplayPhone);
            Controls.Add(lblDisplayLast);
            Controls.Add(lblDisplayFirst);
            Controls.Add(lblPhone);
            Controls.Add(lblLastName);
            Controls.Add(LblFirstName);
            Controls.Add(btnSearch);
            Controls.Add(txtBox1);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtBox1;
        private Button btnSearch;
        private Label LblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblDisplayFirst;
        private Label lblDisplayLast;
        private Label lblDisplayPhone;
        private Label lblError;
    }
}
