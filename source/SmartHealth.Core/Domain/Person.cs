using System;

namespace SmartHealth.Core.Domain
{
    public class Person : EntityBase
    {
        public Guid TitleId { get; set; }
        public Guid AppointmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public long HomeNumber { get; set; }
        public long WorkNumber { get; set; }
        public long CellPhone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhysicalAddressLine1 { get; set; }
        public string PhysicalAddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string FullAddress { get; set; }
        public virtual Title Title { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}