namespace Lab3
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblComputerChose = new Label();
            lblPlayer = new Label();
            lblComputer = new Label();
            lblDisplay = new Label();
            lblPlayerWins = new Label();
            lblComputerWins = new Label();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(36, 73);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(145, 73);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(300, 73);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(132, 73);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(558, 73);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(128, 64);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblComputerChose
            // 
            lblComputerChose.AutoSize = true;
            lblComputerChose.Location = new Point(36, 203);
            lblComputerChose.Name = "lblComputerChose";
            lblComputerChose.Size = new Size(0, 20);
            lblComputerChose.TabIndex = 3;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Location = new Point(36, 269);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(90, 20);
            lblPlayer.TabIndex = 4;
            lblPlayer.Text = "Player Score";
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.Location = new Point(331, 269);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(116, 20);
            lblComputer.TabIndex = 5;
            lblComputer.Text = "Computer Score";
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(558, 203);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 20);
            lblDisplay.TabIndex = 6;
            // 
            // lblPlayerWins
            // 
            lblPlayerWins.AutoSize = true;
            lblPlayerWins.Location = new Point(162, 281);
            lblPlayerWins.Name = "lblPlayerWins";
            lblPlayerWins.Size = new Size(0, 20);
            lblPlayerWins.TabIndex = 7;
            // 
            // lblComputerWins
            // 
            lblComputerWins.AutoSize = true;
            lblComputerWins.Location = new Point(508, 281);
            lblComputerWins.Name = "lblComputerWins";
            lblComputerWins.Size = new Size(0, 20);
            lblComputerWins.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblComputerWins);
            Controls.Add(lblPlayerWins);
            Controls.Add(lblDisplay);
            Controls.Add(lblComputer);
            Controls.Add(lblPlayer);
            Controls.Add(lblComputerChose);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblComputerChose;
        private Label lblPlayer;
        private Label lblComputer;
        private Label lblDisplay;
        private Label lblPlayerWins;
        private Label lblComputerWins;
    }
}
