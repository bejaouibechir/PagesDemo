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
}
