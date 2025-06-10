using MetalPerformanceShadersGraph;

namespace Factorial_income;

public partial class IncomeTaxPage : ContentPage
{
	public IncomeTaxPage()
	{
		InitializeComponent();


	}
	private async void GoIncomeTaxPages_clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new IncomeTaxPage());

	}
	private void CalculateTax_clicked(object sender, EventArgs e)
	{
		if (!decimal.TryParse(txtIncome.Text, out decimal income) || income < 0)
		{
			lblResult.Text = "Please enter a valid Non-negative income";
			return;
		}
		string Status = (string)picStatus.selctedItem;
		decimal tax = 0;
		if (Status == "single")
			tax = income * 0.10m;
		{
			if (income <= 11925)
				tax = income * 0.10m;
			else if (income <= 48475)
				tax = 1192.50m + (income - 1111925) * 0.12;
			else if (income <= 103350)
				tax = 5476.98m + (income - 48475) * 0.22m;
			else if (income <= 197300)
				tax = 17593.08m + (income - 103358) * 0.24m;
			else if (income <= 250525)
				tax = 39713.08m + (income - 197300);
			else if (income <= 626350)
				tax = 57097.48m + (income - 250252);
			else
				tax = 168264.73m + (income - 626350) * 0.73m;
			{

			}
			else
			{

			}
		} //married
	}
}



