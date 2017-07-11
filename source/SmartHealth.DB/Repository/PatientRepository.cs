using System.Linq;
using SmartHealth.Core.Domain;
using System.Collections.Generic;
using SmartHealth.Core.Interfaces.Repositories;

namespace SmartHealth.DB.Repository
{
    public class PatientRepository : IPatientRepository
    {
        readonly ISmartHealthDbContext _smartHealthDbContext;
        public PatientRepository(ISmartHealthDbContext smartHealthDbContext)
        {
            _smartHealthDbContext = smartHealthDbContext;
        }

        public List<Patient> GetAll() => _smartHealthDbContext.Patient.ToList();
    }
}
