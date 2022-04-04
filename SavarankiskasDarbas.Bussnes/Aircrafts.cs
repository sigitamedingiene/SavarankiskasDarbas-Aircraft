using System;

namespace SavarankiskasDarbas.Bussnes
{
    public class Aircrafts
    { 
       public int TailNumber { get; }
       public Model Model { get; }
       public Company Company { get; }

        public Aircrafts (int tailNumber, Model model, Company company)
        {
            TailNumber = tailNumber;
            Model = model;
            Company = company;
        }
    }
}
