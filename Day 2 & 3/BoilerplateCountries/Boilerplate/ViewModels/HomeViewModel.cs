using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Boilerplate.Domain;
using Boilerplate.Services;
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

        public ObservableCollection<Country> Countries { get; private set; }

        public HomeViewModel()
        {
            WelcomeMessage = "Hello World";
        }

        public async Task InitAsync()
        {
            Countries = new ObservableCollection<Country>();

            var countriesService = new CountriesService();

            var countries = await countriesService.GetCountriesAsync();

            foreach (var country in countries)
            {

                Countries.Add(country);
                await Task.Delay(1000);
            }

        }
    }
}