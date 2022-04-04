using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankiskasDarbas.Bussnes
{
    public class Model
    { 
        public string Number { get; }
        public string Description { get; }

        public Model (string number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
