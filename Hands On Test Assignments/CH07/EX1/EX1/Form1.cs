using System.Reflection;

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
               decimal TestScores1 = Convert.ToDecimal(txtTestScore.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show("valid test 1-100");
            }
            int NumOfTestScores=0;
            float AverageTestScore = 0;
            float HighestTestScores = int.MinValue;
            float LowestTestScores = int.MaxValue;
            float sum = 0;
            string Name = "_Elizabeth";

            TestScores[] TestScores = new TestScores[100];
            new TestStatistics(NumOfTestScores, sum, HighestTestScores, LowestTestScores, AverageTestScore);
            int TestScore = Convert.ToInt32(txtTestScore.Text);
            IsWithinRange(TestScore);


            for (int i = 0; i < 1; i++)
            {
                {
                    NumOfTestScores++;

                    if (TestScore > 0 && TestScore <= 100)
                    {

                       

                        sum += TestScore;

                        if (TestScore > HighestTestScores)
                        {
                            HighestTestScores = TestScore;
                        }

                        if (LowestTestScores > TestScore)
                        {
                            LowestTestScores = TestScore;
                        }

                        txtTestScore.Clear();
                        lblDisplay.Text += $"The Number of scores is {NumOfTestScores}\n" + $"the Average of Score is {sum / NumOfTestScores}\n" + $"The Sum of all Scores is {sum}\n" + $" {HighestTestScores:f} Had the highest score and {LowestTestScores:f} had the Lowest score\n";
                    }
                    else if (TestScore > 100)
                    {
                        lblDisplay.Text += $"Validate Entry TestScore must be 1--100\n";
                        IsWithinRange(TestScore);



                    }

                }
            }
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

