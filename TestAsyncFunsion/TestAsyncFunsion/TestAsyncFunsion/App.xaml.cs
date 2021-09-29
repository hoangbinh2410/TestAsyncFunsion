using Prism;
using Prism.Ioc;
using TestAsyncFunsion.ViewModels;
using TestAsyncFunsion.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace TestAsyncFunsion
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDY1MDY5QDMxMzkyZTMyMmUzMGRhbHY5MHVhQVhUeEZBR2E5dTVWSDdtVFpXaG1jT0xiTzNLQ2VUQTBBMEk9");
            await NavigationService.NavigateAsync("NavigationPage/TestChip");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TestExpander, TestExpanderViewModel>();
            containerRegistry.RegisterForNavigation<TestAutoComplete, TestAutoCompleteViewModel>();
            containerRegistry.RegisterForNavigation<TestAvatar, TestAvatarViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage1, PrismContentPage1ViewModel>();
            containerRegistry.RegisterForNavigation<TestBackdrop, TestBackdropViewModel>();
            containerRegistry.RegisterForNavigation<TestBageView, TestBageViewViewModel>();
            containerRegistry.RegisterForNavigation<TestBarcode, TestBarcodeViewModel>();
            containerRegistry.RegisterForNavigation<TestBusyIndicartor, TestBusyIndicartorViewModel>();
            containerRegistry.RegisterForNavigation<TestCard, TestCardViewModel>();
            containerRegistry.RegisterForNavigation<TestCalendar, TestCalendarViewModel>();
            containerRegistry.RegisterForNavigation<TestCarousel, TestCarouselViewModel>();
            containerRegistry.RegisterForNavigation<TestChat, TestChatViewModel>();
            containerRegistry.RegisterForNavigation<TestCheckBox, TestCheckBoxViewModel>();
            containerRegistry.RegisterForNavigation<TestChip, TestChipViewModel>();
            containerRegistry.RegisterForNavigation<TestGauge, TestGaugeViewModel>();
            containerRegistry.RegisterForNavigation<TestComboBox, TestComboBoxViewModel>();
        }
    }
}
