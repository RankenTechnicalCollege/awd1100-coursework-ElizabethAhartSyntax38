namespace CH10_LAB1_SUPERHERODATABASE
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
            cmbSuperHero = new ComboBox();
            lblSuper = new Label();
            lblPromptSuperHero = new Label();
            pcBoxIron_MAN = new PictureBox();
            pcBoxSUPERMAN = new PictureBox();
            pcBoxBATMAN = new PictureBox();
            pcBoxSPIDERMAN = new PictureBox();
            pcBoxINCREDIBLE = new PictureBox();
            btnSearch = new Button();
            lblDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)pcBoxIron_MAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxSUPERMAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxBATMAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxSPIDERMAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxINCREDIBLE).BeginInit();
            SuspendLayout();
            // 
            // cmbSuperHero
            // 
            cmbSuperHero.FormattingEnabled = true;
            cmbSuperHero.Location = new Point(12, 75);
            cmbSuperHero.Name = "cmbSuperHero";
            cmbSuperHero.Size = new Size(239, 28);
            cmbSuperHero.TabIndex = 0;
            // 
            // lblSuper
            // 
            lblSuper.AutoSize = true;
            lblSuper.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuper.Location = new Point(12, 9);
            lblSuper.Name = "lblSuper";
            lblSuper.Size = new Size(256, 26);
            lblSuper.TabIndex = 1;
            lblSuper.Text = "SUPERHERO DICTIONARY";
            // 
            // lblPromptSuperHero
            // 
            lblPromptSuperHero.AutoSize = true;
            lblPromptSuperHero.Location = new Point(39, 52);
            lblPromptSuperHero.Name = "lblPromptSuperHero";
            lblPromptSuperHero.Size = new Size(173, 20);
            lblPromptSuperHero.TabIndex = 2;
            lblPromptSuperHero.Text = "CHOOSE A SUPER_HERO";
            // 
            // pcBoxIron_MAN
            // 
            pcBoxIron_MAN.BackColor = SystemColors.ActiveCaption;
            pcBoxIron_MAN.Image = (Image)resources.GetObject("pcBoxIron_MAN.Image");
            pcBoxIron_MAN.Location = new Point(339, 9);
            pcBoxIron_MAN.Name = "pcBoxIron_MAN";
            pcBoxIron_MAN.Size = new Size(428, 418);
            pcBoxIron_MAN.SizeMode = PictureBoxSizeMode.Zoom;
            pcBoxIron_MAN.TabIndex = 3;
            pcBoxIron_MAN.TabStop = false;
            // 
            // pcBoxSUPERMAN
            // 
            pcBoxSUPERMAN.BackColor = SystemColors.ButtonShadow;
            pcBoxSUPERMAN.Image = (Image)resources.GetObject("pcBoxSUPERMAN.Image");
            pcBoxSUPERMAN.Location = new Point(358, 9);
            pcBoxSUPERMAN.Name = "pcBoxSUPERMAN";
            pcBoxSUPERMAN.Size = new Size(187, 228);
            pcBoxSUPERMAN.TabIndex = 4;
            pcBoxSUPERMAN.TabStop = false;
            // 
            // pcBoxBATMAN
            // 
            pcBoxBATMAN.BackColor = SystemColors.ActiveCaptionText;
            pcBoxBATMAN.Image = (Image)resources.GetObject("pcBoxBATMAN.Image");
            pcBoxBATMAN.Location = new Point(551, 9);
            pcBoxBATMAN.Name = "pcBoxBATMAN";
            pcBoxBATMAN.Size = new Size(202, 237);
            pcBoxBATMAN.SizeMode = PictureBoxSizeMode.Zoom;
            pcBoxBATMAN.TabIndex = 5;
            pcBoxBATMAN.TabStop = false;
            // 
            // pcBoxSPIDERMAN
            // 
            pcBoxSPIDERMAN.BackColor = SystemColors.ActiveCaptionText;
            pcBoxSPIDERMAN.Image = (Image)resources.GetObject("pcBoxSPIDERMAN.Image");
            pcBoxSPIDERMAN.Location = new Point(368, 215);
            pcBoxSPIDERMAN.Name = "pcBoxSPIDERMAN";
            pcBoxSPIDERMAN.Size = new Size(203, 212);
            pcBoxSPIDERMAN.SizeMode = PictureBoxSizeMode.Zoom;
            pcBoxSPIDERMAN.TabIndex = 6;
            pcBoxSPIDERMAN.TabStop = false;
            // 
            // pcBoxINCREDIBLE
            // 
            pcBoxINCREDIBLE.BackColor = Color.OliveDrab;
            pcBoxINCREDIBLE.Image = (Image)resources.GetObject("pcBoxINCREDIBLE.Image");
            pcBoxINCREDIBLE.Location = new Point(414, 140);
            pcBoxINCREDIBLE.Name = "pcBoxINCREDIBLE";
            pcBoxINCREDIBLE.Size = new Size(339, 251);
            pcBoxINCREDIBLE.SizeMode = PictureBoxSizeMode.Zoom;
            pcBoxINCREDIBLE.TabIndex = 7;
            pcBoxINCREDIBLE.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(39, 119);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(156, 79);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDisplay.ForeColor = Color.Black;
            lblDisplay.Location = new Point(12, 209);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(306, 232);
            lblDisplay.TabIndex = 9;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnSearch);
            Controls.Add(pcBoxINCREDIBLE);
            Controls.Add(pcBoxSPIDERMAN);
            Controls.Add(pcBoxBATMAN);
            Controls.Add(pcBoxSUPERMAN);
            Controls.Add(pcBoxIron_MAN);
            Controls.Add(lblPromptSuperHero);
            Controls.Add(lblSuper);
            Controls.Add(cmbSuperHero);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pcBoxIron_MAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxSUPERMAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxBATMAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxSPIDERMAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxINCREDIBLE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSuperHero;
        private Label lblSuper;
        private Label lblPromptSuperHero;
        private PictureBox pcBoxIron_MAN;
        private PictureBox pcBoxSUPERMAN;
        private PictureBox pcBoxBATMAN;
        private PictureBox pcBoxSPIDERMAN;
        private PictureBox pcBoxINCREDIBLE;
        private Button btnSearch;
        private Label lblDisplay;
    }
}
