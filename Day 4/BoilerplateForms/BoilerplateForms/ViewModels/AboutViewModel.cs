using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace BoilerplateForms.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {

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

        public async Task InitAsync()
        {
            await Task.Delay(4000);
            HelloMessage = "Hello World";
        }
    }
}

