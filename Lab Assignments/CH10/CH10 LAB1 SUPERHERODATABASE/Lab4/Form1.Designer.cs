namespace Lab4
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
            lblFirst = new Label();
            txtFirst = new TextBox();
            btnFirst = new Button();
            txtLAST = new Label();
            txtLastNames = new TextBox();
            btnLastName = new Button();
            lblDisplayName = new Label();
            grBoxResults = new GroupBox();
            lblGAPADisplay = new Label();
            lblGradeDisplay = new Label();
            lblCourseDisplay = new Label();
            lblGPA = new Label();
            lblGrade = new Label();
            lblCourse = new Label();
            lblERROR = new Label();
            grBoxResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(43, 35);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(80, 20);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(24, 74);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(173, 27);
            txtFirst.TabIndex = 1;
            txtFirst.KeyDown += TextBoxKeyDown;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(24, 121);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(99, 53);
            btnFirst.TabIndex = 2;
            btnFirst.Text = "SEARCH FirstNames";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // txtLAST
            // 
            txtLAST.AutoSize = true;
            txtLAST.Location = new Point(299, 35);
            txtLAST.Name = "txtLAST";
            txtLAST.Size = new Size(86, 20);
            txtLAST.TabIndex = 3;
            txtLAST.Text = "LAST Name";
            // 
            // txtLastNames
            // 
            txtLastNames.Location = new Point(260, 74);
            txtLastNames.Name = "txtLastNames";
            txtLastNames.Size = new Size(173, 27);
            txtLastNames.TabIndex = 4;
            // 
            // btnLastName
            // 
            btnLastName.Location = new Point(334, 121);
            btnLastName.Name = "btnLastName";
            btnLastName.Size = new Size(99, 53);
            btnLastName.TabIndex = 5;
            btnLastName.Text = "SEARCH LastNames";
            btnLastName.UseVisualStyleBackColor = true;
            btnLastName.Click += btnLastName_Click;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblDisplayName.Location = new Point(154, 204);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(16, 17);
            lblDisplayName.TabIndex = 6;
            lblDisplayName.Text = "_";
            // 
            // grBoxResults
            // 
            grBoxResults.Controls.Add(lblGAPADisplay);
            grBoxResults.Controls.Add(lblGradeDisplay);
            grBoxResults.Controls.Add(lblCourseDisplay);
            grBoxResults.Controls.Add(lblGPA);
            grBoxResults.Controls.Add(lblGrade);
            grBoxResults.Controls.Add(lblCourse);
            grBoxResults.Font = new Font("Yu Gothic UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grBoxResults.Location = new Point(413, 204);
            grBoxResults.Name = "grBoxResults";
            grBoxResults.Size = new Size(375, 234);
            grBoxResults.TabIndex = 7;
            grBoxResults.TabStop = false;
            grBoxResults.Text = "GROUP RESULTS";
            // 
            // lblGAPADisplay
            // 
            lblGAPADisplay.AutoSize = true;
            lblGAPADisplay.Location = new Point(163, 120);
            lblGAPADisplay.Name = "lblGAPADisplay";
            lblGAPADisplay.Size = new Size(15, 20);
            lblGAPADisplay.TabIndex = 6;
            lblGAPADisplay.Text = "_";
            // 
            // lblGradeDisplay
            // 
            lblGradeDisplay.AutoSize = true;
            lblGradeDisplay.Location = new Point(148, 80);
            lblGradeDisplay.Name = "lblGradeDisplay";
            lblGradeDisplay.Size = new Size(15, 20);
            lblGradeDisplay.TabIndex = 5;
            lblGradeDisplay.Text = "_";
            // 
            // lblCourseDisplay
            // 
            lblCourseDisplay.AutoSize = true;
            lblCourseDisplay.Location = new Point(148, 40);
            lblCourseDisplay.Name = "lblCourseDisplay";
            lblCourseDisplay.Size = new Size(15, 20);
            lblCourseDisplay.TabIndex = 4;
            lblCourseDisplay.Text = "_";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(21, 120);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(47, 20);
            lblGPA.TabIndex = 3;
            lblGPA.Text = "G.P.A :";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(6, 80);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(126, 20);
            lblGrade.TabIndex = 2;
            lblGrade.Text = "COURSE GRADE : ";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(6, 40);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(75, 20);
            lblCourse.TabIndex = 1;
            lblCourse.Text = "COURSE : ";
            // 
            // lblERROR
            // 
            lblERROR.Font = new Font("Segoe UI", 12F);
            lblERROR.ForeColor = Color.Red;
            lblERROR.Location = new Point(456, 88);
            lblERROR.Name = "lblERROR";
            lblERROR.Size = new Size(321, 64);
            lblERROR.TabIndex = 8;
            lblERROR.Text = "STUDENT NOT FOUND IN DATA";
            lblERROR.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblERROR);
            Controls.Add(grBoxResults);
            Controls.Add(lblDisplayName);
            Controls.Add(btnLastName);
            Controls.Add(txtLastNames);
            Controls.Add(txtLAST);
            Controls.Add(btnFirst);
            Controls.Add(txtFirst);
            Controls.Add(lblFirst);
            Name = "Form1";
            Text = "\"STUDENTDATA\"";
            grBoxResults.ResumeLayout(false);
            grBoxResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirst;
        private TextBox txtFirst;
        private Button btnFirst;
        private Label txtLAST;
        private TextBox txtLastNames;
        private Button btnLastName;
        private Label lblDisplayName;
        private GroupBox grBoxResults;
        private Label lblGPA;
        private Label lblGrade;
        private Label lblCourse;
        private Label lblGAPADisplay;
        private Label lblGradeDisplay;
        private Label lblCourseDisplay;
        private Label lblERROR;
    }
}
