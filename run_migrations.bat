dotnet tool install -g FluentMigrator.DotNet.Cli
dotnet tool install -g Microsoft.Web.LibraryManager.Cli 

cd Migrations/
dotnet clean Migrations.csproj
dotnet restore Migrations.csproj
dotnet build Migrations.csproj
dotnet-fm migrate -p Postgres -c "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres" -a "bin/Debug/net8.0/Migrations.dll"