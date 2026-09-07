using Calculator;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;

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
			ContentDialog dialog = new ContentDialog();

			dialog.Title = "Trip Calculator";
			dialog.Content = "Trip calculator C# code will be developed later.";
			dialog.CloseButtonText = "OK";

			dialog.ShowAsync();
		}
		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Exit();
		}
	}
}

