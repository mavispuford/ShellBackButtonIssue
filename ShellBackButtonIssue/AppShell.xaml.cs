using ShellBackButtonIssue.Pages;

namespace ShellBackButtonIssue;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(OtherPage), typeof(OtherPage));
	}
}
