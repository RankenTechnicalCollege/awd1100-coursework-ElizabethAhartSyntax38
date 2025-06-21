namespace Lab6
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
            lblWood = new Label();
            txtBoxWood = new TextBox();
            lblDrawerCount = new Label();
            txtBoxDrawerCount = new TextBox();
            btnEstimate = new Button();
            lblCost = new Label();
            lblDisplayCostW = new Label();
            lblCostDrawer = new Label();
            lblDisplayCostD = new Label();
            lblTotal = new Label();
            lblDisplayTotal = new Label();
            SuspendLayout();
            // 
            // lblWood
            // 
            lblWood.AutoSize = true;
            lblWood.Location = new Point(37, 54);
            lblWood.Name = "lblWood";
            lblWood.Size = new Size(113, 20);
            lblWood.TabIndex = 0;
            lblWood.Text = "Type OF Wood :";
            // 
            // txtBoxWood
            // 
            txtBoxWood.Location = new Point(37, 96);
            txtBoxWood.Name = "txtBoxWood";
            txtBoxWood.Size = new Size(162, 27);
            txtBoxWood.TabIndex = 1;
            // 
            // lblDrawerCount
            // 
            lblDrawerCount.AutoSize = true;
            lblDrawerCount.Location = new Point(37, 159);
            lblDrawerCount.Name = "lblDrawerCount";
            lblDrawerCount.Size = new Size(170, 20);
            lblDrawerCount.TabIndex = 2;
            lblDrawerCount.Text = "NUMBER OF DRAWERS :";
            // 
            // txtBoxDrawerCount
            // 
            txtBoxDrawerCount.Location = new Point(37, 210);
            txtBoxDrawerCount.Name = "txtBoxDrawerCount";
            txtBoxDrawerCount.Size = new Size(162, 27);
            txtBoxDrawerCount.TabIndex = 3;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(65, 289);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(94, 67);
            btnEstimate.TabIndex = 4;
            btnEstimate.Text = "ESTIMATE";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(473, 62);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(125, 20);
            lblCost.TabIndex = 5;
            lblCost.Text = "COST OF WOOD :";
            // 
            // lblDisplayCostW
            // 
            lblDisplayCostW.AutoSize = true;
            lblDisplayCostW.Location = new Point(643, 62);
            lblDisplayCostW.Name = "lblDisplayCostW";
            lblDisplayCostW.Size = new Size(15, 20);
            lblDisplayCostW.TabIndex = 6;
            lblDisplayCostW.Text = "_";
            // 
            // lblCostDrawer
            // 
            lblCostDrawer.AutoSize = true;
            lblCostDrawer.Location = new Point(473, 159);
            lblCostDrawer.Name = "lblCostDrawer";
            lblCostDrawer.Size = new Size(146, 20);
            lblCostDrawer.TabIndex = 7;
            lblCostDrawer.Text = "COST OF DRAWERS :";
            // 
            // lblDisplayCostD
            // 
            lblDisplayCostD.AutoSize = true;
            lblDisplayCostD.Location = new Point(672, 160);
            lblDisplayCostD.Name = "lblDisplayCostD";
            lblDisplayCostD.Size = new Size(15, 20);
            lblDisplayCostD.TabIndex = 8;
            lblDisplayCostD.Text = "_";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(480, 237);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 20);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "TOTAL COST :";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(634, 239);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(15, 20);
            lblDisplayTotal.TabIndex = 10;
            lblDisplayTotal.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplayTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblDisplayCostD);
            Controls.Add(lblCostDrawer);
            Controls.Add(lblDisplayCostW);
            Controls.Add(lblCost);
            Controls.Add(btnEstimate);
            Controls.Add(txtBoxDrawerCount);
            Controls.Add(lblDrawerCount);
            Controls.Add(txtBoxWood);
            Controls.Add(lblWood);
            Name = "Form1";
            Text = "MY CUSTOM DESK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWood;
        private TextBox txtBoxWood;
        private Label lblDrawerCount;
        private TextBox txtBoxDrawerCount;
        private Button btnEstimate;
        private Label lblCost;
        private Label lblDisplayCostW;
        private Label lblCostDrawer;
        private Label lblDisplayCostD;
        private Label lblTotal;
        private Label lblDisplayTotal;
    }
}
