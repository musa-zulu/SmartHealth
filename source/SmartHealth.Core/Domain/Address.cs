using System;

namespace SmartHealth.Core.Domain
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int Code { get; set; }
    }
}
