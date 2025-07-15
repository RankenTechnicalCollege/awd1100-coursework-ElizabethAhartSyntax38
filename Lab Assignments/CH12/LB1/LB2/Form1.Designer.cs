namespace LB2
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
            lblGroup = new Label();
            lblStart = new Label();
            lblAttendees = new Label();
            lblRoom = new Label();
            txtGroupName = new TextBox();
            txtStart = new TextBox();
            txtAttendees = new TextBox();
            txtRoom = new TextBox();
            lblBegin = new Label();
            lblEnd = new Label();
            txtBegin = new TextBox();
            txtEnd = new TextBox();
            lblDisplayGroup = new Label();
            lblDisplaySearch = new Label();
            btnADD = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Location = new Point(1, 9);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(103, 20);
            lblGroup.TabIndex = 0;
            lblGroup.Text = "GROUP NAME";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(165, 9);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(97, 20);
            lblStart.TabIndex = 1;
            lblStart.Text = "Starting Date";
            // 
            // lblAttendees
            // 
            lblAttendees.AutoSize = true;
            lblAttendees.Location = new Point(344, 9);
            lblAttendees.Name = "lblAttendees";
            lblAttendees.Size = new Size(88, 20);
            lblAttendees.TabIndex = 2;
            lblAttendees.Text = "ATTENDEES";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(526, 9);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(49, 20);
            lblRoom.TabIndex = 3;
            lblRoom.Text = "Room";
            // 
            // txtGroupName
            // 
            txtGroupName.Location = new Point(1, 46);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(125, 27);
            txtGroupName.TabIndex = 4;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(150, 46);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(125, 27);
            txtStart.TabIndex = 5;
            // 
            // txtAttendees
            // 
            txtAttendees.Location = new Point(307, 46);
            txtAttendees.Name = "txtAttendees";
            txtAttendees.Size = new Size(125, 27);
            txtAttendees.TabIndex = 6;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(472, 46);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(125, 27);
            txtRoom.TabIndex = 7;
            // 
            // lblBegin
            // 
            lblBegin.AutoSize = true;
            lblBegin.Location = new Point(101, 181);
            lblBegin.Name = "lblBegin";
            lblBegin.Size = new Size(51, 20);
            lblBegin.TabIndex = 8;
            lblBegin.Text = "BEGIN";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(296, 181);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(39, 20);
            lblEnd.TabIndex = 9;
            lblEnd.Text = "END";
            // 
            // txtBegin
            // 
            txtBegin.Location = new Point(57, 204);
            txtBegin.Name = "txtBegin";
            txtBegin.Size = new Size(125, 27);
            txtBegin.TabIndex = 11;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(252, 204);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(125, 27);
            txtEnd.TabIndex = 12;
            // 
            // lblDisplayGroup
            // 
            lblDisplayGroup.Font = new Font("Segoe UI", 11F);
            lblDisplayGroup.ForeColor = Color.CornflowerBlue;
            lblDisplayGroup.Location = new Point(12, 86);
            lblDisplayGroup.Name = "lblDisplayGroup";
            lblDisplayGroup.Size = new Size(532, 75);
            lblDisplayGroup.TabIndex = 14;
            lblDisplayGroup.Text = "_";
            // 
            // lblDisplaySearch
            // 
            lblDisplaySearch.Font = new Font("Segoe UI", 11F);
            lblDisplaySearch.ForeColor = Color.CornflowerBlue;
            lblDisplaySearch.Location = new Point(12, 259);
            lblDisplaySearch.Name = "lblDisplaySearch";
            lblDisplaySearch.Size = new Size(563, 167);
            lblDisplaySearch.TabIndex = 15;
            lblDisplaySearch.Text = "_";
            // 
            // btnADD
            // 
            btnADD.Location = new Point(647, 34);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(123, 39);
            btnADD.TabIndex = 16;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(634, 259);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(154, 54);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnADD);
            Controls.Add(lblDisplaySearch);
            Controls.Add(lblDisplayGroup);
            Controls.Add(txtEnd);
            Controls.Add(txtBegin);
            Controls.Add(lblEnd);
            Controls.Add(lblBegin);
            Controls.Add(txtRoom);
            Controls.Add(txtAttendees);
            Controls.Add(txtStart);
            Controls.Add(txtGroupName);
            Controls.Add(lblRoom);
            Controls.Add(lblAttendees);
            Controls.Add(lblStart);
            Controls.Add(lblGroup);
            Name = "Form1";
            Text = "Hotel Conference ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGroup;
        private Label lblStart;
        private Label lblAttendees;
        private Label lblRoom;
        private TextBox txtGroupName;
        private TextBox txtStart;
        private TextBox txtAttendees;
        private TextBox txtRoom;
        private Label lblBegin;
        private Label lblEnd;
        private TextBox txtBegin;
        private TextBox txtEnd;
        private Label lblDisplayGroup;
        private Label lblDisplaySearch;
        private Button btnADD;
        private Button btnSearch;
    }
}
