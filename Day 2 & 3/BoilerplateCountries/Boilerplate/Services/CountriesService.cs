using System.Collections.Generic;
using System.Threading.Tasks;
using Boilerplate.Domain;

namespace Boilerplate.Services
{
    public class CountriesService
    {
        public async Task<List<Country>> GetCountriesAsync()
        {
            await Task.Delay(1000);

            var countries = new List<Country>();

            countries.Add(new Country { Name = "Portugal" });
            countries.Add(new Country { Name = "Spain" });

            return countries;
        }
    }
}