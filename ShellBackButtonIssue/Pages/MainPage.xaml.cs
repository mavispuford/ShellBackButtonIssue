namespace ShellBackButtonIssue.Pages;

public partial class MainPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("OtherPage");
    }
}

