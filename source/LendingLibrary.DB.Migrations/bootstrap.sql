-- bootstrap script for SmartHealth application
-- Please run before attempting to start the application
------ uncomment next few lines if you'd *really* like to recreate the database
-- use master;
-- go
-- ALTER DATABASE  [SmartHealth]
-- SET SINGLE_USER
-- WITH ROLLBACK IMMEDIATE
-- drop database [SmartHealth]
-- go
------ normal creation after here
use master;
go
if not exists (select name from master..syslogins where name = 'SmartHealth')
    begin
        create login SmartHealth with password = 'sa';
    end;
go


if not exists (select name from master..sysdatabases where name = 'SmartHealth')
begin
create database SmartHealth
end;
GO

use SmartHealth
if not exists (select * from sysusers where name = 'SmartHealth')
begin
create user SmartHealth
	for login SmartHealth
	with default_schema = dbo
end;
GO
grant connect to SmartHealth
go
exec sp_addrolemember N'db_datareader', N'SmartHealth';
go
exec sp_addrolemember N'db_datawriter', N'SmartHealth';
go
exec sp_addrolemember N'db_owner', N'SmartHealth';
GO
use master;
GO

