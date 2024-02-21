using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Microsoft.EntityFrameworkCore.Design;

public class DesignTimeDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext>
    where TContext : DbContext
{
    public virtual IConfigurationBuilder Configure(IConfigurationBuilder configBuilder)
    {
        return configBuilder
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile(
                $"appsettings.{env.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                optional: true
            )
            .AddEnvironmentVariables()
            .AddUserSecrets<TContext>()
            .AddUserSecrets(GetType().Assembly, optional: true, reloadOnChange: true);
    }

    public virtual SqlServerDbContextOptionsBuilder Configure(
        SqlServerDbContextOptionsBuilder optionsBuilder
    )
    {
        #if NET8_0_OR_GREATER
        return optionsBuilder = optionsBuilder.UseAzureSqlDefaults();
        #endif
        return optionsBuilder;
    }

    protected virtual string GetConnectionString(IConfiguration configuration)
    {
        return configuration.GetConnectionString(typeof(TContext).Name.Replace("Context", ""))
            ?? configuration.GetConnectionString(
                typeof(TContext).Name.Replace(nameof(DbContext), "")
            );
    }

    protected virtual DbContextOptionsBuilder<TContext> Configure(DbContextOptionsBuilder<TContext> builder)
    {
        return builder;
    }

    public virtual TContext CreateDbContext(string[] args)
    {
        var configuration = Configure(new ConfigurationBuilder()).AddCommandLine(args).Build();

        return (Activator.CreateInstance(
            typeof(TContext),
            Configure(new DbContextOptionsBuilder<TContext>()
                .UseSqlServer(
                    GetConnectionString(configuration)
                        ?? configuration.GetConnectionString("DefaultConnection")
                        ?? "Server=(localdb)\\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;MultipleActiveResultSets=true",
                    x => Configure(x)
                ))
                .Options
        ) as TContext)!;
    }
}
