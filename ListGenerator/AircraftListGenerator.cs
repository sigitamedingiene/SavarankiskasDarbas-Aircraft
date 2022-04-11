using SavaramkiskasDarbas_DataAcsess;
using SavarankiskasDarbas.Bussnes;
using System;
using System.Collections.Generic;
using System.IO;

namespace ListGenerator
{
    public class AircraftListGenerator
    {
        public AircraftRepository airCraftRepository {get;}

        public AircraftListGenerator()
        {
            airCraftRepository = new AircraftRepository();
            
        }

        public void GenerateList()
        {
            List<Aircraft> airCrafts = airCraftRepository.Retrieve();
            List<string> textLines = new List<string>();
            for (int i = 0; i < airCrafts.Count; i++)
            {
                textLines.Add(airCrafts[i].TailNumber.ToString());
                textLines.Add("--------------------");
                textLines.Add(airCrafts[i].Model.ToString());
                textLines.Add("--------------------");
                textLines.Add(airCrafts[i].Company.ToString());
                textLines.Add("--------------------");
            }

            var filename = "aircraftList.html";
            var path = @$"C:\Users\Vartotojas\source\repos\Saved files\{filename}";
            File.WriteAllLines(path, textLines);
        }
    }
}
