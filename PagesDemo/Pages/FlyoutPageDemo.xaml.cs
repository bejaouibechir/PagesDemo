namespace PagesDemo;

public partial class FlyoutPageDemo : FlyoutPage
{
	public FlyoutPageDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Button current = sender as Button;
		if (current != null)
		{
			if (current.Text.Equals("Menu Item 1"))
			{
                Detail = new NavigationPage(new ContentPage
                {
                    Title = "Menu Item 1",
                    Content = new StackLayout
                    {
                        Children = {
                        new Label { Text = "Contenu relatif à Menu Item 1"}
                    }
                    }
                });
                IsPresented = false; // Hide the flyout menu
            }
			else
			{
                Detail = new NavigationPage(new ContentPage
                {
                    Title = "Menu Item 2",
                    Content = new StackLayout
                    {
                        Children = {
                        new Label { Text = "Contenu relatif à Menu Item 2"}
                    }
                    }
                });
                IsPresented = false; // Hide the flyout menu
            }

		}
    }
}