using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class EmissionTypes
    {
        [Key]
        public string EmissionTypeID { get; set; }

        public string EmissionType { get; set; }
    }
}
