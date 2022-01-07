using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class UnitsOfMeasurement
    {
        [Key]
        public string UnitOfMeasurementID { get; set; }

        public string EmissionTypeID { get; set; }

        public string UnitOfMeasurement { get; set; }

        public double UnitOfMeasurementMultiplier { get; set; }
    }
}
