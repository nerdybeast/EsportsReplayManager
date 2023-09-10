namespace EsportsReplayManager.Pages;

public partial class SplashPage : ContentPage
{
	public SplashPage(SplashPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}