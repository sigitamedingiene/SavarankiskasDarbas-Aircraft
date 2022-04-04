using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankiskasDarbas.Bussnes
{
    public class Company
    {
        public string CompanyName { get; }
        public Country Country { get; }

        public Company (string comapnyName, Country country)
        {
            CompanyName = comapnyName;
            Country = country;
        }
    }
}
