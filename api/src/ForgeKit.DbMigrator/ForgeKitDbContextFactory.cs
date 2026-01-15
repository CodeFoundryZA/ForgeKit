using ForgeKit.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ForgeKit.DbMigrator;

public sealed class ForgeKitDbContextFactory : IDesignTimeDbContextFactory<ForgeKitDbContext>
{
    public ForgeKitDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ForgeKitDbContext>();
        optionsBuilder.UseNpgsql(
            BuildConnectionString(),
            options => options.MigrationsAssembly("ForgeKit.DbMigrator"));

        return new ForgeKitDbContext(optionsBuilder.Options);
    }

    private static string BuildConnectionString()
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
}
