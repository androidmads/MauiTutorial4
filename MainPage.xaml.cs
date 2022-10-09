namespace MauiTutorial4;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnNextBtnClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NextPage());
	}
}

