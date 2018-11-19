using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Order.Models
{
    public sealed class AllOrders
    {
        private ObservableCollection<AllOrderPerPerson> _AllFoodOrders = new ObservableCollection<AllOrderPerPerson>();
        public ObservableCollection<AllOrderPerPerson> AllFoodOrders
        {
            get { return _AllFoodOrders; }
            set { _AllFoodOrders = value; }
        }
        private static AllOrders instance = null;
        private static readonly object padlock = new object();
        AllOrders()
        {

        }
        public static AllOrders Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new AllOrders();
                    }
                    return instance;
                }
            }
        }
    }
}
