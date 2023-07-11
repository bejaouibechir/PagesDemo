//#define contentpage
//#define flyoutpage
//#define tabbedpage
//#define navigationpage
#define shell

namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

#if contentpage
       MainPage = new ContentPageDemo();
#endif

#if flyoutpage
		MainPage = new FlyoutPageDemo();
#endif


#if navigationpage
        var navPage = new NavigationPage(new MainPage());

		  navPage.BarBackground = Colors.Chocolate;
		  navPage.BarTextColor = Colors.White;
		  MainPage = navPage;
#endif

#if tabbedpage
        MainPage = new TabbedPageDemo();
#endif
#if shell
       MainPage = new AppShell();
#endif




	}
}
