namespace Grade_Calc2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnCalculate(object sender, EventArgs e)
        {
            //Check for invalid data
            //Get input from the user
            //Determine the Grade using If else If Block and Out Put the Letter.
            string enteredGrade = txtNumberGrade.Text;
            int NumberGrade;
            int.TryParse(enteredGrade, out NumberGrade);
            if (NumberGrade == 0)
            {
                lblLetterGrade.Text = "Please Enter a Valid number 1-100";
            }
            else if (NumberGrade < 0 || NumberGrade > 100)
            {
                lblLetterGrade.Text = "Please Enter a Valid number 1-100";
            }else if (NumberGrade>= 90)
            {
                lblLetterGrade.Text = "A";
            }else if (NumberGrade >= 80)
            {
                lblLetterGrade.Text = "B";
            }else if (NumberGrade >= 70)
            {
                lblLetterGrade.Text = "C";
            }else if (NumberGrade >= 60)
            {
                lblLetterGrade.Text = "D";
            }
            else
            {
                lblLetterGrade.Text = "F";
            }
        }
    }
}
