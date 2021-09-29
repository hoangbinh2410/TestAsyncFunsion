using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestAsyncFunsion.ViewModels
{
    public class TestGaugeViewModel : ViewModelBase
    {
        public TestGaugeViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
