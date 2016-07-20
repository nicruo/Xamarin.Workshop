using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace BoilerplateForms.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private string _helloMessage;
        public string HelloMessage
        {
            get
            {
                return _helloMessage;
            }
            set
            {
                Set(() => HelloMessage, ref _helloMessage, value);
            }
        }

        public RelayCommand ShowAboutViewCommand
        {
            get;
            private set;
        }

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowAboutViewCommand = CreateShowAboutViewCommand();
        }

        public async Task InitAsync()
        {
            await Task.Delay(4000);
            HelloMessage = "Hello World";
        }

        RelayCommand CreateShowAboutViewCommand()
        {
            return new RelayCommand(() =>
            {
                _navigationService.NavigateTo(ViewModelLocator.AboutViewKey);

            });
        }
    }
}

