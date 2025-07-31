using System.Reflection;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int NumOfTestScores = 0;
        int AverageTestScore = 0;
        int HighestTestScores = int.MinValue;
        int LowestTestScores = int.MaxValue;
        int sum = 0;
        int TestsScore;
        TestScores[] TestScores = new TestScores[100];
        public int AddTestScore(int score)
        {
            return score;
        }
        

        private void btnEnter_Click(object sender, EventArgs e)
        {
           
            try
            {
                int TestScore1 = Convert.ToInt32(txtTestScore.Text);
                if (TestScore1 >= 101)
                { }
            }
            catch (OverflowException)
            {
                MessageBox.Show("valid test 1-100");
            }
            int NumOfTestScores = 0;
            float AverageTestScore = 0;
            float HighestTestScores = int.MinValue;
            float LowestTestScores = int.MaxValue;
            float sum = 0;
            string Name = "_Elizabeth";

            TestScores[] TestScores = new TestScores[100];
            new TestStatistics(NumOfTestScores, sum, HighestTestScores, LowestTestScores, AverageTestScore);
            int TestScore = Convert.ToInt32(txtTestScore.Text);

            do
            {

                NumOfTestScores = 0;


                for (int i = 0; i < 10; i++)
                {

                }
                if (TestScore > 0 && TestScore <= 100)
                {

                    sum += TestScore;
                   
                    TestScores[] testScores = new TestScores[1];
                    lblDisplay.Text = TestScore.ToString();


                    if (TestScore > HighestTestScores)
                    {
                        HighestTestScores = TestScore;
                    }

                    if (LowestTestScores > TestScore)
                    {
                        LowestTestScores = TestScore;
                    }
                    TestStatistics testscore=new TestStatistics(NumOfTestScores, sum, LowestTestScores,HighestTestScores, AverageTestScore);
                    NumOfTestScores++;


                    txtTestScore.Clear();
                    lblDisplay.Text += $"The Number of scores is {NumOfTestScores}\n" + $"the Average of Score is {sum / NumOfTestScores}\n" + $"The Sum of all Scores is {sum}\n" + $" {HighestTestScores:f} Had the highest score and {LowestTestScores:f} had the Lowest score\n";
                    lblDisplay.Text += $"{testscore}";
                    break;
                }
                try
                {
                    if (TestScore > 100)
                        lblDisplay.Text += $"Validate Entry TestScore must be 1--100\n";
                }

                catch (OverflowException)
                {

                    MessageBox.Show($"Validate Entry TestScore must be 1--100\n");
                }
            }
            while (true);

            


        }
        public string IsWithinRange(int TestScore)
        {

            TestScore = Convert.ToInt32(txtTestScore.Text);
            string msg = "";
            if (TestScore > 100)
            {
                msg += TestScore + "please Enter a valid Num 1-100";
            }
            return msg;
        }




    }
}

       
    









    
        
    

