using DataGrid.Views;


namespace DataGrid;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(OrderInfoRepositoryView),typeof(OrderInfoRepositoryView));
        Routing.RegisterRoute(nameof(SettingView), typeof(SettingView));
        Routing.RegisterRoute(nameof(About), typeof(About));
    }
}
