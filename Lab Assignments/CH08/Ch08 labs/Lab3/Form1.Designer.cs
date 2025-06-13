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
            lblSearch = new Label();
            btnSearch = new Button();
            txtBox1 = new TextBox();
            lblName = new Label();
            lblPublisher = new Label();
            lblPrice = new Label();
            lblDisplayName = new Label();
            lblDisplayPub = new Label();
            lblDisplayPrice = new Label();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(86, 87);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(138, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "SEARCH KEYWORD";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(134, 143);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 71);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(339, 78);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(326, 27);
            txtBox1.TabIndex = 2;
            txtBox1.TextChanged += txtBox1_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(362, 149);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name :";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(362, 194);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(76, 20);
            lblPublisher.TabIndex = 4;
            lblPublisher.Text = "Publisher :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(365, 230);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(48, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price :";
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Location = new Point(498, 150);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(15, 20);
            lblDisplayName.TabIndex = 6;
            lblDisplayName.Text = "_";
            // 
            // lblDisplayPub
            // 
            lblDisplayPub.AutoSize = true;
            lblDisplayPub.Location = new Point(500, 188);
            lblDisplayPub.Name = "lblDisplayPub";
            lblDisplayPub.Size = new Size(15, 20);
            lblDisplayPub.TabIndex = 7;
            lblDisplayPub.Text = "_";
            // 
            // lblDisplayPrice
            // 
            lblDisplayPrice.AutoSize = true;
            lblDisplayPrice.Location = new Point(495, 229);
            lblDisplayPrice.Name = "lblDisplayPrice";
            lblDisplayPrice.Size = new Size(15, 20);
            lblDisplayPrice.TabIndex = 8;
            lblDisplayPrice.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplayPrice);
            Controls.Add(lblDisplayPub);
            Controls.Add(lblDisplayName);
            Controls.Add(lblPrice);
            Controls.Add(lblPublisher);
            Controls.Add(lblName);
            Controls.Add(txtBox1);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private Button btnSearch;
        private TextBox txtBox1;
        private Label lblName;
        private Label lblPublisher;
        private Label lblPrice;
        private Label lblDisplayName;
        private Label lblDisplayPub;
        private Label lblDisplayPrice;
    }
}
