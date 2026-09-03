using Windows.UI.Xaml.Controls;

namespace Calculator
{
	public sealed partial class MenuPage : Page
	{
		public MenuPage()
		{
			this.InitializeComponent();
		}

		private void MortgageButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MortgagePage));
		}
	}
}