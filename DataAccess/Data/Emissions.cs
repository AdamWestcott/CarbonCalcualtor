using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Emissions
    {
        public string EmissionType { get; set; }

        public string UnitOfMeasurement { get; set; }

        public string EmissionScope { get; set; }

        public double EmissionAmount { get; set; }

        public double EmissionMultiplier { get; set; }
    }
}
