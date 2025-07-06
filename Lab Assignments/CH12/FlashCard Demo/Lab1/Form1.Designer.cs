namespace Lab1
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
            txtDescription = new TextBox();
            txtYear = new TextBox();
            lblName = new Label();
            lbldefinition = new Label();
            lblyear = new Label();
            btnADD = new Button();
            lblPrompt = new Label();
            txtBoxDefine = new TextBox();
            txtName = new TextBox();
            txtUpdateWord = new TextBox();
            txtUpdateDefine = new TextBox();
            txtupdateYear = new TextBox();
            lblUpdateYear = new Label();
            lblUpdateWord = new Label();
            lblUpdateDefine = new Label();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            lblDisplay = new Label();
            lblDisplay2 = new Label();
            button1 = new Button();
            groupBoxdelete = new GroupBox();
            lblSure = new Label();
            btnDelete = new Button();
            lblAreuSure = new Label();
            groupBox1.SuspendLayout();
            groupBoxdelete.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.AccessibleName = "GroupBox1";
            txtDescription.Location = new Point(142, 267);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(269, 27);
            txtDescription.TabIndex = 5;
            txtDescription.Visible = false;
            // 
            // txtYear
            // 
            txtYear.AccessibleName = "GroupBox1";
            txtYear.Location = new Point(181, 324);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(230, 27);
            txtYear.TabIndex = 6;
            txtYear.Visible = false;
            // 
            // lblName
            // 
            lblName.AccessibleName = "GroupBox1";
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(11, 216);
            lblName.Name = "lblName";
            lblName.Size = new Size(164, 28);
            lblName.TabIndex = 7;
            lblName.Text = "Enter New Word :";
            lblName.Visible = false;
            // 
            // lbldefinition
            // 
            lbldefinition.AccessibleName = "GroupBox1";
            lbldefinition.AutoSize = true;
            lbldefinition.Font = new Font("Segoe UI", 12F);
            lbldefinition.Location = new Point(11, 267);
            lbldefinition.Name = "lbldefinition";
            lbldefinition.Size = new Size(107, 28);
            lbldefinition.TabIndex = 8;
            lbldefinition.Text = "Definition :";
            lbldefinition.Visible = false;
            // 
            // lblyear
            // 
            lblyear.AccessibleName = "GroupBox1";
            lblyear.AutoSize = true;
            lblyear.Font = new Font("Segoe UI", 9F);
            lblyear.Location = new Point(11, 327);
            lblyear.Name = "lblyear";
            lblyear.Size = new Size(164, 20);
            lblyear.TabIndex = 9;
            lblyear.Text = "Trending Topic or Year :";
            lblyear.Visible = false;
            // 
            // btnADD
            // 
            btnADD.AccessibleName = "GroupBox1";
            btnADD.Location = new Point(95, 375);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(161, 46);
            btnADD.TabIndex = 10;
            btnADD.Text = "ADD FlashCard";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Visible = false;
            btnADD.Click += btnADD_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Segoe UI", 12F);
            lblPrompt.Location = new Point(473, 8);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(308, 28);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter a Word to see The definition";
            // 
            // txtBoxDefine
            // 
            txtBoxDefine.Location = new Point(331, 39);
            txtBoxDefine.Name = "txtBoxDefine";
            txtBoxDefine.Size = new Size(450, 27);
            txtBoxDefine.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.AccessibleName = "GroupBox1";
            txtName.Location = new Point(171, 220);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 27);
            txtName.TabIndex = 4;
            txtName.Visible = false;
            // 
            // txtUpdateWord
            // 
            txtUpdateWord.AccessibleName = "GroupBox1";
            txtUpdateWord.Location = new Point(141, 24);
            txtUpdateWord.Name = "txtUpdateWord";
            txtUpdateWord.Size = new Size(143, 27);
            txtUpdateWord.TabIndex = 10;
            txtUpdateWord.Visible = false;
            // 
            // txtUpdateDefine
            // 
            txtUpdateDefine.AccessibleName = "GroupBox1";
            txtUpdateDefine.Location = new Point(141, 57);
            txtUpdateDefine.Name = "txtUpdateDefine";
            txtUpdateDefine.Size = new Size(143, 27);
            txtUpdateDefine.TabIndex = 11;
            txtUpdateDefine.Visible = false;
            // 
            // txtupdateYear
            // 
            txtupdateYear.AccessibleName = "GroupBox1";
            txtupdateYear.Location = new Point(111, 115);
            txtupdateYear.Name = "txtupdateYear";
            txtupdateYear.Size = new Size(173, 27);
            txtupdateYear.TabIndex = 12;
            txtupdateYear.Visible = false;
            // 
            // lblUpdateYear
            // 
            lblUpdateYear.AccessibleName = "GroupBox1";
            lblUpdateYear.Font = new Font("Segoe UI", 9F);
            lblUpdateYear.Location = new Point(0, 90);
            lblUpdateYear.Name = "lblUpdateYear";
            lblUpdateYear.Size = new Size(166, 22);
            lblUpdateYear.TabIndex = 14;
            lblUpdateYear.Text = "Trending Topic or Year :";
            lblUpdateYear.Visible = false;
            // 
            // lblUpdateWord
            // 
            lblUpdateWord.AccessibleName = "GroupBox1";
            lblUpdateWord.Font = new Font("Segoe UI", 8.25F);
            lblUpdateWord.Location = new Point(0, 25);
            lblUpdateWord.Name = "lblUpdateWord";
            lblUpdateWord.Size = new Size(142, 26);
            lblUpdateWord.TabIndex = 15;
            lblUpdateWord.Text = "UPDATE YOUR Word:";
            lblUpdateWord.Visible = false;
            // 
            // lblUpdateDefine
            // 
            lblUpdateDefine.AccessibleName = "GroupBox1";
            lblUpdateDefine.Font = new Font("Segoe UI", 8.25F);
            lblUpdateDefine.Location = new Point(6, 52);
            lblUpdateDefine.Name = "lblUpdateDefine";
            lblUpdateDefine.Size = new Size(88, 32);
            lblUpdateDefine.TabIndex = 16;
            lblUpdateDefine.Text = "Definition:";
            lblUpdateDefine.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(11, 133);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 43);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(lblUpdateDefine);
            groupBox1.Controls.Add(lblUpdateWord);
            groupBox1.Controls.Add(lblUpdateYear);
            groupBox1.Controls.Add(txtupdateYear);
            groupBox1.Controls.Add(txtUpdateDefine);
            groupBox1.Controls.Add(txtUpdateWord);
            groupBox1.Location = new Point(497, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 210);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "UPDATE DEFINITION : ";
            groupBox1.Visible = false;
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Segoe UI", 12F);
            lblDisplay.Location = new Point(347, 69);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(450, 61);
            lblDisplay.TabIndex = 3;
            lblDisplay.Text = "_";
            // 
            // lblDisplay2
            // 
            lblDisplay2.Location = new Point(331, 141);
            lblDisplay2.Name = "lblDisplay2";
            lblDisplay2.Size = new Size(457, 42);
            lblDisplay2.TabIndex = 13;
            lblDisplay2.Text = "_";
            // 
            // button1
            // 
            button1.Location = new Point(216, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 63);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBoxdelete
            // 
            groupBoxdelete.Controls.Add(lblSure);
            groupBoxdelete.Controls.Add(btnDelete);
            groupBoxdelete.Controls.Add(lblAreuSure);
            groupBoxdelete.Location = new Point(10, 14);
            groupBoxdelete.Name = "groupBoxdelete";
            groupBoxdelete.Size = new Size(189, 169);
            groupBoxdelete.TabIndex = 15;
            groupBoxdelete.TabStop = false;
            groupBoxdelete.Text = "Would you Like to Delete?";
            groupBoxdelete.Visible = false;
            // 
            // lblSure
            // 
            lblSure.Font = new Font("Segoe UI", 8.25F);
            lblSure.Location = new Point(0, 55);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(142, 46);
            lblSure.TabIndex = 2;
            lblSure.Text = "ARE YOU SURE You Want To Delete?";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(95, 104);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 59);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblAreuSure
            // 
            lblAreuSure.AutoSize = true;
            lblAreuSure.Location = new Point(6, 55);
            lblAreuSure.Name = "lblAreuSure";
            lblAreuSure.Size = new Size(0, 20);
            lblAreuSure.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxdelete);
            Controls.Add(button1);
            Controls.Add(lblDisplay2);
            Controls.Add(groupBox1);
            Controls.Add(btnADD);
            Controls.Add(lblyear);
            Controls.Add(lbldefinition);
            Controls.Add(lblName);
            Controls.Add(txtYear);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblDisplay);
            Controls.Add(txtBoxDefine);
            Controls.Add(lblPrompt);
            Name = "Form1";
            Text = "FlashCards";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxdelete.ResumeLayout(false);
            groupBoxdelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDescription;
        private TextBox txtYear;
        private Label lblName;
        private Label lbldefinition;
        private Label lblyear;
        private Button btnADD;
        private Label lblPrompt;
        private TextBox txtBoxDefine;
        private TextBox txtName;
        private TextBox txtUpdateWord;
        private TextBox txtUpdateDefine;
        private TextBox txtupdateYear;
        private Label lblUpdateYear;
        private Label lblUpdateWord;
        private Label lblUpdateDefine;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private Label lblDisplay;
        private Label lblDisplay2;
        private Button button1;
        private GroupBox groupBoxdelete;
        private Button btnDelete;
        private Label lblAreuSure;
        private Label lblSure;
    }
}
