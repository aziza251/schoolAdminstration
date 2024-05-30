namespace schoolAdminstration;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    private async void next_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//login2");
    }
}