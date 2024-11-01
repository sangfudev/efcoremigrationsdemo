
# Initial Database Setup using Code First with Entity Framework Core
### This guide explains how to create a database instance together with some sample tables using code first principle in Entity Framework Core. 
#### 1. Check that your project references the following nuget packages:
	-microsoft.entityframeworkcore.design
	-microsoft.entityframeworkcore.sqlserver


#### 2. Install dotnet tools by using this command:
	dotnet tool install --global dotnet-ef

#### 3. Install Migrations in your project if it doesnt already exists:
	dotnet ef migrations add InitialCreate

#### 4. Create the database and update the db:
	dotnet ef database update

#### You should now have created a database instance in SQL Server with tables according to the entity classes in this project. Note that database name is set in the connectionstring in the db context class file.

# How to Create a new Migration
#### When its time to change any of the attributes in the entity model, simply make the changes in the entities and run the following command:
	dotnet ef migrations add NameOfMyMigration
#### This will add a new migration cs file containing the updates in the Migrations folder. To run the migration changes and update the database run the following:
	dotnet ef database update