namespace Lab2
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
            lblWidth = new Label();
            lblHeight = new Label();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            grpBxFrame = new GroupBox();
            chkUnFramed = new CheckBox();
            chkMatted = new CheckBox();
            chkFramed = new CheckBox();
            groupBox1 = new GroupBox();
            chkGreen = new CheckBox();
            chkRed = new CheckBox();
            chkBlack = new CheckBox();
            chkWhite = new CheckBox();
            chkBlue = new CheckBox();
            grpMaterial = new GroupBox();
            chkSilver = new CheckBox();
            chkGold = new CheckBox();
            chkSteel = new CheckBox();
            chkOak = new CheckBox();
            chkPine = new CheckBox();
            groupBox2 = new GroupBox();
            chkVintage = new CheckBox();
            chkElectric = new CheckBox();
            chkAntique = new CheckBox();
            chkModern = new CheckBox();
            chkSimple = new CheckBox();
            btnCalculate = new Button();
            lblDisplay = new Label();
            grpBxFrame.SuspendLayout();
            groupBox1.SuspendLayout();
            grpMaterial.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(0, 9);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(56, 20);
            lblWidth.TabIndex = 0;
            lblWidth.Text = "WIDTH";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(0, 44);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(61, 20);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "HEIGHT";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(74, 6);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 2;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(74, 39);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 3;
            // 
            // grpBxFrame
            // 
            grpBxFrame.Controls.Add(chkFramed);
            grpBxFrame.Controls.Add(chkMatted);
            grpBxFrame.Controls.Add(chkUnFramed);
            grpBxFrame.Font = new Font("Segoe UI", 11F);
            grpBxFrame.Location = new Point(12, 101);
            grpBxFrame.Name = "grpBxFrame";
            grpBxFrame.Size = new Size(221, 124);
            grpBxFrame.TabIndex = 4;
            grpBxFrame.TabStop = false;
            grpBxFrame.Text = "FRAME YOUR PHOTO";
            // 
            // chkUnFramed
            // 
            chkUnFramed.AutoSize = true;
            chkUnFramed.Location = new Point(6, 20);
            chkUnFramed.Name = "chkUnFramed";
            chkUnFramed.Size = new Size(133, 29);
            chkUnFramed.TabIndex = 0;
            chkUnFramed.Text = "UNFRAMED";
            chkUnFramed.UseVisualStyleBackColor = true;
            // 
            // chkMatted
            // 
            chkMatted.AutoSize = true;
            chkMatted.ForeColor = Color.Brown;
            chkMatted.Location = new Point(6, 50);
            chkMatted.Name = "chkMatted";
            chkMatted.Size = new Size(105, 29);
            chkMatted.TabIndex = 1;
            chkMatted.Text = "MATTED";
            chkMatted.UseVisualStyleBackColor = true;
            // 
            // chkFramed
            // 
            chkFramed.AutoSize = true;
            chkFramed.ForeColor = Color.Blue;
            chkFramed.Location = new Point(6, 80);
            chkFramed.Name = "chkFramed";
            chkFramed.Size = new Size(106, 29);
            chkFramed.TabIndex = 2;
            chkFramed.Text = "FRAMED";
            chkFramed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkBlue);
            groupBox1.Controls.Add(chkWhite);
            groupBox1.Controls.Add(chkGreen);
            groupBox1.Controls.Add(chkRed);
            groupBox1.Controls.Add(chkBlack);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(18, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 193);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "COLOR";
            groupBox1.Visible = false;
            // 
            // chkGreen
            // 
            chkGreen.AutoSize = true;
            chkGreen.ForeColor = Color.Green;
            chkGreen.Location = new Point(6, 80);
            chkGreen.Name = "chkGreen";
            chkGreen.Size = new Size(92, 29);
            chkGreen.TabIndex = 2;
            chkGreen.Text = "GREEN";
            chkGreen.UseVisualStyleBackColor = true;
            // 
            // chkRed
            // 
            chkRed.AutoSize = true;
            chkRed.ForeColor = Color.Red;
            chkRed.Location = new Point(6, 50);
            chkRed.Name = "chkRed";
            chkRed.Size = new Size(68, 29);
            chkRed.TabIndex = 1;
            chkRed.Text = "RED";
            chkRed.UseVisualStyleBackColor = true;
            // 
            // chkBlack
            // 
            chkBlack.AutoSize = true;
            chkBlack.Location = new Point(6, 20);
            chkBlack.Name = "chkBlack";
            chkBlack.Size = new Size(90, 29);
            chkBlack.TabIndex = 0;
            chkBlack.Text = "BLACK";
            chkBlack.UseVisualStyleBackColor = true;
            // 
            // chkWhite
            // 
            chkWhite.AutoSize = true;
            chkWhite.ForeColor = Color.DarkTurquoise;
            chkWhite.Location = new Point(6, 129);
            chkWhite.Name = "chkWhite";
            chkWhite.Size = new Size(90, 29);
            chkWhite.TabIndex = 3;
            chkWhite.Text = "WHITE";
            chkWhite.UseVisualStyleBackColor = true;
            // 
            // chkBlue
            // 
            chkBlue.AutoSize = true;
            chkBlue.ForeColor = Color.Blue;
            chkBlue.Location = new Point(6, 104);
            chkBlue.Name = "chkBlue";
            chkBlue.Size = new Size(77, 29);
            chkBlue.TabIndex = 4;
            chkBlue.Text = "BLUE";
            chkBlue.UseVisualStyleBackColor = true;
            // 
            // grpMaterial
            // 
            grpMaterial.Controls.Add(chkSilver);
            grpMaterial.Controls.Add(chkGold);
            grpMaterial.Controls.Add(chkSteel);
            grpMaterial.Controls.Add(chkOak);
            grpMaterial.Controls.Add(chkPine);
            grpMaterial.Font = new Font("Segoe UI", 11F);
            grpMaterial.Location = new Point(179, 260);
            grpMaterial.Name = "grpMaterial";
            grpMaterial.Size = new Size(133, 193);
            grpMaterial.TabIndex = 6;
            grpMaterial.TabStop = false;
            grpMaterial.Text = "MATERIAL";
            grpMaterial.Visible = false;
            // 
            // chkSilver
            // 
            chkSilver.AutoSize = true;
            chkSilver.ForeColor = Color.Blue;
            chkSilver.Location = new Point(6, 103);
            chkSilver.Name = "chkSilver";
            chkSilver.Size = new Size(90, 29);
            chkSilver.TabIndex = 4;
            chkSilver.Text = "SILVER";
            chkSilver.UseVisualStyleBackColor = true;
            // 
            // chkGold
            // 
            chkGold.AutoSize = true;
            chkGold.ForeColor = Color.Gold;
            chkGold.Location = new Point(6, 129);
            chkGold.Name = "chkGold";
            chkGold.Size = new Size(83, 29);
            chkGold.TabIndex = 3;
            chkGold.Text = "GOLD";
            chkGold.UseVisualStyleBackColor = true;
            // 
            // chkSteel
            // 
            chkSteel.AutoSize = true;
            chkSteel.ForeColor = Color.Black;
            chkSteel.Location = new Point(6, 80);
            chkSteel.Name = "chkSteel";
            chkSteel.Size = new Size(83, 29);
            chkSteel.TabIndex = 2;
            chkSteel.Text = "STEEL";
            chkSteel.UseVisualStyleBackColor = true;
            // 
            // chkOak
            // 
            chkOak.AutoSize = true;
            chkOak.ForeColor = Color.Brown;
            chkOak.Location = new Point(6, 50);
            chkOak.Name = "chkOak";
            chkOak.Size = new Size(71, 29);
            chkOak.TabIndex = 1;
            chkOak.Text = "OAK";
            chkOak.UseVisualStyleBackColor = true;
            // 
            // chkPine
            // 
            chkPine.AutoSize = true;
            chkPine.ForeColor = SystemColors.ControlDarkDark;
            chkPine.Location = new Point(6, 20);
            chkPine.Name = "chkPine";
            chkPine.Size = new Size(74, 29);
            chkPine.TabIndex = 0;
            chkPine.Text = "PINE";
            chkPine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkVintage);
            groupBox2.Controls.Add(chkElectric);
            groupBox2.Controls.Add(chkAntique);
            groupBox2.Controls.Add(chkModern);
            groupBox2.Controls.Add(chkSimple);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(332, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(133, 193);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "STYLE";
            groupBox2.Visible = false;
            // 
            // chkVintage
            // 
            chkVintage.AutoSize = true;
            chkVintage.ForeColor = Color.Blue;
            chkVintage.Location = new Point(6, 103);
            chkVintage.Name = "chkVintage";
            chkVintage.Size = new Size(109, 29);
            chkVintage.TabIndex = 4;
            chkVintage.Text = "VINTAGE";
            chkVintage.UseVisualStyleBackColor = true;
            // 
            // chkElectric
            // 
            chkElectric.AutoSize = true;
            chkElectric.ForeColor = Color.DodgerBlue;
            chkElectric.Location = new Point(6, 129);
            chkElectric.Name = "chkElectric";
            chkElectric.Size = new Size(113, 29);
            chkElectric.TabIndex = 3;
            chkElectric.Text = "ELECTRIC";
            chkElectric.UseVisualStyleBackColor = true;
            // 
            // chkAntique
            // 
            chkAntique.AutoSize = true;
            chkAntique.ForeColor = Color.Black;
            chkAntique.Location = new Point(6, 80);
            chkAntique.Name = "chkAntique";
            chkAntique.Size = new Size(112, 29);
            chkAntique.TabIndex = 2;
            chkAntique.Text = "ANTIQUE";
            chkAntique.UseVisualStyleBackColor = true;
            // 
            // chkModern
            // 
            chkModern.AutoSize = true;
            chkModern.ForeColor = Color.DarkSlateGray;
            chkModern.Location = new Point(6, 50);
            chkModern.Name = "chkModern";
            chkModern.Size = new Size(113, 29);
            chkModern.TabIndex = 1;
            chkModern.Text = "MODERN";
            chkModern.UseVisualStyleBackColor = true;
            // 
            // chkSimple
            // 
            chkSimple.AutoSize = true;
            chkSimple.ForeColor = SystemColors.Highlight;
            chkSimple.Location = new Point(6, 20);
            chkSimple.Name = "chkSimple";
            chkSimple.Size = new Size(96, 29);
            chkSimple.TabIndex = 0;
            chkSimple.Text = "SIMPLE";
            chkSimple.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(374, 26);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 128);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.Location = new Point(581, 26);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(207, 313);
            lblDisplay.TabIndex = 9;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(grpMaterial);
            Controls.Add(groupBox1);
            Controls.Add(grpBxFrame);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            Name = "Form1";
            Text = "PHOTO SHOP";
            grpBxFrame.ResumeLayout(false);
            grpBxFrame.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpMaterial.ResumeLayout(false);
            grpMaterial.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWidth;
        private Label lblHeight;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private GroupBox grpBxFrame;
        private CheckBox chkFramed;
        private CheckBox chkMatted;
        private CheckBox chkUnFramed;
        private GroupBox groupBox1;
        private CheckBox chkBlue;
        private CheckBox chkWhite;
        private CheckBox chkGreen;
        private CheckBox chkRed;
        private CheckBox chkBlack;
        private GroupBox grpMaterial;
        private CheckBox chkSilver;
        private CheckBox chkGold;
        private CheckBox chkSteel;
        private CheckBox chkOak;
        private CheckBox chkPine;
        private GroupBox groupBox2;
        private CheckBox chkVintage;
        private CheckBox chkElectric;
        private CheckBox chkAntique;
        private CheckBox chkModern;
        private CheckBox chkSimple;
        private Button btnCalculate;
        private Label lblDisplay;
    }
}
