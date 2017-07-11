using System;

namespace SmartHealth.Core.Domain
{
    public class Patient : EntityBase
    {
        public Guid PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public long HomeNumber { get; set; }
        public long WorkNumber { get; set; }
        public long CellPhone { get; set; }
    }
}
