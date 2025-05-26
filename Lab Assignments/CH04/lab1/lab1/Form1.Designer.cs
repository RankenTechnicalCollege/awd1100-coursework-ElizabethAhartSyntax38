namespace lab1
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
            btnSubmit1 = new Button();
            btnSubmit2 = new Button();
            NameLbl = new Label();
            MileLbl = new Label();
            KiloLbl = new Label();
            userInput1 = new TextBox();
            UserInput2 = new TextBox();
            LblDisplay = new Label();
            label1 = new Label();
            labelDisplay = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSubmit1
            // 
            btnSubmit1.Location = new Point(49, 164);
            btnSubmit1.Name = "btnSubmit1";
            btnSubmit1.Size = new Size(176, 70);
            btnSubmit1.TabIndex = 0;
            btnSubmit1.Text = "Convert to kilo";
            btnSubmit1.UseVisualStyleBackColor = true;
            btnSubmit1.Click += btnSubmit1_Click;
            // 
            // btnSubmit2
            // 
            btnSubmit2.Location = new Point(394, 164);
            btnSubmit2.Name = "btnSubmit2";
            btnSubmit2.Size = new Size(152, 70);
            btnSubmit2.TabIndex = 1;
            btnSubmit2.Text = "Convert to Miles";
            btnSubmit2.UseVisualStyleBackColor = true;
            btnSubmit2.Click += btnSubmit2_Click;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(12, 9);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(121, 20);
            NameLbl.TabIndex = 2;
            NameLbl.Text = "Distance Convert";
            // 
            // MileLbl
            // 
            MileLbl.AutoSize = true;
            MileLbl.Location = new Point(49, 98);
            MileLbl.Name = "MileLbl";
            MileLbl.Size = new Size(0, 20);
            MileLbl.TabIndex = 3;
            // 
            // KiloLbl
            // 
            KiloLbl.AutoSize = true;
            KiloLbl.Location = new Point(394, 98);
            KiloLbl.Name = "KiloLbl";
            KiloLbl.Size = new Size(118, 20);
            KiloLbl.TabIndex = 4;
            KiloLbl.Text = "Enter Kilometers";
            // 
            // userInput1
            // 
            userInput1.Location = new Point(49, 121);
            userInput1.Name = "userInput1";
            userInput1.Size = new Size(125, 27);
            userInput1.TabIndex = 5;
            userInput1.TextChanged += userInput1_TextChanged;
            // 
            // UserInput2
            // 
            UserInput2.Location = new Point(394, 121);
            UserInput2.Name = "UserInput2";
            UserInput2.Size = new Size(125, 27);
            UserInput2.TabIndex = 6;
            UserInput2.TextChanged += UserInput2_TextChanged;
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = true;
            LblDisplay.Location = new Point(49, 328);
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(0, 20);
            LblDisplay.TabIndex = 7;
            LblDisplay.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 78);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 8;
            label1.Text = "Enter Miles";
            // 
            // labelDisplay
            // 
            labelDisplay.AutoSize = true;
            labelDisplay.Location = new Point(72, 303);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new Size(0, 20);
            labelDisplay.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 342);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(labelDisplay);
            Controls.Add(label1);
            Controls.Add(LblDisplay);
            Controls.Add(UserInput2);
            Controls.Add(userInput1);
            Controls.Add(KiloLbl);
            Controls.Add(MileLbl);
            Controls.Add(NameLbl);
            Controls.Add(btnSubmit2);
            Controls.Add(btnSubmit1);
            Name = "Form1";
            Text = "lab1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit1;
        private Button btnSubmit2;
        private Label NameLbl;
        private Label MileLbl;
        private Label KiloLbl;
        private TextBox userInput1;
        private TextBox UserInput2;
        private Label LblDisplay;
        private Label label1;
        private Label labelDisplay;
        private Label label2;
    


