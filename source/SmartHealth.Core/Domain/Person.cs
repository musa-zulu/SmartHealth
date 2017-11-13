using System;

namespace SmartHealth.Core.Domain
{
    public class Person : EntityBase
    {
        public int TitleId { get; set; }
        public virtual Title Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string FullName
        {
            get
            {
                var firstName = string.IsNullOrEmpty(FirstName) ? Initials : FirstName;
                return $"{firstName} {LastName}";
            }
        }
        public string FullNameWithTitle
        {
            get
            {
                var fullName = FullName;
                if (Title != null)
                    fullName = $"{Title.Description} {fullName}";
                return fullName;
            }
        }
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
        public string FullAddress
        {
            get
            {
                var physicalAddress1 = string.IsNullOrEmpty(PhysicalAddressLine1) ? string.Empty : PhysicalAddressLine1;
                const string newlineWithFourTabspaces = "\n\t\t\t\t";
                var physicalAddress2 = string.IsNullOrEmpty(PhysicalAddressLine2)
                    ? string.Empty
                    : newlineWithFourTabspaces + PhysicalAddressLine2;
                var suburb = string.IsNullOrEmpty(Suburb)
                    ? string.Empty
                    : newlineWithFourTabspaces + Suburb;
                var city = string.IsNullOrEmpty(City)
                    ? string.Empty
                    : newlineWithFourTabspaces + City;
                var province = string.IsNullOrEmpty(Province)
                    ? string.Empty
                    : newlineWithFourTabspaces + Province;
                var postalCode = string.IsNullOrEmpty(PostalCode)
                    ? string.Empty
                    : newlineWithFourTabspaces + PostalCode;

                var fulladdress = physicalAddress1 + physicalAddress2 + suburb + city + province + postalCode;
                return $"{fulladdress}";
            }
        }
    }
}