namespace schoolAdminstration;

public partial class home : ContentPage
{
	public home()
	{
		InitializeComponent();
	}

    private async void add_new_bus_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//add_new_bus");
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//add_new_employee");
    }

    private async void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//assign_bus_to_student");
    }

    private async void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//bus_student_list");
    }

    private async void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//bus_info");
    }

    private async void ImageButton_Clicked_4(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//edit_employee");
    }

    private async void ImageButton_Clicked_5(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//student_info");
    }

    private async void ImageButton_Clicked_6(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//attendance");
    }

    private async void ImageButton_Clicked_7(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//bus_schedule");
    }

    private async void ImageButton_Clicked_8(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//bus_road_map");
    }
}