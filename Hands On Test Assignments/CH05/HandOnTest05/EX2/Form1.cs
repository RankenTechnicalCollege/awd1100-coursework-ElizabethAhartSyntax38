namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int i = 1;
            double UserInput = Convert.ToDouble(txtBoxGpa);
            double Gpa = UserInput;
            if (Gpa >= 3.0 )
            {
                lblDisplay.Text = "A";
            }
            else if (Gpa >= 2.0 && i>0 )
                lblDisplay.Text = "B";
            else if (Gpa>= 1.0 && i > 0)
                lblDisplay.Text = "C";
            else if(Gpa>=.9 && i > 0)
                lblDisplay.Text = "D";
            else if (Gpa >=.8 && i > 0)
                lblDisplay.Text = "F";
                
            
        }
    }
}
