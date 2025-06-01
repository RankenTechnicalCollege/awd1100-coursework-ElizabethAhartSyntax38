namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//variables for score label initialized on class scope
        int PlayerScore = 0;
        int ComputerScore = 0;

        private void btnRock_Click(object sender, EventArgs e)
        {
            Random randGenerator = new Random();
            int randomNum = randGenerator.Next(1, 4);
            if (randomNum == 1)
            {
                lblComputerChose.Text = "Computer chooses ROCK!";
                lblDisplay.Text = "draw";
                //doesn't need ++ increment 
                
            } 

            else if (randomNum == 2) 
            {
                lblComputerChose.Text = "Computer Chooses Paper!";
                lblDisplay.Text = "COMPTER WINS!";
                ComputerScore++;
                
            }
            else if (randomNum == 3)
            {
                lblComputerChose.Text = "Computer chooses Scissors";
                lblDisplay.Text = "Player2 Wins!!";
                PlayerScore++;

            }

            lblPlayer.Text = $"Player score{PlayerScore.ToString()}";
            lblComputer.Text = $" ComputerScore{ComputerScore.ToString()}";

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            Random randGenerator = new Random();
            int randomNum = randGenerator.Next(1, 4);
            if (randomNum == 1)
            {
                lblComputerChose.Text = "Computer chooses Rock!";
                lblDisplay.Text = "Player2 Wins!!";
                PlayerScore++;

            }
            else if (randomNum == 2)
            {
                lblComputerChose.Text = "Computer Chooses Paper!";
                lblDisplay.Text = " Draw!";
                

            }
            else if (randomNum == 3)
            {
                lblComputerChose.Text = "Computer chooses Scissors";
                lblDisplay.Text = "Computer Wins!!";
                ComputerScore++;

            }
            lblPlayer.Text = $"Player score{PlayerScore.ToString()}";
            lblComputer.Text = $" ComputerScore{ComputerScore.ToString()}";

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Random randGenerator = new Random();
            int randomNum = randGenerator.Next(1,4);
            if (randomNum == 1)
            {
                lblComputerChose.Text = "Computer chooses ROCK!";
                lblDisplay.Text = "Computer Wins!!";
                ComputerScore++;

            }
            else if (randomNum == 2)
            {
                lblComputerChose.Text = "Computer Chooses Paper!";
                lblDisplay.Text = "Player WINS!";
                PlayerScore++;

            }
            else if (randomNum == 3)
            {
                
                lblComputerChose.Text = "Computer chooses Scissors";
                lblDisplay.Text = "Draw!!";
            }
            lblPlayer.Text =$"Player score{ PlayerScore.ToString()}";
            lblComputer.Text =$" ComputerScore{ComputerScore.ToString()}";
        }
    }
}
