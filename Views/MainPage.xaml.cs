using ForgetMeNot.ViewModels;

namespace ForgetMeNot.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainPageViewModel();
	}
}

