namespace schoolAdminstration;

public partial class attendance1 : ContentPage
{
	public attendance1()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//attendance2");
    }
}