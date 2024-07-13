namespace PagesDemo.Pages;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
       Button button = sender as Button;
        if (button.Text.Equals("Retour à Page 1"))
        {
           await Navigation.PopToRootAsync();
        }
        else if (button.Text.Equals("Retour à Page 2"))
        {
            await Navigation.PopAsync();
        }
        else
        {
            throw new Exception("Page de page selectionnée");
        }
    }
}