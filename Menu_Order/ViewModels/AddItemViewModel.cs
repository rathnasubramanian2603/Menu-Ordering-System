using Caliburn.Micro;
using Menu_Order.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Menu_Order.ViewModels
{
    class AddItemViewModel:PropertyChangedBase
    {
        private string _Name="";
        private string _Description="";
        private int _Price=0;
        private ObservableCollection<FoodItems> _Items = new ObservableCollection<FoodItems>();
        private int _SelectedIndex;
        private AllFoodItems Menu = AllFoodItems.Instance;

        public AddItemViewModel()
        {
            Items = Menu.Items;
        }
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set { _SelectedIndex = value; NotifyOfPropertyChange(() => SelectedIndex); }
        }
        public ObservableCollection<FoodItems> Items
        {
            get { return _Items; }
            set { _Items = value; NotifyOfPropertyChange(() => Items); }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; NotifyOfPropertyChange(() => Name); }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; NotifyOfPropertyChange(() => Description); }
        }

        public int Price
        {
            get { return _Price; }
            set { _Price = value; NotifyOfPropertyChange(() => Price); }
        }

        public void AddItem()
        {
            FoodItems Food = new FoodItems();
            Food.fPrice = this.Price;
            Food.FoodName = this.Name;
            Food.Description = this.Description;
            Food.FoodID = Items.Count+1;
            Menu.Items.Add(Food);
            ClearItem();
            Menu.serialize();
        }
        public void ClearItem()
        {
            Price = 0;
            Name = "";
            Description = "";
        }
        public void UpdateItem()
        {
           
            FoodItems Item = new FoodItems();
            Item = Items.ElementAt(SelectedIndex);
            Name = Item.FoodName;
            Description = Item.Description;
            Price = Item.fPrice;
            Menu.Items.RemoveAt(SelectedIndex);
       
            
        }
        public void DeleteItem()
        {
            
            Menu.Items.RemoveAt(SelectedIndex);
           
        }
    }
}
