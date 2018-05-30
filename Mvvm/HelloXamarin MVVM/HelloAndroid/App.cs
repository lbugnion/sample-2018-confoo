using Data.ViewModel;

namespace HelloAndroid
{
    public static class App
    {
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator 
            => _locator ?? (_locator = new ViewModelLocator());
    }
}