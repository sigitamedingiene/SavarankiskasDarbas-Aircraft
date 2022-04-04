using System;

namespace SavarankiskasDarbas.Bussnes
{
    public class Aircraft
    { 
       public int TailNumber { get; }
       public Model Model { get; }
       public Company Company { get; }

        public Aircraft (int tailNumber, Model model, Company company)
        {
            TailNumber = tailNumber;
            Model = model;
            Company = company;
        }
    }
}
