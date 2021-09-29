using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using TestAsyncFunsion.Model;

namespace TestAsyncFunsion.ViewModels
{
    public class TestAutoCompleteViewModel : ViewModelBase
    {
        private List<Employee> _employeecollection;
        public List<Employee> EmployeeCollection
        {
            get { return _employeecollection; }
            set { SetProperty(ref _employeecollection, value); }
        }
        public TestAutoCompleteViewModel(INavigationService navigationService) : base(navigationService)
        {
            EmployeeCollection = new List<Employee>()
            {
                new Employee {ID = 1, Name = "Eric", Image = "girl2"},
                new Employee {ID = 2, Name = "James" , Image = "girl2"},
                new Employee {ID = 3, Name = "Jacob", Image = "girl2"},
                new Employee {ID = 4, Name = "Lucas", Image = "girl2"},
                new Employee {ID = 5, Name = "Mark", Image = "girl2"},
                new Employee {ID = 6, Name = "Aldan", Image = "girl2"},
                new Employee {ID = 7, Name = "Aldrin", Image = "girl2"},
                new Employee {ID = 9, Name = "Aaron", Image = "girl2"}
            };
        }
    }
}
