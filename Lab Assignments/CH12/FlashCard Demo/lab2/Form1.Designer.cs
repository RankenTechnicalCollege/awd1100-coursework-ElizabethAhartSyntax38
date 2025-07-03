namespace lab2
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
            lblAccessKey = new Label();
            txtBoxAccess = new TextBox();
            btn1 = new Button();
            lblDisplay = new Label();
            txtItemName = new TextBox();
            lblItemName = new Label();
            lblInventory = new Label();
            txtInventoryNumber = new TextBox();
            lblUnitsPer = new Label();
            btnAdd = new Button();
            lblUnit = new Label();
            txtUnit = new TextBox();
            SuspendLayout();
            // 
            // lblAccessKey
            // 
            lblAccessKey.AutoSize = true;
            lblAccessKey.Location = new Point(2, 4);
            lblAccessKey.Name = "lblAccessKey";
            lblAccessKey.Size = new Size(152, 20);
            lblAccessKey.TabIndex = 0;
            lblAccessKey.Text = "Access Key Required :";
            // 
            // txtBoxAccess
            // 
            txtBoxAccess.Location = new Point(160, 1);
            txtBoxAccess.Name = "txtBoxAccess";
            txtBoxAccess.Size = new Size(78, 27);
            txtBoxAccess.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 11F);
            btn1.Location = new Point(244, -2);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 2;
            btn1.Text = "Submit";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Segoe UI", 11F);
            lblDisplay.Location = new Point(462, 12);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(313, 307);
            lblDisplay.TabIndex = 3;
            lblDisplay.Text = "_";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(153, 147);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(125, 27);
            txtItemName.TabIndex = 4;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(12, 154);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(90, 20);
            lblItemName.TabIndex = 5;
            lblItemName.Text = "Item Name :";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(12, 187);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(135, 20);
            lblInventory.TabIndex = 6;
            lblInventory.Text = "Inventory Number :";
            // 
            // txtInventoryNumber
            // 
            txtInventoryNumber.Location = new Point(153, 180);
            txtInventoryNumber.Name = "txtInventoryNumber";
            txtInventoryNumber.Size = new Size(125, 27);
            txtInventoryNumber.TabIndex = 7;
            txtInventoryNumber.TextChanged += textBox1_TextChanged;
            // 
            // lblUnitsPer
            // 
            lblUnitsPer.AutoSize = true;
            lblUnitsPer.Font = new Font("Segoe UI", 12F);
            lblUnitsPer.Location = new Point(12, 218);
            lblUnitsPer.Name = "lblUnitsPer";
            lblUnitsPer.Size = new Size(143, 28);
            lblUnitsPer.TabIndex = 8;
            lblUnitsPer.Text = "Units Per Case :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(256, 147);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add Inventory";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(12, 122);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(78, 20);
            lblUnit.TabIndex = 10;
            lblUnit.Text = "Units Price";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(153, 114);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(125, 27);
            txtUnit.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUnit);
            Controls.Add(lblUnit);
            Controls.Add(btnAdd);
            Controls.Add(lblUnitsPer);
            Controls.Add(txtInventoryNumber);
            Controls.Add(lblInventory);
            Controls.Add(lblItemName);
            Controls.Add(txtItemName);
            Controls.Add(lblDisplay);
            Controls.Add(btn1);
            Controls.Add(txtBoxAccess);
            Controls.Add(lblAccessKey);
            Name = "Form1";
            Text = "Store Inventory";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccessKey;
        private TextBox txtBoxAccess;
        private Button btn1;
        private Label lblDisplay;
        private TextBox txtItemName;
        private Label lblItemName;
        private Label lblInventory;
        private TextBox txtInventoryNumber;
        private Label lblUnitsPer;
        private Button btnAdd;
        private Label lblUnit;
        private TextBox txtUnit;
    }
}
