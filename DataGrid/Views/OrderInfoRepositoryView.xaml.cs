namespace DataGrid.Views;

public partial class OrderInfoRepositoryView : ContentPage
{
	public OrderInfoRepositoryView(OrderInfoRepositoryViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm.OrderInfoCollection;
	}
}