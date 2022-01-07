using Business.Repository.IRepository;
using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class UnitsOfMeasurementRepository : IUnitsOfMeasurementRepository
    {
        private readonly ApplicationDbContext _db;
        public UnitsOfMeasurementRepository(ApplicationDbContext db)
        {
            _db = db;
            // _mapper = mapper;
        }

        public List<UnitsOfMeasurement> GetUnitsOfMeasurements()
        {
            return _db.UnitsOfMeasurement.ToList();
        }
    }
}
