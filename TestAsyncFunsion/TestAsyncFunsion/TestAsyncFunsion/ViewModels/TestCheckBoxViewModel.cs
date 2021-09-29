using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TestAsyncFunsion.ViewModels
{
    public class TestCheckBoxViewModel : ViewModelBase
    {
        public Command ClickedCB { get; }
        public TestCheckBoxViewModel(INavigationService navigationService) :base(navigationService)
        {
            ClickedCB = new Command(Clickcombobox);

        }
        public async void Clickcombobox()
        {
            await Application.Current.MainPage.DisplayAlert("Day la combox", " Ok", "Ok");
        }
    }
}
