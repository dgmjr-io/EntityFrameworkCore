using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dgmjr.EntityFrameworkCore.Migrations;

#if !NETSTANDARD2_1_OR_GREATER
public class CustomSqlMigrationsGenerator(
    MigrationsSqlGeneratorDependencies dependencies,
    IMigrationsAnnotationProvider migrationsAnnotations
) : SqlServerMigrationsSqlGenerator(dependencies, migrationsAnnotations)
#elif NETSTANDARD2_1_OR_GREATER && !NET8_0_OR_GREATER
public class CustomSqlMigrationsGenerator(
    MigrationsSqlGeneratorDependencies dependencies,
    IRelationalAnnotationProvider annotationsProvider
) : SqlServerMigrationsSqlGenerator(dependencies, annotationsProvider)
#elif NET8_0_OR_GREATER
public class CustomSqlMigrationsGenerator(
    MigrationsSqlGeneratorDependencies dependencies,
    ICommandBatchPreparer commandBatchPreparer
) : SqlServerMigrationsSqlGenerator(dependencies, commandBatchPreparer)
#else
#error "Unsupported target framework"
#endif
{
    protected ISqlGenerationHelper SqlHelper => Dependencies.SqlGenerationHelper;

    protected override void Generate(
        MigrationOperation operation,
        IModel model,
        MigrationCommandListBuilder builder
    )
    {
        if (operation is CreateFunctionOperation cfo)
        {
            builder.Append(cfo.Sql).Append(SqlHelper.StatementTerminator).EndCommand();
        }
        else if (operation is DropFunctionOperation dfo)
        {
            builder.Append(dfo.Sql).Append(SqlHelper.StatementTerminator).EndCommand();
        }
        else
        {
            base.Generate(operation, model, builder);
        }
    }
}
