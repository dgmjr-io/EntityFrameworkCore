namespace Dgmjr.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations.Operations;

public class DropFunctionOperation(string schema, string name) : SqlOperation
{
    public string Schema { get; set; } = schema;
public string Name { get; set; } = name;
public override bool IsDestructiveChange => true;

public override string Sql => Format(DropFunctionIfExistsPattern, Schema, Name);
}
