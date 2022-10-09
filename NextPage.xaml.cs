namespace MauiTutorial4;

public partial class NextPage : ContentPage
{
	public NextPage()
	{
		InitializeComponent();
	}

	private void OnPrevBtnClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}