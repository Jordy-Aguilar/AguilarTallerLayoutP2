namespace AguilarTallerLayoutP2;

public partial class AguilarFlexLayout : ContentPage
{
	public AguilarFlexLayout()
	{
		InitializeComponent();
	}
    
    private void BotonFlexLayout_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AguilarAbsoluteLayout());
    }
}