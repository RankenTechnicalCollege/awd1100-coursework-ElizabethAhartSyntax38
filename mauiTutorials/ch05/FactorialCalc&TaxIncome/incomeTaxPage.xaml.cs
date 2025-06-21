using System.ComponentModel.Design;

namespace FactorialCalc_TaxIncome;

public partial class incomeTaxPage : ContentPage
{
	public incomeTaxPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

	}
	private void CalcTax_Clicked(object sender, EventArgs e)
	{

	}
	private void CalculateTax_Clicked(object sender, EventArgs args)
	{
		if (decimal.TryParse(txtIncome.Text, out decimal income) || income < 0)
		{
			lblResult.Text = "Please enter a whole number";
			return;
		}
		string status = (string)PickerStatus.SelectedItem;
		decimal tax = 0;
		if (status == "single")
		{

			if (income <= 11925)
				tax = 1192.50m + (income - 11925) * 0.12m;
			else if (income <= 48475)
				tax = 5476.98m + (income - 48475) * 0.22m;
			else if (income <= 103350)
				tax = 17593.08m + (income - 103350) * 0.24m;
			else if (income <= 39713)
				tax = 1192.50m + (income - 197300) * 0.32m;
			else if (income <= 626350)
				tax = 57097.48m + (income - 250525) * 0.35m;
			else
			{
				tax = 168264.73m + (income - 626350) * 0.37m;
			}
		}
		else
		{
			if (income <= 23850)
				tax = income * 0.10m;
			else if (income <= 96950)
				tax = 2385.00m + (income - 23850) * 0.12m;
			else if (income <= 206700)
				tax = 1157.00m + (income - 96950) * 0.22m;
			else if (income <= 394600)
				tax = 36215.00m + (income - 2006700) * 0.24m;
			else if (income <= 501050)
				tax = 81391.00m + (income - 394600) * 0.32m;
			else if (income <= 751600)
				tax = 117683.20m + (income - 501850) * 0.35m;


			else
			{
				tax = 25858.45m + (income - 626350) * 0.37m;
			}
            //married
        }

		lblResult.Text = $"Your Estimated tax is{tax:c}";
	}
}