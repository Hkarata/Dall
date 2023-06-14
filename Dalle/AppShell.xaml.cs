using Dalle.Views;

namespace Dalle;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Dashboard), typeof(Dashboard));
		Routing.RegisterRoute(nameof(GenerationsOptionsView), typeof(GenerationsOptionsView));
	}
}
