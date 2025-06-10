namespace Factorial_income
{
    public partial class MainPage : ContentPage
    {
        int count = 0;


        public MainPage()
        {

        }

      //  private void InitializeComponent()
        
         //   throw new NotImplementedException();
        


        private void CalculateFactorial_Clicked(object sender, EventArgs e)
        {

            if (int.TryParse(txtNumberEntry.Text, out int number))
            {
                if (number < 0)
                {
                    lblResult.Text = "The Factorial of 0 is 1";
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        factorial = factorial * i;
                    }
                    lblResult.Text = $"The factorial of {number} is {factorial}.";

                }
            }else

                {

                lblResult.Text = "Invalid Input. Please enter a whole number";
                }

            }
        private void GoToIncomeTaxPages_Clicked(object sender, EventArgs e)
        {

        }
        }
    }




