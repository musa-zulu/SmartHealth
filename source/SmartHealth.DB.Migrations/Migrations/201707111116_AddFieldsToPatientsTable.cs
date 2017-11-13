using FluentMigrator;
using _Common = SmartHealth.DB.DbConstants.Tables.Common;

namespace SmartHealth.DB.Migrations.Migrations
{
    [Migration(201707111116)]
    public class _201707111116_AddFieldsToPatientsTable : Migration
    {
        public override void Up()
        {
            Alter.Table(DbConstants.Tables.PatientTable.TableName)
                .AddColumn(_Common.Columns.Created).AsDate().Nullable()
                .AddColumn(_Common.Columns.CreatedBy).AsString(300).Nullable()
                .AddColumn(_Common.Columns.LastModified).AsDate().Nullable()
                .AddColumn(_Common.Columns.LastModifiedUsername).AsString(300).Nullable();
        }

        public override void Down()
        {
        }
    }
}
