namespace Dgmjr.EntityFrameworkCore.Migrations;

public static class Constants
{
    public const string CreateOrAlterFunctionPattern =
        "CREATE OR ALTER FUNCTION {0}.{1}({2}) RETURNS BIT AS BEGIN {3} END";

    public const string DropFunctionIfExistsPattern = "DROP FUNCTION IF EXISTS {0}.{1}";

    public static readonly IReadOnlyDictionary<Type, string> ClrTypeToSqlTypeMap = new Dictionary<
        Type,
        string
    >
    {
        { typeof(string), NVarCharMax.ShortName },
        { typeof(int), Int.ShortName },
        { typeof(long), BigInt.ShortName },
        { typeof(datetime), SqlDateTime.ShortName },
        { typeof(DateTimeOffset), SqlDateTimeOffset.ShortName }
    };
}
