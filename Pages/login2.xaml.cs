namespace schoolAdminstration;

public partial class login2 : ContentPage
{
	public login2()
	{
		InitializeComponent();
	}

    private async void login_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//home");
    }
}