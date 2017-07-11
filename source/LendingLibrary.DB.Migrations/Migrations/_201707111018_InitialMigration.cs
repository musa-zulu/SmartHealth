using System;
using FluentMigrator;
using SmartHealth.DB;

namespace LendingLibrary.DB.Migrations.Migrations
{
    [Migration(201707111018)]
    public class _201707111018_InitialMigration : Migration
    {
        public override void Up()
        {
            Create.Table(DbConstants.Tables.PatientTable.TableName)
               .WithColumn(DbConstants.Tables.PatientTable.Columns.PatientId).AsGuid().PrimaryKey()
               .WithColumn(DbConstants.Tables.PatientTable.Columns.FirstName).AsString(512).NotNullable()
               .WithColumn(DbConstants.Tables.PatientTable.Columns.LastName).AsBinary(Int32.MaxValue).NotNullable()
               .WithColumn(DbConstants.Tables.PatientTable.Columns.Email).AsString(int.MaxValue).Nullable()
               .WithColumn(DbConstants.Tables.PatientTable.Columns.HomeAddress).AsString(int.MaxValue).Nullable()
               .WithColumn(DbConstants.Tables.PatientTable.Columns.WorkAddress).AsString(int.MaxValue).Nullable()
               .WithColumn(DbConstants.Tables.PatientTable.Columns.HomeNumber).AsString(10).Nullable()
               .WithColumn(DbConstants.Tables.PatientTable.Columns.WorkNumber).AsString(10).Nullable()
               .WithColumn(DbConstants.Tables.PatientTable.Columns.CellPhone).AsString(10).Nullable();              
        }

        public override void Down()
        {            
        }
    }
}
