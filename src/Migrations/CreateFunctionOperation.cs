namespace Dgmjr.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations.Operations;

public class CreateFunctionOperation(string schema, string name, string arguments, string body)
    : SqlOperation
{
    public string Schema { get; set; } = schema;
    public string Name { get; set; } = name;
    public string Arguments { get; set; } = arguments;
    public string Body { get; set; } = body;

    public override string Sql =>
        Format(CreateOrAlterFunctionPattern, Schema, Name, Arguments, Body);

    public CreateFunctionOperation(
        MethodInfo mi,
        string body,
        string schema = DboSchema.ShortName,
        string? name = default,
        string? arguments = default
    )
        : this(
            schema,
            name ?? mi.Name,
            arguments
                ?? mi.GetParameters()
                    .Select(p => $"@{p.Name} {ClrTypeToSqlTypeMap[p.ParameterType]}")
                    .Join(", "),
            body
        ) { }
}
