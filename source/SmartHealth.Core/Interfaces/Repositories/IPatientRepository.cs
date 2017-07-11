using SmartHealth.Core.Domain;
using System.Collections.Generic;

namespace SmartHealth.Core.Interfaces.Repositories
{
    public interface IPatientRepository
    {
        List<Patient> GetAll();
    }
}
