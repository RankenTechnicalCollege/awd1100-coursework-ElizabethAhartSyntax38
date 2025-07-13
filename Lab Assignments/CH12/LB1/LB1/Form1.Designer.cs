namespace LB1
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
            txtName = new TextBox();
            lblNameError = new Label();
            lblSundae = new Label();
            chkSundae = new CheckBox();
            lblSoda = new Label();
            chkSoda = new CheckBox();
            grpBoxSundae = new GroupBox();
            chkBoxSyrup = new CheckBox();
            chkBoxNuts = new CheckBox();
            chkBoxSprinkles = new CheckBox();
            grpSoda = new GroupBox();
            chkBoxMango = new CheckBox();
            chkBoxPeach = new CheckBox();
            chkboxLime = new CheckBox();
            lblToppingError = new Label();
            lblSodaError = new Label();
            btnAdd = new Button();
            rchTxtBox = new RichTextBox();
            lblTotalprompt = new Label();
            lblDisplayTotal = new Label();
            grpBoxSundae.SuspendLayout();
            grpSoda.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(2, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(199, 20);
            lblName.TabIndex = 0;
            lblName.Text = "What Name On The Order? : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 27);
            txtName.TabIndex = 1;
            // 
            // lblNameError
            // 
            lblNameError.AutoSize = true;
            lblNameError.Font = new Font("Segoe UI", 12F);
            lblNameError.ForeColor = Color.Red;
            lblNameError.Location = new Point(2, 84);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(296, 28);
            lblNameError.TabIndex = 2;
            lblNameError.Text = "Name required / no Food Order ";
            lblNameError.Visible = false;
            // 
            // lblSundae
            // 
            lblSundae.AutoSize = true;
            lblSundae.Location = new Point(2, 135);
            lblSundae.Name = "lblSundae";
            lblSundae.Size = new Size(176, 20);
            lblSundae.TabIndex = 3;
            lblSundae.Text = "Do you want a Sundae? : ";
            // 
            // chkSundae
            // 
            chkSundae.AutoSize = true;
            chkSundae.Location = new Point(14, 167);
            chkSundae.Name = "chkSundae";
            chkSundae.Size = new Size(52, 24);
            chkSundae.TabIndex = 4;
            chkSundae.Text = "Yes";
            chkSundae.UseVisualStyleBackColor = true;
            chkSundae.CheckedChanged += chkSundae_CheckedChanged;
            // 
            // lblSoda
            // 
            lblSoda.AutoSize = true;
            lblSoda.Location = new Point(269, 135);
            lblSoda.Name = "lblSoda";
            lblSoda.Size = new Size(161, 20);
            lblSoda.TabIndex = 5;
            lblSoda.Text = "Do you want a Soda? : ";
            // 
            // chkSoda
            // 
            chkSoda.AutoSize = true;
            chkSoda.Location = new Point(295, 167);
            chkSoda.Name = "chkSoda";
            chkSoda.Size = new Size(52, 24);
            chkSoda.TabIndex = 6;
            chkSoda.Text = "Yes";
            chkSoda.UseVisualStyleBackColor = true;
            chkSoda.CheckedChanged += chkSoda_CheckedChanged;
            // 
            // grpBoxSundae
            // 
            grpBoxSundae.Controls.Add(chkBoxSyrup);
            grpBoxSundae.Controls.Add(chkBoxNuts);
            grpBoxSundae.Controls.Add(chkBoxSprinkles);
            grpBoxSundae.Location = new Point(12, 216);
            grpBoxSundae.Name = "grpBoxSundae";
            grpBoxSundae.Size = new Size(166, 129);
            grpBoxSundae.TabIndex = 7;
            grpBoxSundae.TabStop = false;
            grpBoxSundae.Text = "Sundae Toppings";
            grpBoxSundae.Visible = false;
            // 
            // chkBoxSyrup
            // 
            chkBoxSyrup.AutoSize = true;
            chkBoxSyrup.Location = new Point(6, 89);
            chkBoxSyrup.Name = "chkBoxSyrup";
            chkBoxSyrup.Size = new Size(163, 24);
            chkBoxSyrup.TabIndex = 7;
            chkBoxSyrup.Text = "CHOCOLATE_SYRUP";
            chkBoxSyrup.UseVisualStyleBackColor = true;
            // 
            // chkBoxNuts
            // 
            chkBoxNuts.AutoSize = true;
            chkBoxNuts.Location = new Point(6, 59);
            chkBoxNuts.Name = "chkBoxNuts";
            chkBoxNuts.Size = new Size(68, 24);
            chkBoxNuts.TabIndex = 6;
            chkBoxNuts.Text = "NUTS";
            chkBoxNuts.UseVisualStyleBackColor = true;
            chkBoxNuts.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkBoxSprinkles
            // 
            chkBoxSprinkles.AutoSize = true;
            chkBoxSprinkles.Location = new Point(6, 26);
            chkBoxSprinkles.Name = "chkBoxSprinkles";
            chkBoxSprinkles.Size = new Size(103, 24);
            chkBoxSprinkles.TabIndex = 5;
            chkBoxSprinkles.Text = "SPRINKLES";
            chkBoxSprinkles.UseVisualStyleBackColor = true;
            // 
            // grpSoda
            // 
            grpSoda.Controls.Add(chkBoxMango);
            grpSoda.Controls.Add(chkBoxPeach);
            grpSoda.Controls.Add(chkboxLime);
            grpSoda.Location = new Point(269, 200);
            grpSoda.Name = "grpSoda";
            grpSoda.Size = new Size(124, 129);
            grpSoda.TabIndex = 8;
            grpSoda.TabStop = false;
            grpSoda.Text = "SODA MIXINS";
            grpSoda.Visible = false;
            // 
            // chkBoxMango
            // 
            chkBoxMango.AutoSize = true;
            chkBoxMango.Location = new Point(6, 86);
            chkBoxMango.Name = "chkBoxMango";
            chkBoxMango.Size = new Size(86, 24);
            chkBoxMango.TabIndex = 10;
            chkBoxMango.Text = "MANGO";
            chkBoxMango.UseVisualStyleBackColor = true;
            // 
            // chkBoxPeach
            // 
            chkBoxPeach.AutoSize = true;
            chkBoxPeach.Location = new Point(6, 56);
            chkBoxPeach.Name = "chkBoxPeach";
            chkBoxPeach.Size = new Size(77, 24);
            chkBoxPeach.TabIndex = 9;
            chkBoxPeach.Text = "PEACH";
            chkBoxPeach.UseVisualStyleBackColor = true;
            // 
            // chkboxLime
            // 
            chkboxLime.AutoSize = true;
            chkboxLime.Location = new Point(6, 26);
            chkboxLime.Name = "chkboxLime";
            chkboxLime.Size = new Size(63, 24);
            chkboxLime.TabIndex = 5;
            chkboxLime.Text = "LIME";
            chkboxLime.UseVisualStyleBackColor = true;
            // 
            // lblToppingError
            // 
            lblToppingError.AutoSize = true;
            lblToppingError.Font = new Font("Segoe UI", 12F);
            lblToppingError.ForeColor = Color.Red;
            lblToppingError.Location = new Point(2, 357);
            lblToppingError.Name = "lblToppingError";
            lblToppingError.Size = new Size(263, 28);
            lblToppingError.TabIndex = 9;
            lblToppingError.Text = "Only TWO Toppings Allowed";
            lblToppingError.Visible = false;
            // 
            // lblSodaError
            // 
            lblSodaError.AutoSize = true;
            lblSodaError.Font = new Font("Segoe UI", 12F);
            lblSodaError.ForeColor = Color.Red;
            lblSodaError.Location = new Point(2, 396);
            lblSodaError.Name = "lblSodaError";
            lblSodaError.Size = new Size(230, 28);
            lblSodaError.TabIndex = 10;
            lblSodaError.Text = "Only Two Mixins Allowed";
            lblSodaError.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(275, 342);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 82);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD ITEM";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rchTxtBox
            // 
            rchTxtBox.Location = new Point(527, 23);
            rchTxtBox.Name = "rchTxtBox";
            rchTxtBox.Size = new Size(245, 362);
            rchTxtBox.TabIndex = 12;
            rchTxtBox.Text = "";
            // 
            // lblTotalprompt
            // 
            lblTotalprompt.AutoSize = true;
            lblTotalprompt.Location = new Point(527, 396);
            lblTotalprompt.Name = "lblTotalprompt";
            lblTotalprompt.Size = new Size(109, 20);
            lblTotalprompt.TabIndex = 13;
            lblTotalprompt.Text = "ORDER TOTAL :";
            lblTotalprompt.Visible = false;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(642, 396);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(15, 20);
            lblDisplayTotal.TabIndex = 14;
            lblDisplayTotal.Text = "_";
            lblDisplayTotal.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplayTotal);
            Controls.Add(lblTotalprompt);
            Controls.Add(rchTxtBox);
            Controls.Add(btnAdd);
            Controls.Add(lblSodaError);
            Controls.Add(lblToppingError);
            Controls.Add(grpSoda);
            Controls.Add(grpBoxSundae);
            Controls.Add(chkSoda);
            Controls.Add(lblSoda);
            Controls.Add(chkSundae);
            Controls.Add(lblSundae);
            Controls.Add(lblNameError);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "ORDER Sundae";
            grpBoxSundae.ResumeLayout(false);
            grpBoxSundae.PerformLayout();
            grpSoda.ResumeLayout(false);
            grpSoda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblNameError;
        private Label lblSundae;
        private CheckBox chkSundae;
        private Label lblSoda;
        private CheckBox chkSoda;
        private GroupBox grpBoxSundae;
        private CheckBox chkBoxNuts;
        private CheckBox chkBoxSprinkles;
        private CheckBox chkBoxSyrup;
        private GroupBox grpSoda;
        private CheckBox chkBoxMango;
        private CheckBox chkBoxPeach;
        private CheckBox chkboxLime;
        private Label lblToppingError;
        private Label lblSodaError;
        private Button btnAdd;
        private RichTextBox rchTxtBox;
        private Label lblTotalprompt;
        private Label lblDisplayTotal;
    }
}
