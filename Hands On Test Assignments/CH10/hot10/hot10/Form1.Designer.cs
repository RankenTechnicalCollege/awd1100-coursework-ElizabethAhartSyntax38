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
            ((System.ComponentModel.ISupportInitialize)pcBoxFlower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxHearts).BeginInit();
            SuspendLayout();
            // 
            // pcBoxFlower
            // 
            pcBoxFlower.Image = (Image)resources.GetObject("pcBoxFlower.Image");
            pcBoxFlower.Location = new Point(473, 2);
            pcBoxFlower.Name = "pcBoxFlower";
            pcBoxFlower.Size = new Size(325, 203);
            pcBoxFlower.SizeMode = PictureBoxSizeMode.Zoom;
            pcBoxFlower.TabIndex = 0;
            pcBoxFlower.TabStop = false;
            // 
            // pcBoxHearts
            // 
            pcBoxHearts.Image = (Image)resources.GetObject("pcBoxHearts.Image");
            pcBoxHearts.Location = new Point(473, 211);
            pcBoxHearts.Name = "pcBoxHearts";
            pcBoxHearts.Size = new Size(325, 243);
            pcBoxHearts.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBoxHearts.TabIndex = 1;
            pcBoxHearts.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplayFlowers);
            Controls.Add(lblDisplayHearts);
            Controls.Add(pcBoxHearts);
            Controls.Add(pcBoxFlower);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pcBoxFlower).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxHearts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcBoxFlower;
        private PictureBox pcBoxHearts;
        private Label lblDisplayHearts;
        private Label lblDisplayFlowers;
    }
}
