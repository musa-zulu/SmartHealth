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

    public class SurgeryType : EntityBase
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Surgery> Surgery { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }

        public SurgeryType()
        {
            Surgery = new List<Surgery>();
            WaitingLists = new List<WaitingList>();
        }
    }

    public class WaitingList : EntityBase
    {
        public Guid PatientId { get; set; }
        public Guid SurgeryTypeId { get; set; }
        public bool IsPrimaryChoice { get; set; }
        public DateTime? WaitingListDate { get; set; }

    }
}
