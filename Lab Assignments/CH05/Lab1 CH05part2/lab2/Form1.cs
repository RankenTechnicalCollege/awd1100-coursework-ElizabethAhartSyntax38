using System.Diagnostics.Eventing.Reader;

namespace lab2
{
    public partial class Form1 : Form
    {

        public Form1()

        {


            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int userInput1 = Convert.ToInt32(txtBox1.Text);
            int userInput2 = Convert.ToInt32(txtBox2.Text);
            int userInput3 = Convert.ToInt32(txtBox3.Text);
            int sum = userInput1;
            int sum1 = userInput2;
            int sum2 = userInput3;
            int Totalsum=sum+sum1 + sum2;
            if (sum < sum1 && sum2 > sum1)
                lblDisplay2.Text = $"The Highest Score is {sum2}and the lowest score is {sum}";
             if
                (sum1 > sum && sum2 < sum) 
            lblDisplay2.Text = $"The highest Score is {sum1} and the Lowest Score is {sum2}";
            if (sum2 > sum1 && sum1 < sum)
                lblDisplay2.Text = $"The Highest score is {sum} and the lowest Score is {sum2}";

            lblName.Text = $"Test scores Sum:{Totalsum}";
            lblDisplay1.Text = $"The Average Test Score is:{(Totalsum)/3}";
            
           
            
                        
                    



                

            }
        }
    }
