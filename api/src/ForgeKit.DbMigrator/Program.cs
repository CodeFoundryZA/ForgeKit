using ForgeKit.Repositories;
using Microsoft.EntityFrameworkCore;

var connectionString =
    Environment.GetEnvironmentVariable("CHILLHI_CONNECTION_STRING")
    ?? BuildConnectionString();

static string BuildConnectionString()
{
    var host = Environment.GetEnvironmentVariable("POSTGRES_HOST") ?? "localhost";
    var port = Environment.GetEnvironmentVariable("POSTGRES_PORT") ?? "5432";
    var database = Environment.GetEnvironmentVariable("POSTGRES_DB") ?? "forgekit";
    var user = Environment.GetEnvironmentVariable("POSTGRES_USER") ?? "postgres";
    var password =
        Environment.GetEnvironmentVariable("POSTGRES_PASSWORD")
        ?? Environment.GetEnvironmentVariable("ES_PASSWORD")
        ?? "postgres";

    return $"Host={host};Port={port};Database={database};Username={user};Password={password}";
}

var options = new DbContextOptionsBuilder<ForgeKitDbContext>()
    .UseNpgsql(connectionString, optionsBuilder => optionsBuilder.MigrationsAssembly("ForgeKit.DbMigrator"))
    .Options;

await using var context = new ForgeKitDbContext(options);
await context.Database.MigrateAsync();
