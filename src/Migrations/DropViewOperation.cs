namespace Dgmjr.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations.Operations;

public class DropViewOperation(string schema, string name) : DropOperation(View, schema, name)
{
}
