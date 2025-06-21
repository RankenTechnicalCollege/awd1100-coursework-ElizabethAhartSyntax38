namespace Lab1
{
    partial class Lab1
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
            btnOpen = new Button();
            rTxtBox = new RichTextBox();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(35, 23);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(170, 54);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "**OPEN **";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // rTxtBox
            // 
            rTxtBox.Location = new Point(462, 137);
            rTxtBox.Name = "rTxtBox";
            rTxtBox.Size = new Size(206, 167);
            rTxtBox.TabIndex = 1;
            rTxtBox.Text = "";
            // 
            // Lab1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rTxtBox);
            Controls.Add(btnOpen);
            Name = "Lab1";
            Text = "Fortune Cookie";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private RichTextBox rTxtBox;
    }
}
