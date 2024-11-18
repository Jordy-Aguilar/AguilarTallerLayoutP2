namespace AguilarTallerLayoutP2;

public partial class AguilarFlexLayout : ContentPage
{
	public AguilarFlexLayout()
	{
		InitializeComponent();
	}
    private async void OnImageTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AguilarAbsoluteLayout());
    }
    private void BotonFlexLayout_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AguilarAbsoluteLayout());
    }
}