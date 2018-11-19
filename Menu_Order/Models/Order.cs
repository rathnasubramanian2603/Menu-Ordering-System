using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Order.Models
{
    public class Order
    {

        private string  _FoodName;
        private int _Quantity;
        private int _Price;

        public string FoodName
        {
            get { return _FoodName; }
            set { _FoodName = value; }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
    }
}
