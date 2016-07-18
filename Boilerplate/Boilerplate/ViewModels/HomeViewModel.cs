using System;
using GalaSoft.MvvmLight;

namespace Boilerplate.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private string _welcomeMessage;
        public string WelcomeMessage
        {
            get
            {
                return _welcomeMessage;
            }

            set
            {
                Set(() => WelcomeMessage, ref _welcomeMessage, value);
            }
        }

        public HomeViewModel()
        {
            WelcomeMessage = "Hello World";
        }
    }
}

