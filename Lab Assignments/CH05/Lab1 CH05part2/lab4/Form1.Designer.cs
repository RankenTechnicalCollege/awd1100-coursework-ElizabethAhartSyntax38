namespace lab4
{
    partial class Sales
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
            btnFrancis = new Button();
            btnEdward = new Button();
            btnDaniel = new Button();
            txtBox1 = new TextBox();
            lblPrompt = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lblTotal = new Label();
            lblHighest = new Label();
            SuspendLayout();
            // 
            // btnFrancis
            // 
            btnFrancis.Location = new Point(480, 183);
            btnFrancis.Name = "btnFrancis";
            btnFrancis.Size = new Size(94, 29);
            btnFrancis.TabIndex = 0;
            btnFrancis.Text = "Francis";
            btnFrancis.UseVisualStyleBackColor = true;
            btnFrancis.Click += btnFrancis_Click;
            // 
            // btnEdward
            // 
            btnEdward.Location = new Point(322, 188);
            btnEdward.Name = "btnEdward";
            btnEdward.Size = new Size(94, 29);
            btnEdward.TabIndex = 1;
            btnEdward.Text = "Edward";
            btnEdward.UseVisualStyleBackColor = true;
            btnEdward.Click += btnEdward_Click;
            // 
            // btnDaniel
            // 
            btnDaniel.Location = new Point(124, 183);
            btnDaniel.Name = "btnDaniel";
            btnDaniel.Size = new Size(94, 29);
            btnDaniel.TabIndex = 2;
            btnDaniel.Text = "Daniel";
            btnDaniel.UseVisualStyleBackColor = true;
            btnDaniel.Click += btnDaniel_Click;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(124, 84);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(461, 27);
            txtBox1.TabIndex = 6;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(128, 39);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(198, 20);
            lblPrompt.TabIndex = 7;
            lblPrompt.Text = "How much was the Sale For?";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(52, 238);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 20);
            lbl1.TabIndex = 8;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(53, 274);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(0, 20);
            lbl2.TabIndex = 9;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(55, 313);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(0, 20);
            lbl3.TabIndex = 10;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(578, 261);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(15, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "_";
            // 
            // lblHighest
            // 
            lblHighest.AutoSize = true;
            lblHighest.Location = new Point(592, 297);
            lblHighest.Name = "lblHighest";
            lblHighest.Size = new Size(15, 20);
            lblHighest.TabIndex = 12;
            lblHighest.Text = "_";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHighest);
            Controls.Add(lblTotal);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblPrompt);
            Controls.Add(txtBox1);
            Controls.Add(btnDaniel);
            Controls.Add(btnEdward);
            Controls.Add(btnFrancis);
            Name = "Sales";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFrancis;
        private Button btnEdward;
        private Button btnDaniel;
        private TextBox txtBox1;
        private Label lblPrompt;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lblTotal;
        private Label lblHighest;
    }
}
