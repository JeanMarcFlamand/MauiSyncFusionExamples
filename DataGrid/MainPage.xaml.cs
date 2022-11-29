using Syncfusion.Maui.DataGrid;

namespace DataGrid;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        SfDataGrid dataGrid = new SfDataGrid();
        this.Content = dataGrid;
    }

	
}

