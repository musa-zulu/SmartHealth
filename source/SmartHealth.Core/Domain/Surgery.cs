using System;
using System.Collections.Generic;

namespace SmartHealth.Core.Domain
{
    public class Surgery : EntityBase
    {
        public Guid? PatientId { get; set; }
        public Guid SurgeryTypeId { get; set; }
        public string SurgeryRegNumber { get; set; }
        public string PhysicalAddressLine1 { get; set; }
        public string PhysicalAddressLine2 { get; set; }
        public string TelephoneExtension { get; set; }
        public SurgeryType SurgeryType { get; set; }
        public virtual Patient Patient { get; set; }
    }

    public sealed class SurgeryType : EntityBase
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public ICollection<Surgery> Surgery { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        public SurgeryType()
        {
            Surgery = new List<Surgery>();
            Appointments = new List<Appointment>();
        }
    }

    public class Appointment : EntityBase
    {
        public Guid PatientId { get; set; }
        public Guid SurgeryTypeId { get; set; }
        public bool IsPrimaryChoice { get; set; }
        public DateTime? WaitingListDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        public string AppointmentReason { get; set; }

    }
}
