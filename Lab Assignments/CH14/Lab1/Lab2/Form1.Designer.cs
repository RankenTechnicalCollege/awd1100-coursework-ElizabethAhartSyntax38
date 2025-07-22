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
            RADIOFRAMFRAME = new RadioButton();
            radioFrameMatt = new RadioButton();
            radioFrameUn = new RadioButton();
            grpColor = new GroupBox();
            radioWhite = new RadioButton();
            radioBlue = new RadioButton();
            radioGreen = new RadioButton();
            radioRed = new RadioButton();
            radioBlack = new RadioButton();
            grpMaterial = new GroupBox();
            radioMatGold = new RadioButton();
            radioMatSilver = new RadioButton();
            radioMatSteel = new RadioButton();
            radioMatOak = new RadioButton();
            radioMatPine = new RadioButton();
            grpStyle = new GroupBox();
            radioStyELectic = new RadioButton();
            radioStyVintage = new RadioButton();
            radioStyAntique = new RadioButton();
            radioStyMod = new RadioButton();
            radioStySimple = new RadioButton();
            btnCalculate = new Button();
            lblDisplay = new Label();
            grpBxFrame.SuspendLayout();
            grpColor.SuspendLayout();
            grpMaterial.SuspendLayout();
            grpStyle.SuspendLayout();
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
            grpBxFrame.Controls.Add(RADIOFRAMFRAME);
            grpBxFrame.Controls.Add(radioFrameMatt);
            grpBxFrame.Controls.Add(radioFrameUn);
            grpBxFrame.Font = new Font("Segoe UI", 11F);
            grpBxFrame.Location = new Point(12, 101);
            grpBxFrame.Name = "grpBxFrame";
            grpBxFrame.Size = new Size(221, 124);
            grpBxFrame.TabIndex = 4;
            grpBxFrame.TabStop = false;
            grpBxFrame.Text = "FRAME YOUR PHOTO";
            // 
            // RADIOFRAMFRAME
            // 
            RADIOFRAMFRAME.AutoSize = true;
            RADIOFRAMFRAME.Location = new Point(6, 85);
            RADIOFRAMFRAME.Name = "RADIOFRAMFRAME";
            RADIOFRAMFRAME.Size = new Size(105, 29);
            RADIOFRAMFRAME.TabIndex = 11;
            RADIOFRAMFRAME.Text = "FRAMED";
            RADIOFRAMFRAME.UseVisualStyleBackColor = true;
            RADIOFRAMFRAME.CheckedChanged += RADIOFRAMFRAME_CheckedChanged;
            // 
            // radioFrameMatt
            // 
            radioFrameMatt.AutoSize = true;
            radioFrameMatt.Location = new Point(6, 50);
            radioFrameMatt.Name = "radioFrameMatt";
            radioFrameMatt.Size = new Size(93, 29);
            radioFrameMatt.TabIndex = 11;
            radioFrameMatt.Text = "Matted";
            radioFrameMatt.UseVisualStyleBackColor = true;
            radioFrameMatt.CheckedChanged += radioFrameMatt_CheckedChanged;
            // 
            // radioFrameUn
            // 
            radioFrameUn.AutoSize = true;
            radioFrameUn.Checked = true;
            radioFrameUn.Location = new Point(6, 24);
            radioFrameUn.Name = "radioFrameUn";
            radioFrameUn.Size = new Size(132, 29);
            radioFrameUn.TabIndex = 11;
            radioFrameUn.TabStop = true;
            radioFrameUn.Text = "UNFRAMED";
            radioFrameUn.UseVisualStyleBackColor = true;
            radioFrameUn.CheckedChanged += radioFrameUn_CheckedChanged;
            // 
            // grpColor
            // 
            grpColor.Controls.Add(radioWhite);
            grpColor.Controls.Add(radioBlue);
            grpColor.Controls.Add(radioGreen);
            grpColor.Controls.Add(radioRed);
            grpColor.Controls.Add(radioBlack);
            grpColor.Font = new Font("Segoe UI", 11F);
            grpColor.Location = new Point(18, 260);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(133, 193);
            grpColor.TabIndex = 5;
            grpColor.TabStop = false;
            grpColor.Text = "COLOR";
            grpColor.Visible = false;
            // 
            // radioWhite
            // 
            radioWhite.AutoSize = true;
            radioWhite.Location = new Point(6, 137);
            radioWhite.Name = "radioWhite";
            radioWhite.Size = new Size(83, 29);
            radioWhite.TabIndex = 11;
            radioWhite.Text = "White";
            radioWhite.UseVisualStyleBackColor = true;
            // 
            // radioBlue
            // 
            radioBlue.AutoSize = true;
            radioBlue.ForeColor = System.Drawing.Color.CornflowerBlue;
            radioBlue.Location = new Point(6, 102);
            radioBlue.Name = "radioBlue";
            radioBlue.Size = new Size(76, 29);
            radioBlue.TabIndex = 13;
            radioBlue.Text = "BLUE";
            radioBlue.UseVisualStyleBackColor = true;
            // 
            // radioGreen
            // 
            radioGreen.AutoSize = true;
            radioGreen.ForeColor = System.Drawing.Color.Green;
            radioGreen.Location = new Point(6, 79);
            radioGreen.Name = "radioGreen";
            radioGreen.Size = new Size(84, 29);
            radioGreen.TabIndex = 12;
            radioGreen.Text = "Green";
            radioGreen.UseVisualStyleBackColor = true;
            // 
            // radioRed
            // 
            radioRed.AutoSize = true;
            radioRed.ForeColor = System.Drawing.Color.Red;
            radioRed.Location = new Point(6, 49);
            radioRed.Name = "radioRed";
            radioRed.Size = new Size(67, 29);
            radioRed.TabIndex = 11;
            radioRed.Text = "RED";
            radioRed.UseVisualStyleBackColor = true;
            // 
            // radioBlack
            // 
            radioBlack.AutoSize = true;
            radioBlack.Checked = true;
            radioBlack.Location = new Point(6, 23);
            radioBlack.Name = "radioBlack";
            radioBlack.Size = new Size(77, 29);
            radioBlack.TabIndex = 10;
            radioBlack.TabStop = true;
            radioBlack.Text = "Black";
            radioBlack.UseVisualStyleBackColor = true;
            // 
            // grpMaterial
            // 
            grpMaterial.Controls.Add(radioMatGold);
            grpMaterial.Controls.Add(radioMatSilver);
            grpMaterial.Controls.Add(radioMatSteel);
            grpMaterial.Controls.Add(radioMatOak);
            grpMaterial.Controls.Add(radioMatPine);
            grpMaterial.Font = new Font("Segoe UI", 11F);
            grpMaterial.Location = new Point(179, 260);
            grpMaterial.Name = "grpMaterial";
            grpMaterial.Size = new Size(133, 193);
            grpMaterial.TabIndex = 6;
            grpMaterial.TabStop = false;
            grpMaterial.Text = "MATERIAL";
            grpMaterial.Visible = false;
            // 
            // radioMatGold
            // 
            radioMatGold.AutoSize = true;
            radioMatGold.ForeColor = System.Drawing.Color.Gold;
            radioMatGold.Location = new Point(6, 141);
            radioMatGold.Name = "radioMatGold";
            radioMatGold.Size = new Size(82, 29);
            radioMatGold.TabIndex = 11;
            radioMatGold.Text = "GOLD";
            radioMatGold.UseVisualStyleBackColor = true;
            // 
            // radioMatSilver
            // 
            radioMatSilver.AutoSize = true;
            radioMatSilver.ForeColor = System.Drawing.Color.CornflowerBlue;
            radioMatSilver.Location = new Point(6, 103);
            radioMatSilver.Name = "radioMatSilver";
            radioMatSilver.Size = new Size(79, 29);
            radioMatSilver.TabIndex = 11;
            radioMatSilver.Text = "SIlver";
            radioMatSilver.UseVisualStyleBackColor = true;
            // 
            // radioMatSteel
            // 
            radioMatSteel.AutoSize = true;
            radioMatSteel.Location = new Point(6, 79);
            radioMatSteel.Name = "radioMatSteel";
            radioMatSteel.Size = new Size(82, 29);
            radioMatSteel.TabIndex = 11;
            radioMatSteel.Text = "STEEL";
            radioMatSteel.UseVisualStyleBackColor = true;
            // 
            // radioMatOak
            // 
            radioMatOak.AutoSize = true;
            radioMatOak.Location = new Point(6, 49);
            radioMatOak.Name = "radioMatOak";
            radioMatOak.Size = new Size(70, 29);
            radioMatOak.TabIndex = 11;
            radioMatOak.Text = "OAK";
            radioMatOak.UseVisualStyleBackColor = true;
            // 
            // radioMatPine
            // 
            radioMatPine.AutoSize = true;
            radioMatPine.Checked = true;
            radioMatPine.ForeColor = System.Drawing.Color.Blue;
            radioMatPine.Location = new Point(6, 23);
            radioMatPine.Name = "radioMatPine";
            radioMatPine.Size = new Size(73, 29);
            radioMatPine.TabIndex = 11;
            radioMatPine.TabStop = true;
            radioMatPine.Text = "PINE";
            radioMatPine.UseVisualStyleBackColor = true;
            // 
            // grpStyle
            // 
            grpStyle.Controls.Add(radioStyELectic);
            grpStyle.Controls.Add(radioStyVintage);
            grpStyle.Controls.Add(radioStyAntique);
            grpStyle.Controls.Add(radioStyMod);
            grpStyle.Controls.Add(radioStySimple);
            grpStyle.Font = new Font("Segoe UI", 11F);
            grpStyle.Location = new Point(332, 260);
            grpStyle.Name = "grpStyle";
            grpStyle.Size = new Size(133, 193);
            grpStyle.TabIndex = 7;
            grpStyle.TabStop = false;
            grpStyle.Text = "STYLE";
            grpStyle.Visible = false;
            // 
            // radioStyELectic
            // 
            radioStyELectic.AutoSize = true;
            radioStyELectic.ForeColor = System.Drawing.Color.Green;
            radioStyELectic.Location = new Point(6, 137);
            radioStyELectic.Name = "radioStyELectic";
            radioStyELectic.Size = new Size(112, 29);
            radioStyELectic.TabIndex = 14;
            radioStyELectic.Text = "ELECTRIC";
            radioStyELectic.UseVisualStyleBackColor = true;
            // 
            // radioStyVintage
            // 
            radioStyVintage.AutoSize = true;
            radioStyVintage.ForeColor = SystemColors.HotTrack;
            radioStyVintage.Location = new Point(6, 103);
            radioStyVintage.Name = "radioStyVintage";
            radioStyVintage.Size = new Size(108, 29);
            radioStyVintage.TabIndex = 13;
            radioStyVintage.Text = "VINTAGE";
            radioStyVintage.UseVisualStyleBackColor = true;
            // 
            // radioStyAntique
            // 
            radioStyAntique.AutoSize = true;
            radioStyAntique.Location = new Point(6, 79);
            radioStyAntique.Name = "radioStyAntique";
            radioStyAntique.Size = new Size(111, 29);
            radioStyAntique.TabIndex = 12;
            radioStyAntique.Text = "ANTIQUE";
            radioStyAntique.UseVisualStyleBackColor = true;
            // 
            // radioStyMod
            // 
            radioStyMod.AutoSize = true;
            radioStyMod.ForeColor = SystemColors.ActiveCaption;
            radioStyMod.Location = new Point(6, 49);
            radioStyMod.Name = "radioStyMod";
            radioStyMod.Size = new Size(112, 29);
            radioStyMod.TabIndex = 11;
            radioStyMod.Text = "MODERN";
            radioStyMod.UseVisualStyleBackColor = true;
            // 
            // radioStySimple
            // 
            radioStySimple.AutoSize = true;
            radioStySimple.Checked = true;
            radioStySimple.Location = new Point(6, 20);
            radioStySimple.Name = "radioStySimple";
            radioStySimple.Size = new Size(95, 29);
            radioStySimple.TabIndex = 11;
            radioStySimple.TabStop = true;
            radioStySimple.Text = "SIMPLE";
            radioStySimple.UseVisualStyleBackColor = true;
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
            lblDisplay.Location = new Point(568, 26);
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
            Controls.Add(grpStyle);
            Controls.Add(grpMaterial);
            Controls.Add(grpColor);
            Controls.Add(grpBxFrame);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            Name = "Form1";
            Text = "PHOTO SHOP";
            grpBxFrame.ResumeLayout(false);
            grpBxFrame.PerformLayout();
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            grpMaterial.ResumeLayout(false);
            grpMaterial.PerformLayout();
            grpStyle.ResumeLayout(false);
            grpStyle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWidth;
        private Label lblHeight;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private GroupBox grpBxFrame;
        private GroupBox grpColor;
        private GroupBox grpMaterial;
        private GroupBox grpStyle;
        private Button btnCalculate;
        private Label lblDisplay;
        private RadioButton radioGreen;
        private RadioButton radioRed;
        private RadioButton radioBlack;
        private RadioButton radioWhite;
        private RadioButton radioBlue;
        private RadioButton radioMatGold;
        private RadioButton radioMatSilver;
        private RadioButton radioMatSteel;
        private RadioButton radioMatOak;
        private RadioButton radioMatPine;
        private RadioButton radioStySimple;
        private RadioButton radioStyELectic;
        private RadioButton radioStyVintage;
        private RadioButton radioStyAntique;
        private RadioButton radioStyMod;
        private RadioButton RADIOFRAMFRAME;
        private RadioButton radioFrameMatt;
        private RadioButton radioFrameUn;
    }
}
