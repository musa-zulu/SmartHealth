using System.Linq;
using SmartHealth.Core.Domain;
using System.Collections.Generic;
using SmartHealth.Core.Interfaces.Repositories;
using System;

namespace SmartHealth.DB.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ISmartHealthDbContext _smartHealthDbContext;
        public PatientRepository(ISmartHealthDbContext smartHealthDbContext)
        {
            _smartHealthDbContext = smartHealthDbContext;
        }

        public List<Patient> GetAll() => _smartHealthDbContext.Patient.ToList();

        public void Save(Patient patient)
        {
            if (patient == null) throw new ArgumentNullException(nameof(patient));
            patient.Id = Guid.NewGuid();
            _smartHealthDbContext.Patient.Add(patient);
            _smartHealthDbContext.SaveChanges();
        }
    }
}
