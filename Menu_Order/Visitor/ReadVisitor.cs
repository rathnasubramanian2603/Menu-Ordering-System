using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu_Order.Models;

namespace Menu_Order.Visitor
{
    class ReadVisitor : Visitor
    {
        public void Visit(AllFoodItems I)
        {
            I.ReadFromFile();
        }

       
    }
}
