using SavaramkiskasDarbas_DataAcsess;
using SavarankiskasDarbas.Bussnes;
using System;
using System.Collections.Generic;
using System.IO;

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
                Console.Write($"Lėktuvo numeris: {aircraftList[i].TailNumber}, lėktuvo modelis: {aircraftList[i].Model.Number},\r\n Lėktuvo kompanija: {aircraftList[i].Company.Name}\r\n");
            }
            Console.WriteLine();

            List<Aircraft> aircraftModelListInEU = new List<Aircraft>();
            for (int i = 0; i < aircraftList.Count; i++)
            {
                if (countryRepository.IsCountryInEurope(aircraftList[i].Company.Country.Code))
                {
                    Model aircraftModel = new Model(aircraftList[i].Model.Number, aircraftList[i].Model.Description);
                    Country country = new Country(aircraftList[i].Company.Country.Code, aircraftList[i].Company.Country.Name);
                    Company company = new Company(aircraftList[i].Company.Name, country);
                    aircraftModelListInEU.Add(new Aircraft(aircraftList[i].TailNumber, aircraftModel, company));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Europoje esančių lėktuvų sąrašas: \r\n ");
                    Console.ResetColor();
                    Console.WriteLine($"Nr:{aircraftList[i].TailNumber}, {aircraftList[i].Model.Number}, {aircraftList[i].Model.Description}\r\n{aircraftList[i].Company.Name}, {aircraftList[i].Company.Country.Name}");
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Lektuvas Nr:{aircraftList[i].TailNumber} nera Europoje.");
                    Console.ResetColor();
                }         
            }

            
        }
    }
} 
