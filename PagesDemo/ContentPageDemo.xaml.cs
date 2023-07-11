namespace PagesDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

     private void Button_Clicked(object sender, EventArgs e)
     {
        if (string.IsNullOrEmpty(entry.Text))
        {
            DisplayAlert("Test de content page", "Entrer un texte à afficher", "OK");
            return;
        }
        DisplayAlert("Test de content page", entry.Text, "OK");
     }
}