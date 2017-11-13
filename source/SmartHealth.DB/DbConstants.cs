namespace SmartHealth.DB
{
    public class DbConstants
    {
        public class Tables
        {
            public class PatientTable
            {
                public const string TableName = "Patient";
                public class Columns
                {
                    public const string Id = "Id";
                    public const string TitleId = "TitleId";
                    public const string AppointmentId = "AppointmentId";
                    public const string FirstName = "FirstName";
                    public const string LastName = "LastName";
                    public const string Initials = "Initials";
                    public const string Email = "Email";
                    public const string HomeAddress = "HomeAddress";
                    public const string WorkAddress = "WorkAddress";
                    public const string HomeNumber = "HomeNumber";
                    public const string WorkNumber = "WorkNumber";
                    public const string CellPhone = "CellPhone";
                    public const string DateOfBirth = "DateOfBirth";
                    public const string PhysicalAddressLine1 = "PhysicalAddressLine1";
                    public const string PhysicalAddressLine2 = "PhysicalAddressLine2";
                    public const string Suburb = "Suburb";
                    public const string Province = "Province";
                    public const string City = "City";
                    public const string PostalCode = "PostalCode";
                }
            }

            public class Common
            {
                public class Columns
                {
                    public const string Created = "Created";
                    public const string LastModified = "LastModified";
                    public const string Enabled = "Enabled";
                    public const string CreatedBy = "CreatedBy";
                    public const string LastModifiedUsername = "LastModifiedUsername";

                }
            }
        }
    }
}
