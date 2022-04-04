using SavarankiskasDarbas.Bussnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaramkiskasDarbas_DataAcsess
{
    public class AirCraftModelRepository
    {
        private List<Model> airCraftModels { get; }

        public AirCraftModelRepository()
        {
            airCraftModels = new List<Model>();
            airCraftModels.Add(new Model("T1-5505", "Very fast aircraft"));
            airCraftModels.Add(new Model("T2-6606", "Very slow aircraft"));
        }

        public List<Model> Retrieve()
        {
            return airCraftModels;
        }
    }
}
