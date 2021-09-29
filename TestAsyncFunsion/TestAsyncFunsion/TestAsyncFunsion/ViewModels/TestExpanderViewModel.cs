using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using TestAsyncFunsion.Model;
using Xamarin.Forms;

namespace TestAsyncFunsion.ViewModels
{
    public class TestExpanderViewModel : ViewModelBase
    {
        // Get Item 
        private ItemInfo _getitem = new ItemInfo();
        public ItemInfo GetItem
        {
            get { return _getitem; }
            set
            {
                if (_getitem != value)
                {
                    _getitem = value;
                }
                HandleSelectedItem();
            }
        }
        public void HandleSelectedItem()
        {
            var value = GetItem.Name;
            Application.Current.MainPage.DisplayAlert("Index", value, "ok");
        }
        private List<ItemInfo> _info = new List<ItemInfo>();
        public List<ItemInfo> Info
        {
            get { return _info; }
            set { _info = value; }
        }
        public TestExpanderViewModel(INavigationService navigationService): base(navigationService)
        {
            Info = new List<ItemInfo>();
            Info.Add(new ItemInfo() { Name = "Cheese burger", Description = "Hamburger accompanied with melted cheese. The term itself is a portmanteau of the words cheese and hamburger. The cheese is usually sliced, then added a short time before the hamburger finishes cooking to allow it to melt." });
            Info.Add(new ItemInfo() { Name = "Veggie burger", Description = "Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties." });
            Info.Add(new ItemInfo() { Name = "Barbecue burger", Description = "Prepared with ground beef, mixed with onions and barbecue sauce, and then grilled. Once the meat has been turned once, barbecue sauce is spread on top and grilled until the sauce caramelizes." });
            Info.Add(new ItemInfo() { Name = "Chili burger", Description = "Consists of a hamburger, with the patty topped with chili con carne." });
        }
    }
}
