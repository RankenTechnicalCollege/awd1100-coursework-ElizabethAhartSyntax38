namespace MauiApp1
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
            // count++;

            // if (count == 1)
            // CounterBtn.Text = $"Clicked {count} time";
            // else
            // CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
            //Get input from the User.
            string enterGrade = TxtNumberGrade.Text;
            int numberGrade;
            int.TryParse(enterGrade, out numberGrade);
            if (numberGrade == 0)
            {
                lblLetterGrade.Text = "Please Enter a valid number 1-100 ";
            } else if (numberGrade < 0 || numberGrade > 100)
            {


                //Declare the Grade using if else  - if block

                //Output The Letter
            }

        }
    
