# ForgeKit API

ForgeKit API is the backend service for the ForgeKit platform.

## Requirements
- .NET SDK 10
- PostgreSQL (Docker or local)

## Getting Started
1. Restore dependencies:
   ```bash
   dotnet restore ForgeKit.sln
   ```
2. Run migrations:
   ```bash
   export POSTGRES_HOST=localhost POSTGRES_PORT=5432 POSTGRES_DB=ForgeKitDB POSTGRES_USER=forgekit-user ES_PASSWORD="Ch1llh1S0ft!@$"
   dotnet run --project src/ForgeKit.DbMigrator/ForgeKit.DbMigrator.csproj
   ```
3. Run the API:
   ```bash  
   dotnet run --project src/ForgeKit.Api/ForgeKit.Api.csproj --urls http://localhost:5075
   ```

## Health Check
- `GET /healthz`
