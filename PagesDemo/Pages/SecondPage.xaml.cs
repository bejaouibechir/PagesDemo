using PagesDemo.Pages;

namespace PagesDemo;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
      Button button = sender as Button;
        if(button.Text.Equals("Aller à Page 3"))
        {
            await Navigation.PushAsync(new ThirdPage());  
        }
        if (button.Text.Equals("Aller à Before Page 3"))
        {
            Navigation.InsertPageBefore(new BeforeThirdPage(), this);
        }
        else
        {
            throw new Exception("Aucune page n'est choisie");
        }

       
      
    }
}