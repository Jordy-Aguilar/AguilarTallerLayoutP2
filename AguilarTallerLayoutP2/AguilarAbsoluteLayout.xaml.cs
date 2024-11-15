namespace AguilarTallerLayoutP2;

public partial class AguilarAbsoluteLayout : ContentPage
{
	public AguilarAbsoluteLayout()
	{
		InitializeComponent();
	}

    private void BotonAbsoluteLayout_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AguilarGridLayout());
    }
}