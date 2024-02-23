namespace Dgmjr.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations.Operations;

public class DropProcedureOperation(string schema, string name) : DropOperation(Procedure, schema, name)
{

}
