### EF Core Setup
dotnet tool install --global dotnet-ef

### Navigate to the project directory which contains .csproj file, the migrations and the dbcontext

### Create the initial migration. This needs to be created when all the models are defined, unless you want to created additional migrations or drop db.
dotnet ef migrations add InitialCreate

### Apply the migration to the database. This will create the database and apply the initial migration.
dotnet ef database update