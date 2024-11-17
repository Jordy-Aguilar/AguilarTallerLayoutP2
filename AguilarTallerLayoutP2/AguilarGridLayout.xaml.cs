namespace AguilarTallerLayoutP2;

public partial class AguilarGridLayout : ContentPage
{
	public AguilarGridLayout()
	{
		InitializeComponent();
	}

    private void BotonGridLayout_Clicked_1(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AguilarStackLayout());
    }

}