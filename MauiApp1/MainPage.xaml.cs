using CommunityToolkit.Maui.Views;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            AbsoluteLayout absolutelayout = new AbsoluteLayout();
            absolutelayout.BackgroundColor = Colors.Green;

            MediaElement video= new MediaElement();
            video.Source = "https://test-videos.co.uk/vids/bigbuckbunny/mp4/h264/1080/Big_Buck_Bunny_1080_10s_1MB.mp4";
            video.ShouldShowPlaybackControls = false;
            video.ShouldAutoPlay = true;

            AbsoluteLayout.SetLayoutBounds(video, new Rect(0.5, 0.5, 1, 1));
            AbsoluteLayout.SetLayoutFlags(video, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.All);
            absolutelayout.Add(video);
            Content = absolutelayout;
        }

       
    }

}
