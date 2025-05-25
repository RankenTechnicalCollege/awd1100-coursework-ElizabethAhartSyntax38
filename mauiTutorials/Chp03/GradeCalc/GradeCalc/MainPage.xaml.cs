using Microsoft.Windows.Widgets.Feeds.Providers;

namespace GradeCalc
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
            count+=2;

            
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            lblLetterGrade.Text = "Hello World";
        }
        //Get input from user 
       
        int numberGrade;
        
        
        //Determine Grade using if/else-if block
        //Output the letter
    }
}
