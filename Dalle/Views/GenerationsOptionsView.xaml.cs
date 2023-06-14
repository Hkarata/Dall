using Dalle.Models;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Dalle.Views;

public partial class GenerationsOptionsView : ContentPage
{
	public List<string> Options { get; set; }
	public List<ArtStyle> Styles { get; set; }
	public GenerationsOptionsView()
	{
		InitializeComponent();
		FillOptions();
		BindingContext = this;


		Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("MyCustomiation", (handler, view) =>
		{
#if ANDROID
			handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif IOS || MACCATALYST

#elif WINDOWS

#endif
		});


	}

	private void FillOptions()
	{
		Options = new List<string>
		{ 
			"World", "Winter", "Trees", "Sea", "Ocean", "Flowers", "Forest", "Sunset"
		};

		Styles = new List<ArtStyle> 
		{ 
			new ArtStyle {Name="Cartoon", ImageUrl="cartoon.jpg"},
			new ArtStyle {Name="Realistic", ImageUrl="realistic.jfif"},
			new ArtStyle {Name="Watercolor Art", ImageUrl="water.jfif"},
			new ArtStyle {Name="Isometric", ImageUrl="isometric.jfif"},
			new ArtStyle {Name="Pop Art", ImageUrl="popa.jfif"},
			new ArtStyle {Name="Surrealism", ImageUrl="sur.jfif"},
			new ArtStyle {Name="Minimalism", ImageUrl="mim.jfif"},
			new ArtStyle {Name="Funko", ImageUrl="funk.jfif"},
			new ArtStyle {Name="Anime", ImageUrl="anime.jpg"},
			new ArtStyle {Name="Storybook", ImageUrl="sb.jpg"}
		};
	}
}