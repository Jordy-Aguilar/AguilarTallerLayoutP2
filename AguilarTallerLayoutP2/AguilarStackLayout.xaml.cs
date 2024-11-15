namespace AguilarTallerLayoutP2;

public partial class AguilarStackLayout : ContentPage
{
	public AguilarStackLayout()
	{
		InitializeComponent();
	}

    private void BotonStackLayout_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AguilarFlexLayout());
    }
}