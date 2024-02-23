namespace Dgmjr.EntityFrameworkCore.Migrations;

public static class MigrationBuilderExtensions
{
    public static void CreateView(this MigrationBuilder migrationBuilder, string schema, string name, string selectStatement)
    {
        migrationBuilder.Operations.Add(new CreateViewOperation(schema, name, selectStatement));
    }

    public static void DropView(this MigrationBuilder migrationBuilder, string schema, string name)
    {
        migrationBuilder.Operations.Add(new DropViewOperation(schema, name));
    }

    public static void DropProcedure(this MigrationBuilder migrationBuilder, string schema, string name)
    {
        migrationBuilder.Operations.Add(new DropProcedureOperation(schema, name));
    }

    public static void DropFunction(this MigrationBuilder migrationBuilder, string schema, string name)
    {
        migrationBuilder.Operations.Add(new DropFunctionOperation(schema, name));
    }

    public static void CreateProcedure(this MigrationBuilder migrationBuilder, string schema, string name, string[] args, string sql)
    {
        migrationBuilder.Operations.Add(new CreateProcedureOperation(schema, name, args.Select(arg => (SqlArgument)arg).ToArray(), sql));
    }
    public static void CreateProcedure(this MigrationBuilder migrationBuilder, MethodInfo mi, string schema, string name, string sql)
    {
        migrationBuilder.Operations.Add(new CreateProcedureOperation(mi, sql, schema, name));
    }
    public static void CreateFunction(this MigrationBuilder migrationBuilder, string schema, string name, string[] args, string returnType, string sql)
    {
        migrationBuilder.Operations.Add(new CreateFunctionOperation(schema, name, args.Select(arg => (SqlArgument)arg).ToArray(), returnType, sql));
    }
    public static void CreateFunction(this MigrationBuilder migrationBuilder, MethodInfo mi, string schema, string name, string sql)
    {
        migrationBuilder.Operations.Add(new CreateFunctionOperation(mi, sql, schema, name));
    }
}
