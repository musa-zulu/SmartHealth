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
                    public const string PatientId = "PatientId";
                    public const string FirstName = "FirstName";
                    public const string LastName = "LastName";
                    public const string Email = "Email";
                    public const string HomeAddress = "HomeAddress";
                    public const string WorkAddress = "WorkAddress";
                    public const string HomeNumber = "HomeNumber";
                    public const string WorkNumber = "WorkNumber";
                    public const string CellPhone = "CellPhone";
                }
            }

            public class Common
            {
                public class Columns
                {
                    public const string DateCreated = "DateCreated";
                    public const string CreatedUsername = "CreatedUsername";
                    public const string DateLastModified = "DateLastModified";
                    public const string LastModifiedUsername = "LastModifiedUsername";

                }
            }
        }
    }
}
