using Microsoft.EntityFrameworkCore.Migrations;

namespace Dgmjr.EntityFrameworkCore.Migrations;

public static class UseCustomSqlMigrationsSqlGeneratorExtensions
{
    public static DbContextOptionsBuilder UseCustomSqlMigrationsSqlGenerator(
        this DbContextOptionsBuilder optionsBuilder
    ) => optionsBuilder.ReplaceService<IMigrationsSqlGenerator, CustomSqlMigrationsGenerator>();
}
