using SavarankiskasDarbas.Bussnes;
using System;
using System.Collections.Generic;

namespace SavaramkiskasDarbas_DataAcsess
{
    public class AircraftRepository
    {
        private List<Aircraft> airCrafts { get; }
        

        public AircraftRepository()
        {
            Model model1 = new Model("T1-5505", "Very fast aircraft");
            Model model2 = new Model("T2-6606", "Very slow aircraft");

            Country country1 = new Country("LT", "Lietuva");
            Country country2 = new Country("RU", "Russia");

            Company company1 = new Company("Profitable", country1);
            Company company2 = new Company("Not profitable", country2);

            airCrafts = new List<Aircraft>();
            airCrafts.Add(new Aircraft(1, model1, company1));
            airCrafts.Add(new Aircraft(1, model2, company2));

        } // public Aircraft(int tailNumber, Model model, Company company)

        public List<Aircraft> Retrieve()
        {
            return airCrafts;
        }
    }
}
