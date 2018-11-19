using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;
using System.Collections.ObjectModel;
using Menu_Order.Models;
using System.Windows;

namespace Menu_Order.ViewModels
{
    class PlaceNewOrderViewModel : PropertyChangedBase
    {
        private int _SelectedIndex;
        private int _SelectedIndexGrid;
        private int _Quantity;
        private ObservableCollection<Order> _Orders = new ObservableCollection<Order>();
        private AllFoodItems Item = AllFoodItems.Instance;
        private ObservableCollection<string> _FoodNames = new ObservableCollection<string>();
        private AllOrderPerPerson PersonOrders = new AllOrderPerPerson();
        public ObservableCollection<string> FoodNames
        {
            get { return _FoodNames; }
            set { _FoodNames = value;NotifyOfPropertyChange(() => FoodNames); }
        }
        
        public void getNames()
        {
            foreach(FoodItems I in Item.Items)
            {
                if (FoodNames.Contains(I.FoodName) == false)
                {
                    FoodNames.Add(I.FoodName);
                }
            }
        }
        public ObservableCollection<Order> Orders
        {
            get { return _Orders; }
            set { _Orders = value;NotifyOfPropertyChange(() => Orders); }
        }
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set { _SelectedIndex = value; NotifyOfPropertyChange(() => SelectedIndex); }
        }
        public int SelectedIndexGrid
        {
            get { return _SelectedIndexGrid; }
            set { _SelectedIndexGrid = value; NotifyOfPropertyChange(() => SelectedIndexGrid); }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set
            {
                _Quantity = value;
                NotifyOfPropertyChange(() => Quantity);
            }
        }
        public void AddItem()
        {
            
            Order O = new Order();
            O.FoodName = Item.Items.ElementAt(SelectedIndex).FoodName;
            O.Quantity = Quantity;
            O.Price = Item.Items.ElementAt(SelectedIndex).fPrice * Quantity;
            Orders.Add(O);
            PersonOrders.Orders.Add(O);
        }
        public void PlaceOrder()
        {
            AllOrders All = AllOrders.Instance;
            PersonOrders.OrderID = All.AllFoodOrders.Count + 1;
            All.AllFoodOrders.Add(PersonOrders);
            foreach(Order O in Orders.ToList())
            {
                Orders.Remove(O);
            }
            PersonOrders = new AllOrderPerPerson();
            MessageBox.Show("Order Placed");
        }
        
    }
}
