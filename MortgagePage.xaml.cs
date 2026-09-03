using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Calculator
{
	public sealed partial class MortgagePage : Page
	{
		public MortgagePage()
		{
			this.InitializeComponent();
		}

		private void CalculateButton_Click(object sender, RoutedEventArgs e)
		{
			double yearlyIntrestRate =
				double.Parse(yearlyIntrstRateTextBox.Text);

			double principleBorrow =
				double.Parse(principleBorrowTextBox.Text);

			int Years = int.Parse(yearsTextBox.Text);
			int andMonths = int.Parse(andMonthsTextBox.Text);

			double monthlyIntrestRate = yearlyIntrestRate / 12.0;
			monthlyIntrestRate = monthlyIntrestRate * 0.01;

			int numberOfPayments = Years * 12 + andMonths;

			double numerator =
				principleBorrow *
				Math.Pow(1 + monthlyIntrestRate, numberOfPayments) *
				monthlyIntrestRate;

			double denominator =
				Math.Pow(1 + monthlyIntrestRate, numberOfPayments) - 1;

			double monthlyRepayment = numerator / denominator;

			monthlyIntrstRateTextBox.Text =
				monthlyIntrestRate.ToString();

			monthlyRepaymentTextBox.Text =
				monthlyRepayment.ToString("F2");
		}
	}
}