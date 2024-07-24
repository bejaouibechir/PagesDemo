//#define shell

namespace PagesDemo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
#if shell
        Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
        Routing.RegisterRoute(nameof(UserPage), typeof(UserPage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
#endif    
    }


    public void AddFlyoutItem(string title, string icon, Type pageType)
    {
        var flyoutItem = new FlyoutItem
        {
            Title = title,
            Icon = icon
        };

        var tab = new Tab();
        var shellContent = new ShellContent
        {
            ContentTemplate = new DataTemplate(pageType)
        };
        tab.Items.Add(shellContent);
        flyoutItem.Items.Add(tab);

        Items.Add(flyoutItem);
    }

    public void RemoveFlyoutItem(string title)
    {
        var item = Items.FirstOrDefault(i => i.Title == title);
        if (item != null)
        {
            Items.Remove(item);
        }
    }


}
