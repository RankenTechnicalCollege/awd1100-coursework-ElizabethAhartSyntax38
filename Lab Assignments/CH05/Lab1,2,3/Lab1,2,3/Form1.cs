namespace Lab1_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           double UserInput = Convert.ToDouble(textBox1.Text);
            double UserInput2 = Convert.ToDouble(textBox2.Text);
          
            double Gpa = UserInput; 
            double admissionScore= UserInput2;
            if (Gpa >= 3.0 && admissionScore >= 60)
            {
                lblDisplay.Text = "Accept";
            }
            else if (Gpa <= 3.0 && admissionScore >= 80)
            {
                lblDisplay.Text = "Accept";
            }
            else { lblDisplay.Text = "Reject"; }


            
        }
    }
}
