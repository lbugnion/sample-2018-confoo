using Data.Model;
using GalaSoft.MvvmLight.Ioc;

namespace Data.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            SimpleIoc.Default.Register<IYoutubeService, YoutubeService>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }
    }
}
