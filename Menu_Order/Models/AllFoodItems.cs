using Menu_Order.Visitor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Menu_Order.Models
{
    public sealed class AllFoodItems
    {
        private ObservableCollection<FoodItems> _Items = new ObservableCollection<FoodItems>();

        private static AllFoodItems instance = null;
        private static readonly object padlock = new object();
        private ReadVisitor V = new ReadVisitor();
        AllFoodItems()
        {
            
        }
        public void Accept(Visitor.Visitor v)
        {
            v.Visit(instance);
        }
        public static AllFoodItems Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new AllFoodItems();
                        instance.Accept(instance.V);
                    }
                    return instance;
                }
            }
        }


        public ObservableCollection<FoodItems> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }

        public string getFoodNamebyID(int FoodID)
        {
            foreach(FoodItems i in Items)
             {
                 if(i.FoodID==FoodID)
                {
                    return i.FoodName;
                }
             }
            return null;
        }
        public int getFoodPricebyID(int FoodID)
        {
            foreach (FoodItems i in Items)
            {
                if (i.FoodID == FoodID)
                {
                    return i.fPrice;
                }
            }
            return -1;
        }
        public void  ReadFromFile()
        {
            string output = File.ReadAllText("AllFoodITems.json");
            Items = JsonConvert.DeserializeObject<ObservableCollection<FoodItems>>(output);
         

        }
        public void serialize()
        {
            string output = JsonConvert.SerializeObject(_Items);
            File.WriteAllText("AllFoodITems.json", output);
           
        }
    }
}
