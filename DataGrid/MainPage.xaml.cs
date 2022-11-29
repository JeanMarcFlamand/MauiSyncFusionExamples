using Syncfusion.Maui.DataGrid;

namespace DataGrid;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
        SfDataGrid dataGrid = new();
        Content = dataGrid;

        OrderInfoRepositoryVewModel viewModel = new OrderInfoRepositoryVewModel();
        dataGrid.ItemsSource = viewModel.OrderInfoCollection;
    }

	
}

