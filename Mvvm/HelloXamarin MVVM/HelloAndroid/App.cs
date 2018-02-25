using HelloAndroid.ViewModel;

namespace HelloAndroid
{
    public class App
    {
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator 
            => _locator ?? (_locator = new ViewModelLocator());
    }
}