using System.Diagnostics.Eventing.Reader;

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
            decimal UserInput = Convert.ToDecimal(txtBoxGpa.Text);
            decimal Gpa = Convert.ToDecimal(UserInput);
            if (Gpa >= 3)
            {

                lblDisplay.Text = "A";

            }
            else if (Gpa >= 2)
            {
                lblDisplay.Text = " Letter Grade B";
            } else if (Gpa >= 1)
            {
                lblDisplay.Text = "Letter Grade C";
            }else if (Gpa <= 1)
            {
                lblDisplay.Text = "Letter Grade D";
            }else { lblDisplay.Text = "Letter Grade F"; }
                

    
        }
    }
}

