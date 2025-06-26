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
            lblPrompt = new Label();
            txtBoxPhrase = new TextBox();
            btnSort = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Segoe UI", 12F);
            lblPrompt.Location = new Point(25, 19);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(193, 28);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Please Enter a Phrase";
            // 
            // txtBoxPhrase
            // 
            txtBoxPhrase.Location = new Point(41, 79);
            txtBoxPhrase.Name = "txtBoxPhrase";
            txtBoxPhrase.Size = new Size(462, 27);
            txtBoxPhrase.TabIndex = 1;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(207, 140);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(94, 29);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort( )";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 16F);
            lblDisplay.Location = new Point(195, 252);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(28, 37);
            lblDisplay.TabIndex = 3;
            lblDisplay.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnSort);
            Controls.Add(txtBoxPhrase);
            Controls.Add(lblPrompt);
            Name = "Form1";
            Text = "Sorted Phrase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtBoxPhrase;
        private Button btnSort;
        private Label lblDisplay;
    }
}
