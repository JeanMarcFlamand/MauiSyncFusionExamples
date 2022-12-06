using DataGrid.ViewModels;

namespace DataGrid.Views;

public partial class About : ContentPage
{
	public About(AboutViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}
}