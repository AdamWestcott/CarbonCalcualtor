using Business.Repository.IRepository;
using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
   public class EmissionTypeRepository : IEmissionTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmissionTypeRepository(ApplicationDbContext db)
        {
            _db = db;
            // _mapper = mapper;
        }

        public List<EmissionTypes> GetEmissionTypes()
        {
            return _db.EmissionType.ToList();
        }
    }
}
