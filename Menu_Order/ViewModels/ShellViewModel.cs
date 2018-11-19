using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Menu_Order.ViewModels
{
    class ShellViewModel : Conductor<Object>.Collection.OneActive
    {

        private AddItemViewModel _AddFoodItem =new AddItemViewModel();
        private PlaceNewOrderViewModel _PlaceOrder=new PlaceNewOrderViewModel();
        private GenerateBillViewModel _GenerateFoodBill=new GenerateBillViewModel();

       
       public AddItemViewModel AddFoodItem
        {
            get { return _AddFoodItem; }
            set { _AddFoodItem = value; NotifyOfPropertyChange(() => AddFoodItem); }
        }
        public PlaceNewOrderViewModel PlaceOrder
        {
            get { return _PlaceOrder; }
            set { _PlaceOrder = value; NotifyOfPropertyChange(() => PlaceOrder); }
        }

        public GenerateBillViewModel GenerateFoodBill
        {
            get { return _GenerateFoodBill; }
            set { _GenerateFoodBill = value; NotifyOfPropertyChange(() => GenerateFoodBill); }
        }
        public void AddItem()
       {
            
            ActivateItem(AddFoodItem);
       }
       public void PlaceNewOrder()
       {
            PlaceOrder.getNames();
            ActivateItem(PlaceOrder);
       }
       
        public void GenerateBill()
        {
            GenerateFoodBill.getOrders();
            ActivateItem(GenerateFoodBill);
        }

    }
}
