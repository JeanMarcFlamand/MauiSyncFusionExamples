using Syncfusion.Maui.DataGrid;

namespace DataGrid;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
        SfDataGrid dataGrid = new SfDataGrid();
        this.Content = dataGrid;
    }

	
}

