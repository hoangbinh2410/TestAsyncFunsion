using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestAsyncFunsion.Model;
using Xamarin.Forms;

namespace TestAsyncFunsion.ViewModels
{
    public class TestChipViewModel : ViewModelBase

    {
        private List<Person> _inputitem;
        public List<Person> InputItems
        {
            get { return _inputitem; }
            set { SetProperty(ref _inputitem, value); }
        }
        //private ObservableCollection<Choice> _choiceItem;
        //public ObservableCollection<Choice> ChoiceItems
        //{
        //    get { return _choiceItem; }
        //    set { SetProperty(ref _choiceItem, value); }
        //}
        private string _personimage;
        public string PersonImage
        {
            get { return _personimage; }
            set { SetProperty(ref _personimage, value); }
        }
        private string _personname;
        public string PersonName
        {
            get { return _personname; }
            set { SetProperty(ref _personname, value); }
        }
        private ObservableCollection<ImageSource> _categoryimage;
        public ObservableCollection<ImageSource> CategoryImage
        {
            get { return _categoryimage; }
            set { SetProperty(ref _categoryimage, value); }
        }
        public TestChipViewModel(INavigationService navigationService):base(navigationService)
        {
            InputItems = new List<Person>()
            {
                new Person{PersonName = "John", PersonImage = "girl2", PersonMailId = "john@emil.com" },
                new Person{PersonName = "Rose", PersonImage ="girl2", PersonMailId = "rose@emil.com"},
                new Person{PersonName = "Art", PersonImage ="girl2", PersonMailId = "rose@emil.com"},
                new Person{PersonName = "Chese", PersonImage ="girl2", PersonMailId = "rose@emil.com"}
            };
		//	ChoiceItems = new ObservableCollection<Choice>()
		//     {
		//	new Choice()
		//	{
		//		PersonName = "MEN",
		//		PersonImage = ImageSource.FromResource("girl2"),
		//		CategoryImage = new ObservableCollection<ImageSource>()
		//		{
		//			ImageSource.FromResource("girl2"),
		//			ImageSource.FromResource("girl2"),
		//			ImageSource.FromResource("girl2"),
		//			ImageSource.FromResource("ChipType_Sample.Mens.Image4.jpg")
		//		}
		//	},
		//	new Choice()
		//	{
		//		PersonName = "WOMEN",
		//		PersonImage = ImageSource.FromResource("ChipType_Sample.Girls.Image2.png"),
		//		CategoryImage = new ObservableCollection<ImageSource>()
		//		{
		//			ImageSource.FromResource("girl2"),
		//			ImageSource.FromResource("girl2"),
		//			ImageSource.FromResource("ChipType_Sample.Girls.Image3.png"),
		//			ImageSource.FromResource("ChipType_Sample.Girls.Image4.png"),
		//			ImageSource.FromResource("ChipType_Sample.Girls.Image5.png")
		//		}
		//	},
		//	new Choice()
		//	{
		//		PersonName = "KIDS",
		//		PersonImage = ImageSource.FromResource("girl2"),
		//		CategoryImage=new ObservableCollection<ImageSource>
		//		{
		//			ImageSource.FromResource("girl2"),
		//			ImageSource.FromResource("ChipType_Sample.Kids.Kid2.jpg"),
		//			ImageSource.FromResource("ChipType_Sample.Kids.Kid3.jpg"),
		//			ImageSource.FromResource("ChipType_Sample.Kids.Kid4.jpg"),
		//			ImageSource.FromResource("ChipType_Sample.Kids.Kid5.jpg"),
		//			ImageSource.FromResource("ChipType_Sample.Kids.Kid6.jpg")
		//		}
		//	},
		//	new Choice()
		//	{
		//		PersonName = "BEAUTY",
		//		PersonImage = ImageSource.FromResource("girl2"),
		//		CategoryImage=new ObservableCollection<ImageSource>()
		//		{
		//			ImageSource.FromResource("girl2"),
		//			ImageSource.FromResource("ChipType_Sample.Makeup.2.jpg"),
		//			ImageSource.FromResource("ChipType_Sample.Makeup.3.jpg"),
		//			ImageSource.FromResource("ChipType_Sample.Makeup.4.jpg")
		//		}
		//	}
		//};

		}
    }
}
