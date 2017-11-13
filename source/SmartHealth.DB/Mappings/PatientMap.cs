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
            Property(p => p.TitleId).HasColumnName(PatientTable.Columns.TitleId);
            Property(p => p.AppointmentId).HasColumnName(PatientTable.Columns.AppointmentId);
            Property(p => p.FirstName).HasColumnName(PatientTable.Columns.FirstName);
            Property(p => p.LastName).HasColumnName(PatientTable.Columns.LastName);
            Property(p => p.Initials).HasColumnName(PatientTable.Columns.Initials);
            Property(p => p.Email).HasColumnName(PatientTable.Columns.Email);
            Property(p => p.HomeNumber).HasColumnName(PatientTable.Columns.HomeNumber);
            Property(p => p.WorkNumber).HasColumnName(PatientTable.Columns.WorkNumber);
            Property(p => p.CellPhone).HasColumnName(PatientTable.Columns.CellPhone);
            Property(p => p.DateOfBirth).HasColumnName(PatientTable.Columns.DateOfBirth);
            Property(p => p.PhysicalAddressLine1).HasColumnName(PatientTable.Columns.PhysicalAddressLine1);
            Property(p => p.PhysicalAddressLine2).HasColumnName(PatientTable.Columns.PhysicalAddressLine2);
            Property(p => p.Suburb).HasColumnName(PatientTable.Columns.Suburb);
            Property(p => p.Province).HasColumnName(PatientTable.Columns.Province);
            Property(p => p.City).HasColumnName(PatientTable.Columns.City);
            Property(p => p.PostalCode).HasColumnName(PatientTable.Columns.PostalCode);
        }
    }
}
