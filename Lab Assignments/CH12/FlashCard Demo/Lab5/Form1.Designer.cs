namespace Lab5
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
            lblJobDescription = new Label();
            txtJobDes = new TextBox();
            lblPropmt = new Label();
            lblPrompt2 = new Label();
            lblHours = new Label();
            txtHoursToComplete = new TextBox();
            lblHourlyFee = new Label();
            txtHourly = new TextBox();
            lblTotal = new Label();
            lblDisplayTotal = new Label();
            btnUpdate = new Button();
            lblCurrentDescription = new Label();
            lblCurrentHours = new Label();
            lblCurrentRate = new Label();
            SuspendLayout();
            // 
            // lblJobDescription
            // 
            lblJobDescription.AutoSize = true;
            lblJobDescription.Location = new Point(12, 51);
            lblJobDescription.Name = "lblJobDescription";
            lblJobDescription.Size = new Size(121, 20);
            lblJobDescription.TabIndex = 0;
            lblJobDescription.Text = "JOB Description :";
            // 
            // txtJobDes
            // 
            txtJobDes.Location = new Point(153, 48);
            txtJobDes.Name = "txtJobDes";
            txtJobDes.Size = new Size(186, 27);
            txtJobDes.TabIndex = 1;
            // 
            // lblPropmt
            // 
            lblPropmt.AutoSize = true;
            lblPropmt.Location = new Point(188, 12);
            lblPropmt.Name = "lblPropmt";
            lblPropmt.Size = new Size(82, 20);
            lblPropmt.TabIndex = 2;
            lblPropmt.Text = "NEW Value";
            // 
            // lblPrompt2
            // 
            lblPrompt2.AutoSize = true;
            lblPrompt2.Location = new Point(539, 12);
            lblPrompt2.Name = "lblPrompt2";
            lblPrompt2.Size = new Size(113, 20);
            lblPrompt2.TabIndex = 3;
            lblPrompt2.Text = "CURRENT Value";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(12, 87);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(156, 20);
            lblHours.TabIndex = 4;
            lblHours.Text = "HOURS TO COMPLETE";
            // 
            // txtHoursToComplete
            // 
            txtHoursToComplete.Location = new Point(187, 87);
            txtHoursToComplete.Name = "txtHoursToComplete";
            txtHoursToComplete.Size = new Size(152, 27);
            txtHoursToComplete.TabIndex = 5;
            // 
            // lblHourlyFee
            // 
            lblHourlyFee.AutoSize = true;
            lblHourlyFee.Location = new Point(12, 124);
            lblHourlyFee.Name = "lblHourlyFee";
            lblHourlyFee.Size = new Size(90, 20);
            lblHourlyFee.TabIndex = 6;
            lblHourlyFee.Text = "HourlyRate :";
            // 
            // txtHourly
            // 
            txtHourly.Location = new Point(214, 124);
            txtHourly.Name = "txtHourly";
            txtHourly.Size = new Size(125, 27);
            txtHourly.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 183);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total Fees";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(195, 183);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(15, 20);
            lblDisplayTotal.TabIndex = 9;
            lblDisplayTotal.Text = "_";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 232);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblCurrentDescription
            // 
            lblCurrentDescription.AutoSize = true;
            lblCurrentDescription.Location = new Point(570, 43);
            lblCurrentDescription.Name = "lblCurrentDescription";
            lblCurrentDescription.Size = new Size(15, 20);
            lblCurrentDescription.TabIndex = 11;
            lblCurrentDescription.Text = "_";
            // 
            // lblCurrentHours
            // 
            lblCurrentHours.AutoSize = true;
            lblCurrentHours.Location = new Point(570, 76);
            lblCurrentHours.Name = "lblCurrentHours";
            lblCurrentHours.Size = new Size(15, 20);
            lblCurrentHours.TabIndex = 12;
            lblCurrentHours.Text = "_";
            // 
            // lblCurrentRate
            // 
            lblCurrentRate.AutoSize = true;
            lblCurrentRate.Location = new Point(570, 113);
            lblCurrentRate.Name = "lblCurrentRate";
            lblCurrentRate.Size = new Size(15, 20);
            lblCurrentRate.TabIndex = 13;
            lblCurrentRate.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrentRate);
            Controls.Add(lblCurrentHours);
            Controls.Add(lblCurrentDescription);
            Controls.Add(btnUpdate);
            Controls.Add(lblDisplayTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtHourly);
            Controls.Add(lblHourlyFee);
            Controls.Add(txtHoursToComplete);
            Controls.Add(lblHours);
            Controls.Add(lblPrompt2);
            Controls.Add(lblPropmt);
            Controls.Add(txtJobDes);
            Controls.Add(lblJobDescription);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJobDescription;
        private TextBox txtJobDes;
        private Label lblPropmt;
        private Label lblPrompt2;
        private Label lblHours;
        private TextBox txtHoursToComplete;
        private Label lblHourlyFee;
        private TextBox txtHourly;
        private Label lblTotal;
        private Label lblDisplayTotal;
        private Button btnUpdate;
        private Label lblCurrentDescription;
        private Label lblCurrentHours;
        private Label lblCurrentRate;
    }
}
