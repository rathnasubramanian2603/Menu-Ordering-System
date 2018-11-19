using Menu_Order.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Order.Visitor
{
    public interface Visitor
    {
        void Visit(AllFoodItems I);
       
    }
}
