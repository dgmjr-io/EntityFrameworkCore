namespace Dgmjr.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations.Operations;

public class DropFunctionOperation(string schema, string name) : DropOperation(Function, schema, name)
{
}
