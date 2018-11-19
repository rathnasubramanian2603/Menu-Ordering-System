using Caliburn.Micro;
using Menu_Order.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Order.ViewModels
{
    class GenerateBillViewModel:PropertyChangedBase
    {
        private int _BillPrice;
        public int BillPrice
        {
            get { return _BillPrice; }
            set
            {
                _BillPrice = value;
                NotifyOfPropertyChange(() => BillPrice);
            }
        }
        private int _SelectedIndex;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set { _SelectedIndex = value; NotifyOfPropertyChange(() => SelectedIndex); }
        }
        private AllOrders All = AllOrders.Instance;
        private  AllOrderPerPerson _PersonOrders = new AllOrderPerPerson();
        private ObservableCollection<Order> _Orders = new ObservableCollection<Order>();
        public ObservableCollection<Order> Orders
        {
            get { return _Orders; }
            set { _Orders = value;NotifyOfPropertyChange(() => Orders); }
        }
        private ObservableCollection<int> _OrderNumbers = new ObservableCollection<int>();
        public ObservableCollection<int> OrderNumbers
        {
            get { return _OrderNumbers; }
            set { _OrderNumbers = value; NotifyOfPropertyChange(() => OrderNumbers); }
        }
        public void GenerateBill()
        {
            
            _PersonOrders = All.AllFoodOrders.ElementAt(SelectedIndex);
           /* foreach(Order O in Orders.ToList())
            {
                Orders.Remove(O);
            }*/
            Orders = _PersonOrders.Orders;
            CalculateBill();
        }
        private void CalculateBill()
        {
            BillPrice = 0;
            foreach(Order O in Orders)
            {
                BillPrice = BillPrice + O.Price;
            }
        }
        public void getOrders()
        {
            foreach(AllOrderPerPerson O in All.AllFoodOrders)
            {
                if (OrderNumbers.Contains(O.OrderID) == false)
                {
                    OrderNumbers.Add(O.OrderID);
                }
            }
        }

    }
}
