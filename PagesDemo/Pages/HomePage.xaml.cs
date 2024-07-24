namespace PagesDemo;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    int index=0;
    
    private void AddFlyoutItem_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Ajout d'utilisateur", "Un nouveau utilisateur ajouté à l'espace", "OK");
        (App.Current.MainPage as AppShell)
			.AddFlyoutItem($"User {index++}","user.png",typeof(CustomPage));
    }

    private void RemoveFlyoutItem_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Ajout d'utilisateur", "Un nouveau utilisateur supprimé de l'espace", "OK");
        (App.Current.MainPage as AppShell)
            .RemoveFlyoutItem($"User {index}");
    }
}

public class CustomPage:ContentPage
{
    Label content;
    static int index = 0;
    
    public CustomPage(int index)
    {

    }
    
    public CustomPage()
    {
        content = new Label
        {
            Text = $"Espace réservé au user {new Random().Next(1,10000)}"
        };
        content.VerticalOptions= LayoutOptions.CenterAndExpand;
        content.HorizontalOptions = LayoutOptions.CenterAndExpand;
        content.Margin = new Thickness(20);
        content.FontSize = 25;
        Content = content;  
    }
}