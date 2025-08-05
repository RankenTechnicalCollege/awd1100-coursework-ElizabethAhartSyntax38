namespace hot10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pcBoxFlower = new PictureBox();
            pcBoxHearts = new PictureBox();
            lblDisplayHearts = new Label();
            lblDisplayFlowers = new Label();
            cmbBoxOcc = new ComboBox();
            lblPromptOccasion = new Label();
            lblPromptStyle = new Label();
            cmbBoxStyle = new ComboBox();
            chckBoxENv = new CheckBox();
            chckBoxStamp = new CheckBox();
            chckBoxMess = new CheckBox();
            rchDisplay = new RichTextBox();
            lblDisplayTotal = new Label();
            btnBuild = new Button();
            ((System.ComponentModel.ISupportInitialize)pcBoxFlower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxHearts).BeginInit();
            SuspendLayout();
            // 
            // pcBoxFlower
            // 
            pcBoxFlower.Image = (Image)resources.GetObject("pcBoxFlower.Image");
            pcBoxFlower.Location = new Point(430, 2);
            pcBoxFlower.Name = "pcBoxFlower";
            pcBoxFlower.Size = new Size(368, 203);
            pcBoxFlower.SizeMode = PictureBoxSizeMode.Zoom;
            pcBoxFlower.TabIndex = 0;
            pcBoxFlower.TabStop = false;
            pcBoxFlower.Visible = false;
            // 
            // pcBoxHearts
            // 
            pcBoxHearts.Image = (Image)resources.GetObject("pcBoxHearts.Image");
            pcBoxHearts.Location = new Point(430, 211);
            pcBoxHearts.Name = "pcBoxHearts";
            pcBoxHearts.Size = new Size(368, 243);
            pcBoxHearts.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBoxHearts.TabIndex = 1;
            pcBoxHearts.TabStop = false;
            pcBoxHearts.Visible = false;
            // 
            // lblDisplayHearts
            // 
            lblDisplayHearts.Font = new Font("Segoe UI", 7.5F);
            lblDisplayHearts.Location = new Point(485, 392);
            lblDisplayHearts.Name = "lblDisplayHearts";
            lblDisplayHearts.Size = new Size(313, 62);
            lblDisplayHearts.TabIndex = 2;
            lblDisplayHearts.Text = "_";
            lblDisplayHearts.Visible = false;
            // 
            // lblDisplayFlowers
            // 
            lblDisplayFlowers.Font = new Font("Segoe UI", 6.5F);
            lblDisplayFlowers.Location = new Point(534, 138);
            lblDisplayFlowers.Name = "lblDisplayFlowers";
            lblDisplayFlowers.Size = new Size(264, 67);
            lblDisplayFlowers.TabIndex = 3;
            lblDisplayFlowers.Text = "_";
            lblDisplayFlowers.Visible = false;
            // 
            // cmbBoxOcc
            // 
            cmbBoxOcc.FormattingEnabled = true;
            cmbBoxOcc.Location = new Point(169, 6);
            cmbBoxOcc.Name = "cmbBoxOcc";
            cmbBoxOcc.Size = new Size(151, 28);
            cmbBoxOcc.Sorted = true;
            cmbBoxOcc.TabIndex = 4;
            // 
            // lblPromptOccasion
            // 
            lblPromptOccasion.AutoSize = true;
            lblPromptOccasion.Font = new Font("Segoe UI", 12F);
            lblPromptOccasion.ForeColor = Color.Red;
            lblPromptOccasion.Location = new Point(1, 2);
            lblPromptOccasion.Name = "lblPromptOccasion";
            lblPromptOccasion.Size = new Size(91, 28);
            lblPromptOccasion.TabIndex = 5;
            lblPromptOccasion.Text = "Occasion";
            // 
            // lblPromptStyle
            // 
            lblPromptStyle.AutoSize = true;
            lblPromptStyle.Font = new Font("Segoe UI", 12F);
            lblPromptStyle.ForeColor = Color.Red;
            lblPromptStyle.Location = new Point(1, 65);
            lblPromptStyle.Name = "lblPromptStyle";
            lblPromptStyle.Size = new Size(54, 28);
            lblPromptStyle.TabIndex = 6;
            lblPromptStyle.Text = "Style";
            // 
            // cmbBoxStyle
            // 
            cmbBoxStyle.FormattingEnabled = true;
            cmbBoxStyle.Location = new Point(169, 65);
            cmbBoxStyle.Name = "cmbBoxStyle";
            cmbBoxStyle.Size = new Size(151, 28);
            cmbBoxStyle.Sorted = true;
            cmbBoxStyle.TabIndex = 7;
            // 
            // chckBoxENv
            // 
            chckBoxENv.AutoSize = true;
            chckBoxENv.ForeColor = SystemColors.HotTrack;
            chckBoxENv.Location = new Point(169, 107);
            chckBoxENv.Name = "chckBoxENv";
            chckBoxENv.Size = new Size(120, 24);
            chckBoxENv.TabIndex = 8;
            chckBoxENv.Text = "ENVELOPE $1";
            chckBoxENv.UseVisualStyleBackColor = true;
            // 
            // chckBoxStamp
            // 
            chckBoxStamp.AutoSize = true;
            chckBoxStamp.ForeColor = SystemColors.HotTrack;
            chckBoxStamp.Location = new Point(169, 156);
            chckBoxStamp.Name = "chckBoxStamp";
            chckBoxStamp.Size = new Size(97, 24);
            chckBoxStamp.TabIndex = 9;
            chckBoxStamp.Text = "STAMP $2";
            chckBoxStamp.UseVisualStyleBackColor = true;
            // 
            // chckBoxMess
            // 
            chckBoxMess.AutoSize = true;
            chckBoxMess.ForeColor = SystemColors.HotTrack;
            chckBoxMess.Location = new Point(169, 201);
            chckBoxMess.Name = "chckBoxMess";
            chckBoxMess.Size = new Size(170, 24);
            chckBoxMess.TabIndex = 10;
            chckBoxMess.Text = "Custom MESSAGE $4";
            chckBoxMess.UseVisualStyleBackColor = true;
            // 
            // rchDisplay
            // 
            rchDisplay.Font = new Font("Harrington", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rchDisplay.ForeColor = SystemColors.HotTrack;
            rchDisplay.Location = new Point(1, 231);
            rchDisplay.Name = "rchDisplay";
            rchDisplay.Size = new Size(351, 104);
            rchDisplay.TabIndex = 11;
            rchDisplay.Text = "";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.Font = new Font("Engravers MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisplayTotal.ForeColor = SystemColors.HotTrack;
            lblDisplayTotal.Location = new Point(123, 372);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(286, 69);
            lblDisplayTotal.TabIndex = 12;
            lblDisplayTotal.Text = "TotalCost";
            // 
            // btnBuild
            // 
            btnBuild.Location = new Point(1, 356);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new Size(116, 84);
            btnBuild.TabIndex = 13;
            btnBuild.Text = "Build";
            btnBuild.UseVisualStyleBackColor = true;
            btnBuild.Click += btnBuild_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuild);
            Controls.Add(lblDisplayTotal);
            Controls.Add(rchDisplay);
            Controls.Add(chckBoxMess);
            Controls.Add(chckBoxStamp);
            Controls.Add(chckBoxENv);
            Controls.Add(cmbBoxStyle);
            Controls.Add(lblPromptStyle);
            Controls.Add(lblPromptOccasion);
            Controls.Add(cmbBoxOcc);
            Controls.Add(lblDisplayFlowers);
            Controls.Add(lblDisplayHearts);
            Controls.Add(pcBoxHearts);
            Controls.Add(pcBoxFlower);
            Name = "Form1";
            Text = "HOLIDAY CARDS";
            ((System.ComponentModel.ISupportInitialize)pcBoxFlower).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxHearts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcBoxFlower;
        private PictureBox pcBoxHearts;
        private Label lblDisplayHearts;
        private Label lblDisplayFlowers;
        private ComboBox cmbBoxOcc;
        private Label lblPromptOccasion;
        private Label lblPromptStyle;
        private ComboBox cmbBoxStyle;
        private CheckBox chckBoxENv;
        private CheckBox chckBoxStamp;
        private CheckBox chckBoxMess;
        private RichTextBox rchDisplay;
        private Label lblDisplayTotal;
        private Button btnBuild;
    }
}
