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
        private List<Country> countriesEU { get; }

        public CountryRepository()
        {
            countries = new List<Country>();
            countries.Add(new Country("LT", "Lietuva"));
            countries.Add(new Country("RU", "Russia"));

            countriesEU = new List<Country>();
            countriesEU.Add(new Country("LT", "Lietuva"));
            countriesEU.Add(new Country("LV", "Latvia"));
            countriesEU.Add(new Country("IS", "Ispanija"));
            countriesEU.Add(new Country("IT", "Italija"));
        }

        public bool IsCountryInEurope(string code)
        {   for (int i = 0; i < countriesEU.Count; i++)
            {
              if (code == countriesEU[i].Code)
                    {
                    return true;
                    }
                    else
                    {
                    return false;
                    }                     
            }
            return true;
        }

        public List<Country> Retrieve()
        {
            return countries;
        }

    }
        
}
