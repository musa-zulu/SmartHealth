using SmartHealth.Core.Domain;
using System.Data.Entity.ModelConfiguration;
using PatientTable = SmartHealth.DB.DbConstants.Tables.PatientTable;

namespace SmartHealth.DB.Mappings
{
    public class PatientMap : EntityTypeConfiguration<Patient>
    {
        public PatientMap()
        {
            HasKey(p => p.Id);

            ToTable(PatientTable.TableName);
            Property(p => p.Id).HasColumnName(PatientTable.Columns.Id);
            Property(p => p.FirstName).HasColumnName(PatientTable.Columns.FirstName);
            Property(p => p.LastName).HasColumnName(PatientTable.Columns.LastName);
            Property(p => p.Email).HasColumnName(PatientTable.Columns.Email);
           // Property(p => p.HomeAddress).HasColumnName(PatientTable.Columns.HomeAddress);
          //  Property(p => p.WorkAddress).HasColumnName(PatientTable.Columns.WorkAddress);
            Property(p => p.HomeNumber).HasColumnName(PatientTable.Columns.HomeNumber);
            Property(p => p.WorkNumber).HasColumnName(PatientTable.Columns.WorkNumber);
            Property(p => p.CellPhone).HasColumnName(PatientTable.Columns.CellPhone);
        }
    }
}
