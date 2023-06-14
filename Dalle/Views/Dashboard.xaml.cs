using Dalle.Models;
using System.Collections.ObjectModel;

namespace Dalle.Views;

public partial class Dashboard : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }
	public Dashboard()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}

    private void LoadData()
    {
		Profiles = new ObservableCollection<Profile>
		{
			new Profile
			{
				Name = "Heri",
				ProfileImage = "heri.jfif",
				NoPhotos = 12
			},
            new Profile
            {
                Name = "Jacky",
                ProfileImage = "jacky.jfif",
                NoPhotos = 4
            },
            new Profile
            {
                Name = "Salim",
                ProfileImage = "dennis.jfif",
                NoPhotos = 17
            },
            new Profile
            {
                Name = "Frank",
                ProfileImage = "heri.jfif",
                NoPhotos = 9
            },
            new Profile
            {
                Name = "Dennis",
                ProfileImage = "dennis.jfif",
                NoPhotos = 7
            },
            new Profile
            {
                Name = "Omega",
                ProfileImage = "hamida.jfif",
                NoPhotos = 3
            },
            new Profile
            {
                Name = "Hamida",
                ProfileImage = "dennis.jfif",
                NoPhotos = 5
            }
        };
        GeneratedImages = new ObservableCollection<GeneratedImage>
        {
            new GeneratedImage
            {
                ImagePath = "uno.jfif",
                MainKeyWord = "Tree",
                Keywords = new List<string>{"Oil paint", "River", "Sunset", "Mountains"}
            },
            new GeneratedImage
            {
                ImagePath = "deux.jfif",
                MainKeyWord = "Large Tree",
                Keywords = new List<string>{"Swamp", "River", "Flower"}
            },
            new GeneratedImage
            {
                ImagePath = "tres.jfif",
                MainKeyWord = "Waterfall",
                Keywords = new List<string>{"River", "Mountains", "Forest"}
            },
            new GeneratedImage
            {
                ImagePath = "quatre.jfif",
                MainKeyWord = "Boat",
                Keywords = new List<string>{"Sea", "Sunset", "Mountains"}
            },
        };
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Task.Delay(500);
        Navigation.PushAsync(new GenerationsOptionsView());
    }
}