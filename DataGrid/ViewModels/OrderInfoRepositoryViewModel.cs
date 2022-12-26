using DataGrid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    public class OrderInfoRepositoryViewModel
    {
        private ObservableCollection<OrderInfoModel> orderInfo;
        public ObservableCollection<OrderInfoModel> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public OrderInfoRepositoryViewModel()
        {
            orderInfo = new ObservableCollection<OrderInfoModel>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfoModel("1001", "Jean-Marc Flamand", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfoModel("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
            orderInfo.Add(new OrderInfoModel("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
            orderInfo.Add(new OrderInfoModel("1004", "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfoModel("1005", "Tim Adams", "Sweden", "BERGS", "London"));
            orderInfo.Add(new OrderInfoModel("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfoModel("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfoModel("1008", "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfoModel("1009", "Lenny Lin", "France", "BONAP", "Marsiella"));
            orderInfo.Add(new OrderInfoModel("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin"));
            orderInfo.Add(new OrderInfoModel("1011", "Laura King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfoModel("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfoModel("1013", "Martin King", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfoModel("1014", "Gina Irene", "UK", "AROUT", "London"));
        }
    }
}
