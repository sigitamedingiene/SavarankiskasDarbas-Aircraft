using SavarankiskasDarbas.Bussnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaramkiskasDarbas_DataAcsess
{
    public class CountryRepository
    {
        private List<Country> countries { get; }

        public CountryRepository()
        {
            countries = new List<Country>();
            countries.Add(new Country("LT", "Lietuva"));
            countries.Add(new Country("RU", "Russia"));
        }

        public List<Country> Retrieve()
        {
            return countries;
        }
    }
}
