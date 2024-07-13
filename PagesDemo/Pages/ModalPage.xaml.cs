namespace PagesDemo.Pages;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}