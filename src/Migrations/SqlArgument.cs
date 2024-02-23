using System.Runtime.InteropServices;

namespace Dgmjr.EntityFrameworkCore.Migrations;

[RegexDto(SqlArgumentRegex)]
[StructLayout(LayoutKind.Auto)]
public readonly partial struct SqlArgument
{
    private readonly string _name;
    public string Name { get => _name; init => _name = value.StartsWith("@") ? value : "@" + value; }
    public string Type { get; }
    public string? Value { get; }

    public override string ToString() => $"{Name} {Type}{(Value is not null ? $" = {Value}" : "")}";

    public static implicit operator string(SqlArgument arg) => arg.ToString();

    public SqlArgument(string name, string type, string? value = null) =>
        (Name, Type, Value) = (name, type, value);

    public static implicit operator SqlArgument((string name, string type, string? value) arg) =>
        new(arg.name, arg.type, arg.value);

    public static implicit operator SqlArgument((string name, string type) arg) =>
        new(arg.name, arg.type);

    public static implicit operator SqlArgument(string arg) =>
        new(arg, "");

    public static implicit operator SqlArgument(ParameterInfo arg) =>
        new(arg.Name, ClrTypeToSqlTypeMap[arg.ParameterType]);

    private const string SqlArgumentRegex = @"(?<name>@\w+)\s+(?<type>\w+)(\s*=\s*(?<value>.*))?";
}
