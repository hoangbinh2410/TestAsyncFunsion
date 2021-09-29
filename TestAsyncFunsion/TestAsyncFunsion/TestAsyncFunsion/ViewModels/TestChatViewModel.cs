using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Syncfusion.XForms.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TestAsyncFunsion.ViewModels
{
    public class TestChatViewModel : ViewModelBase
    {
        public Command TappedCommand { get; }
        public TestChatViewModel(INavigationService navigationService) :base(navigationService)
        {
            TappedCommand = new Command(MessageTapped);
        }
        private void MessageTapped(object args)
        {
            var MessageTappedArgs = args as MessageTappedEventArgs;
            App.Current.MainPage.DisplayAlert("Message", "Tapped on Message :" + MessageTappedArgs.Message.Author.Name, "Ok");
        }
    }
}
