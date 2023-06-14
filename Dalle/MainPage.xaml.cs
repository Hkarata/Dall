using Dalle.Views;

namespace Dalle;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(Dashboard));
	}
}

