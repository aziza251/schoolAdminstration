namespace schoolAdminstration;

public partial class attendance : ContentPage
{
	public attendance()
	{
		InitializeComponent();
	}

    private async void attendance25_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//attendance1");
    }
}