using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Order.Models
{
    public class AllOrderPerPerson
    {
        private int _OrderID;
        private ObservableCollection<Order> _Orders=new ObservableCollection<Order>();

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }
        public ObservableCollection<Order> Orders
        {
            get { return _Orders; }
            set { _Orders=value;}
        }
    }
}
