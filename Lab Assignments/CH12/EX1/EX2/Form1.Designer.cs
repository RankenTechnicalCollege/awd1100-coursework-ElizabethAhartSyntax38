namespace EX2
{
    partial class btnScan
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
            label1 = new Label();
            txtIPAddress = new TextBox();
            btnIPADDRESS = new Button();
            groupBox1 = new GroupBox();
            lblDisplay = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "I.P ADDRESS :";
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(130, 23);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(273, 27);
            txtIPAddress.TabIndex = 1;
            // 
            // btnIPADDRESS
            // 
            btnIPADDRESS.Location = new Point(174, 90);
            btnIPADDRESS.Name = "btnIPADDRESS";
            btnIPADDRESS.Size = new Size(123, 133);
            btnIPADDRESS.TabIndex = 2;
            btnIPADDRESS.Text = "SCAN";
            btnIPADDRESS.UseVisualStyleBackColor = true;
            btnIPADDRESS.Click += btnIPADDRESS_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDisplay);
            groupBox1.Location = new Point(422, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 196);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Availiable Service";
            groupBox1.Visible = false;
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Segoe UI", 9F);
            lblDisplay.Location = new Point(16, 23);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(250, 151);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "_";
            lblDisplay.Visible = false;
            // 
            // btnScan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnIPADDRESS);
            Controls.Add(txtIPAddress);
            Controls.Add(label1);
            Name = "btnScan";
            Text = "**NETWORK SCANNER**";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIPAddress;
        private Button btnIPADDRESS;
        private GroupBox groupBox1;
        private Label lblDisplay;
    }
}
