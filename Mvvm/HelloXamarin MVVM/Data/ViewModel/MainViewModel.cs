using Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;

namespace HelloAndroid.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IYoutubeService _service;

        public MainViewModel(IYoutubeService service)
        {
            _service = service;
        }

        private string _result = "Nothing yet";

        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                Set(ref _result, value);
            }
        }

        private RelayCommand _refreshCommand;

        public RelayCommand RefreshCommand
        {
            get
            {
                return _refreshCommand
                    ?? (_refreshCommand = new RelayCommand(
                    async () =>
                    {
                        try
                        {
                            Result = "Please wait";
                            Result = await _service.Refresh();
                        }
                        catch (Exception ex)
                        {
                            Result = ex.Message;
                        }
                    }));
            }
        }
    }
}