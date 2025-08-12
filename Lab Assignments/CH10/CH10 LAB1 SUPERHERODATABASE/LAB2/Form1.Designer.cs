namespace LAB2
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
            cmbJOBDATA = new ComboBox();
            lstSearchRESULT = new ListBox();
            btnSEARCH = new Button();
            lblPrompt = new Label();
            lblSelectLST = new Label();
            label1 = new Label();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // cmbJOBDATA
            // 
            cmbJOBDATA.BackColor = SystemColors.HotTrack;
            cmbJOBDATA.FormattingEnabled = true;
            cmbJOBDATA.ImeMode = ImeMode.NoControl;
            cmbJOBDATA.Location = new Point(28, 57);
            cmbJOBDATA.Margin = new Padding(4, 3, 4, 3);
            cmbJOBDATA.Name = "cmbJOBDATA";
            cmbJOBDATA.Size = new Size(257, 26);
            cmbJOBDATA.TabIndex = 0;
            // 
            // lstSearchRESULT
            // 
            lstSearchRESULT.Font = new Font("Segoe UI", 7F);
            lstSearchRESULT.ForeColor = SystemColors.MenuHighlight;
            lstSearchRESULT.FormattingEnabled = true;
            lstSearchRESULT.Location = new Point(532, 57);
            lstSearchRESULT.Margin = new Padding(4, 3, 4, 3);
            lstSearchRESULT.Name = "lstSearchRESULT";
            lstSearchRESULT.Size = new Size(396, 229);
            lstSearchRESULT.TabIndex = 1;
            // 
            // btnSEARCH
            // 
            btnSEARCH.Location = new Point(349, 9);
            btnSEARCH.Margin = new Padding(4, 3, 4, 3);
            btnSEARCH.Name = "btnSEARCH";
            btnSEARCH.Size = new Size(142, 64);
            btnSEARCH.TabIndex = 2;
            btnSEARCH.Text = "SEARCH";
            btnSEARCH.UseVisualStyleBackColor = true;
            btnSEARCH.Click += btnSEARCH_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrompt.Location = new Point(15, 9);
            lblPrompt.Margin = new Padding(4, 0, 4, 0);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(303, 25);
            lblPrompt.TabIndex = 3;
            lblPrompt.Text = "WHAT JOBS INTERST YOU?";
            lblPrompt.Click += lblPrompt_Click;
            // 
            // lblSelectLST
            // 
            lblSelectLST.AutoSize = true;
            lblSelectLST.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectLST.Location = new Point(532, 19);
            lblSelectLST.Margin = new Padding(4, 0, 4, 0);
            lblSelectLST.Name = "lblSelectLST";
            lblSelectLST.Size = new Size(292, 26);
            lblSelectLST.TabIndex = 4;
            lblSelectLST.Text = "\"SELECT ALL THAT APPLY!\"";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.Location = new Point(38, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 16);
            label1.TabIndex = 5;
            label1.Text = "SEARCH MULTIPLE JOBS";
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            lblDisplay.Location = new Point(19, 86);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(472, 310);
            lblDisplay.TabIndex = 6;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 405);
            Controls.Add(lblDisplay);
            Controls.Add(label1);
            Controls.Add(lblSelectLST);
            Controls.Add(lblPrompt);
            Controls.Add(btnSEARCH);
            Controls.Add(lstSearchRESULT);
            Controls.Add(cmbJOBDATA);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "SEARCH MULTIPLE JOBS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbJOBDATA;
        private ListBox lstSearchRESULT;
        private Button btnSEARCH;
        private Label lblPrompt;
        private Label lblSelectLST;
        private Label label1;
        private Label lblDisplay;
    }
}
