﻿using Dalle.Views;

namespace Dalle;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Dashboard());
	}
}
