namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            lblDisplay6.Text = "Please enter 3 BasketBall Scores!!!";
            InitializeComponent();
        }
      
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userInput = Convert.ToInt32(txtBox1.Text);
            int sum = 0;
            while (userInput != 999)
            {
                {
                    sum = sum + userInput;

                }
                lblDisplay6.Text="Please enter a Basketball score between (0-100) to sum or 999 to stop.";
                userInput = Convert.ToInt32(txtBox2.Text);
                int userInput2 = userInput;
                int sum3 = 0;
                sum3 = sum3 + userInput;
                lblDisplay6.Text="Please Enter a score between (0-100)";
                int UserInput3 = Convert.ToInt32(txtBox3.Text);
                int userInput3 = userInput;
                int sum1 = 0;
                sum1 = sum1 + userInput;
                {
                    lblDisplay1.Text = "Valid Scores are between (0-100)";
                    lblDisplay2.Text = $"The average of Test scores is {(sum + sum3 + sum1) / 3}";
                    lblDisplay3.Text = $"The sum of the Test scores are {sum + sum1}";
                }

                    if (userInput > userInput2 && userInput < userInput3)
                        lblDisplay4.Text = ($"The highest Test score is {userInput3}");
                    else if (userInput > userInput3 && userInput < userInput2)
                        lblDisplay4.Text = $"The highest TestScore is {userInput2}";
                    else if (userInput3 > userInput2 && userInput3 < userInput)
                        lblDisplay4.Text = $"THE HIGHEST SCORE IS {userInput}";
                lblDisplay6.Text="Thanks for using my program";


                }
            }
        }
    }
