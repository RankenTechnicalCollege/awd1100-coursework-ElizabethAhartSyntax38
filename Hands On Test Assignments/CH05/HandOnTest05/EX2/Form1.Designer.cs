namespace EX2
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
            lblGpa = new Label();
            txtBoxGpa = new TextBox();
            btnSubmit = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Location = new Point(45, 66);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(127, 20);
            lblGpa.TabIndex = 0;
            lblGpa.Text = "Please Enter G.P.A";
            // 
            // txtBoxGpa
            // 
            txtBoxGpa.Location = new Point(45, 126);
            txtBoxGpa.Name = "txtBoxGpa";
            txtBoxGpa.Size = new Size(125, 27);
            txtBoxGpa.TabIndex = 1;
          
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(269, 181);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(457, 273);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 20);
            lblDisplay.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btnSubmit);
            Controls.Add(txtBoxGpa);
            Controls.Add(lblGpa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGpa;
        private TextBox txtBoxGpa;
        private Button btnSubmit;
        private Label lblDisplay;
    }
}
