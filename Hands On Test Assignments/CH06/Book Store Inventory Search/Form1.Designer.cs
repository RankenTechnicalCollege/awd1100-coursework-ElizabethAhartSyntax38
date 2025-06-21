namespace Book_Store_Inventory_Search
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
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            btnSearchAuth = new Button();
            lblIsbn = new Label();
            txtIsbn = new TextBox();
            btnSearchIsbn = new Button();
            lblKeyword = new Label();
            txtKeyWord = new TextBox();
            btnSearchKeyWord = new Button();
            lblName = new Label();
            lblDisplayname = new Label();
            lblDiscription = new Label();
            lblDisplayDescript = new Label();
            lblAuth2Show = new Label();
            lblDisplayAuthor = new Label();
            lblShowIsbn = new Label();
            lblDisplayIsbn = new Label();
            SuspendLayout();
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F);
            lblAuthor.Location = new Point(12, 19);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 28);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "AUTHOR";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(133, 23);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(199, 27);
            txtAuthor.TabIndex = 1;
            // 
            // btnSearchAuth
            // 
            btnSearchAuth.Location = new Point(419, 18);
            btnSearchAuth.Name = "btnSearchAuth";
            btnSearchAuth.Size = new Size(94, 29);
            btnSearchAuth.TabIndex = 2;
            btnSearchAuth.Text = "Search";
            btnSearchAuth.UseVisualStyleBackColor = true;
            btnSearchAuth.Click += btnSearchAuth_Click;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Font = new Font("Segoe UI", 12F);
            lblIsbn.Location = new Point(12, 83);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(54, 28);
            lblIsbn.TabIndex = 3;
            lblIsbn.Text = "ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(133, 87);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(199, 27);
            txtIsbn.TabIndex = 4;
            // 
            // btnSearchIsbn
            // 
            btnSearchIsbn.Location = new Point(423, 82);
            btnSearchIsbn.Name = "btnSearchIsbn";
            btnSearchIsbn.Size = new Size(94, 29);
            btnSearchIsbn.TabIndex = 5;
            btnSearchIsbn.Text = "Search";
            btnSearchIsbn.UseVisualStyleBackColor = true;
            btnSearchIsbn.Click += btnSearchIsbn_Click;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Font = new Font("Segoe UI", 12F);
            lblKeyword.Location = new Point(16, 146);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(93, 28);
            lblKeyword.TabIndex = 6;
            lblKeyword.Tag = "";
            lblKeyword.Text = "KeyWord";
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(133, 147);
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(199, 27);
            txtKeyWord.TabIndex = 7;
            // 
            // btnSearchKeyWord
            // 
            btnSearchKeyWord.Location = new Point(423, 145);
            btnSearchKeyWord.Name = "btnSearchKeyWord";
            btnSearchKeyWord.Size = new Size(94, 29);
            btnSearchKeyWord.TabIndex = 8;
            btnSearchKeyWord.Text = "Search";
            btnSearchKeyWord.UseVisualStyleBackColor = true;
            btnSearchKeyWord.Click += btnSearchKeyWord_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 16F);
            lblName.Location = new Point(23, 212);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 37);
            lblName.TabIndex = 9;
            lblName.Text = "NAME:";
            // 
            // lblDisplayname
            // 
            lblDisplayname.AutoSize = true;
            lblDisplayname.Font = new Font("Segoe UI", 12F);
            lblDisplayname.Location = new Point(22, 247);
            lblDisplayname.Name = "lblDisplayname";
            lblDisplayname.Size = new Size(20, 28);
            lblDisplayname.TabIndex = 10;
            lblDisplayname.Text = "_";
            // 
            // lblDiscription
            // 
            lblDiscription.AutoSize = true;
            lblDiscription.Font = new Font("Segoe UI", 16F);
            lblDiscription.Location = new Point(23, 308);
            lblDiscription.Name = "lblDiscription";
            lblDiscription.Size = new Size(193, 37);
            lblDiscription.TabIndex = 11;
            lblDiscription.Text = "DESCRIPTION :";
            // 
            // lblDisplayDescript
            // 
            lblDisplayDescript.AutoSize = true;
            lblDisplayDescript.Font = new Font("Segoe UI", 12F);
            lblDisplayDescript.Location = new Point(24, 347);
            lblDisplayDescript.Name = "lblDisplayDescript";
            lblDisplayDescript.Size = new Size(20, 28);
            lblDisplayDescript.TabIndex = 12;
            lblDisplayDescript.Text = "_";
            // 
            // lblAuth2Show
            // 
            lblAuth2Show.AutoSize = true;
            lblAuth2Show.Font = new Font("Segoe UI", 16F);
            lblAuth2Show.Location = new Point(570, 201);
            lblAuth2Show.Name = "lblAuth2Show";
            lblAuth2Show.Size = new Size(134, 37);
            lblAuth2Show.TabIndex = 13;
            lblAuth2Show.Text = "AUTHOR :";
            // 
            // lblDisplayAuthor
            // 
            lblDisplayAuthor.AutoSize = true;
            lblDisplayAuthor.Font = new Font("Segoe UI", 12F);
            lblDisplayAuthor.Location = new Point(613, 254);
            lblDisplayAuthor.Name = "lblDisplayAuthor";
            lblDisplayAuthor.Size = new Size(20, 28);
            lblDisplayAuthor.TabIndex = 14;
            lblDisplayAuthor.Text = "_";
            // 
            // lblShowIsbn
            // 
            lblShowIsbn.AutoSize = true;
            lblShowIsbn.Font = new Font("Segoe UI", 16F);
            lblShowIsbn.Location = new Point(568, 302);
            lblShowIsbn.Name = "lblShowIsbn";
            lblShowIsbn.Size = new Size(86, 37);
            lblShowIsbn.TabIndex = 15;
            lblShowIsbn.Text = "ISBN :";
            // 
            // lblDisplayIsbn
            // 
            lblDisplayIsbn.AutoSize = true;
            lblDisplayIsbn.Location = new Point(624, 373);
            lblDisplayIsbn.Name = "lblDisplayIsbn";
            lblDisplayIsbn.Size = new Size(15, 20);
            lblDisplayIsbn.TabIndex = 16;
            lblDisplayIsbn.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplayIsbn);
            Controls.Add(lblShowIsbn);
            Controls.Add(lblDisplayAuthor);
            Controls.Add(lblAuth2Show);
            Controls.Add(lblDisplayDescript);
            Controls.Add(lblDiscription);
            Controls.Add(lblDisplayname);
            Controls.Add(lblName);
            Controls.Add(btnSearchKeyWord);
            Controls.Add(txtKeyWord);
            Controls.Add(lblKeyword);
            Controls.Add(btnSearchIsbn);
            Controls.Add(txtIsbn);
            Controls.Add(lblIsbn);
            Controls.Add(btnSearchAuth);
            Controls.Add(txtAuthor);
            Controls.Add(lblAuthor);
            Name = "Form1";
            Text = "Books And Antiques";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuthor;
        private TextBox txtAuthor;
        private Button btnSearchAuth;
        private Label lblIsbn;
        private TextBox txtIsbn;
        private Button btnSearchIsbn;
        private Label lblKeyword;
        private TextBox txtKeyWord;
        private Button btnSearchKeyWord;
        private Label lblName;
        private Label lblDisplayname;
        private Label lblDiscription;
        private Label lblDisplayDescript;
        private Label lblAuth2Show;
        private Label lblDisplayAuthor;
        private Label lblShowIsbn;
        private Label lblDisplayIsbn;
    }
}
