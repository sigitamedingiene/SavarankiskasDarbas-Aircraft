using SavaramkiskasDarbas_DataAcsess;
using SavarankiskasDarbas.Bussnes;
using System;
using System.Collections.Generic;

namespace SavarankiskasDarbas
{
    internal class Program
    {
        static void Main(string[] args)
        {   CountryRepository countryRepository = new CountryRepository();
            List<Country> countryList = countryRepository.Retrieve();
          

            AircraftRepository aircraftRepository = new AircraftRepository();
            List<Aircraft> aircraftList = aircraftRepository.Retrieve();

            for (int i = 0; i < aircraftList.Count; i++)
            {
                Console.Write($"Lektuvo numeris: {aircraftList[i].TailNumber},\r\n lektuvo modelis: {aircraftList[i].Model.Number},\r\n lektuvo kompanija: {aircraftList[i].Company.Name}\r\n");
            }
            Console.WriteLine();
            for (int i = 0; i < aircraftList.Count; i++)
            {
                if (countryRepository.IsCountryInEurope(aircraftList[i].Company.Country.Code))
                {
                    Console.WriteLine($"Lektuvas Nr:{aircraftList[i].TailNumber} yra Europoje.");
                } else 
                {
                    Console.WriteLine($"Lektuvas Nr:{aircraftList[i].TailNumber} nera Europoje.");
                }
            }
            
        }
    }
} 
