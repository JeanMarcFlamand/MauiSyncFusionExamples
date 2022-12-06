using DataGrid.ViewModels;

namespace DataGrid.Views;

public partial class SettingView : ContentPage
{
	public SettingView(SettingViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}
}