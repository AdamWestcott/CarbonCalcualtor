﻿using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IUnitsOfMeasurementRepository
    {
        List<UnitsOfMeasurement> GetUnitsOfMeasurements();
    }
}
