# Using RBAC

To use RBAC, follow the steps below:

1. Create your function app
1. Give it a managed identity

1. Add data plane user and permissions for your function app to the database. Log in as the RBAC admin in the query editor, and run:
	```t-sql
	-- Make sure you are in the correct database
	USE [YourDatabaseName];
	GO

	-- Create user for the Function App system-assigned managed identity
	CREATE USER [YourFunctionAppName] FROM EXTERNAL PROVIDER;
	GO

	-- Grant CRUD permissions
	ALTER ROLE db_datareader ADD MEMBER [YourFunctionAppName];
	ALTER ROLE db_datawriter ADD MEMBER [YourFunctionAppName];

	-- Grant DDL permissions for EF Core migrations
	ALTER ROLE db_ddladmin ADD MEMBER [YourFunctionAppName];
	GO
	```  