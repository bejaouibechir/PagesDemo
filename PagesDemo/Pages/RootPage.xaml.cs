using PagesDemo.Pages;

namespace PagesDemo;

public partial class RootPage : ContentPage
{
	public RootPage()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
		Button current= sender as Button;
		if (current.Text.Equals("Aller à Page Modale")) 
		{
            await Navigation.PushModalAsync(new ModalPage());
	        
			
        }
		else
        await Navigation.PushAsync(new SecondPage());
    }
}