namespace PagesDemo;

public partial class BeforeThirdPage : ContentPage
{
	public BeforeThirdPage()
	{
		InitializeComponent();
	}
    async private void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}