using SavarankiskasDarbas.Bussnes;
using System;
using System.Collections.Generic;

namespace SavaramkiskasDarbas_DataAcsess
{
    public class AircraftRepository
    {
        private List<Aircraft> airCrafts { get; }
        public Company company { get;}
        public Model model { get; }

        public AircraftRepository()
        {
            airCrafts = new List<Aircraft>();
            airCrafts.Add(new Aircraft(1, model, company));

        } // public Aircraft(int tailNumber, Model model, Company company)

        public List<Aircraft> Retrieve()
        {
            return airCrafts;
        }
    }
}
