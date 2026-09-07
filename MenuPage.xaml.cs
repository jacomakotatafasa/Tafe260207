using Calculator;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

namespace Calculator
{
	public sealed partial class MenuPage : Page
	{
		public MenuPage()
		{
			this.InitializeComponent();
		}

		private void MathCalculator_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainPage));
		}

		private void MortgageCalculator_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MortgagePage));
		}

		private void CurrencyCalculator_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(CurrencyConverterPage));
		}
private async void TripCalculator_Click(object sender, RoutedEventArgs e)
{
    var dialog = new MessageDialog("Trip calculator C# code will be developed later.");
    await dialog.ShowAsync();
}
		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Exit();
		}
	}
}

