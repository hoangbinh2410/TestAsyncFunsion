using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using TestAsyncFunsion.Model;

namespace TestAsyncFunsion.ViewModels
{
    public class TestCarouselViewModel : ViewModelBase
    {
        private List<CarouselModel> _imagecollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return _imagecollection; }
            set { SetProperty(ref _imagecollection, value); }
        }
        private string _image;

        public string CaImage
        {
            get { return _image; }
            set { _image = value; }
        }

        public TestCarouselViewModel(INavigationService navigationService) : base(navigationService)
        {
            ImageCollection = new List<CarouselModel>()
            {
                new CarouselModel{ CaImage= "girl2"},
                new CarouselModel{ CaImage= "girl2"},
                new CarouselModel{ CaImage= "girl2"},
                new CarouselModel{ CaImage= "girl2"}
            };

        }
    }
}
