using Syncfusion.Maui.DataGrid;

namespace DataGrid.Views;

public partial class OrderInfoRepositoryView : ContentPage
{
	public OrderInfoRepositoryView()
	{
		InitializeComponent();
		//BindingContext = vm.OrderInfoCollection;
        SfDataGrid dataGrid = new();
        Content = dataGrid;

        OrderInfoRepositoryViewModel viewModel = new OrderInfoRepositoryViewModel();
        dataGrid.ItemsSource = viewModel.OrderInfoCollection;
    }
}