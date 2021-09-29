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
    public class TestComboBoxViewModel : ViewModelBase
    {
       
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        private List<Employee> _PersonCollection;
        public List<Employee> PersonCollection
        {
            get { return _PersonCollection; }
            set { SetProperty(ref _PersonCollection, value); }
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }
        public TestComboBoxViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            
            PersonCollection = new List<Employee>()
            {
                new Employee { Name = "ha", Image="girl2"},
                new Employee { Name = "ha1", Image="girl2"},
                new Employee { Name = "ha2", Image="girl2"},
                new Employee { Name = "ha3", Image="girl2"},
                new Employee { Name = "ha4", Image="girl2"}
            };

        }
    }
}
