namespace FactorialCalc_TaxIncome
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void CalculateFactorial_Clicked(object sender, EventArgs e)
        {
           if(int.TryParse(txtNumberEntry.Text,out int number))
            {
                if (number < 0)
                {
                    lblResult.Text = "Please Enter a non Negative Number";
                }
                else if (number == 0)
                {
                    lblResult.Text = "The factorial of zero is one!";
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        factorial = factorial * i;
                    }
                    lblResult.Text = $"The factorial of {number} is {factorial}";
                }
            }
            else
            {
                lblResult.Text = "Invalid input please enter a whole number.";
            }
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
        private async void GoToIncomeTaxPage_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new incomeTaxPage());
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private void CalculateTax_Clicked(object sender, EventArgs e)
        {
          
        }
        private void CalcTax_Clicked(object sender, EventArgs e)
        { 

        }
    } 
}
