using SavarankiskasDarbas.Bussnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaramkiskasDarbas_DataAcsess
{
    public class CompanyRepository
    {
        private List<Company> companies { get; }

        public CompanyRepository()
        {
            Country country1 = new Country("LT", "Lietuva");
            Country country2 = new Country("RU", "Russia");

            companies = new List<Company>();
            companies.Add(new Company("LT", country1));
            companies.Add(new Company("RU", country2));
        }

        public List<Company> Retrieve()
        {
            return companies;
        }
    }
}
