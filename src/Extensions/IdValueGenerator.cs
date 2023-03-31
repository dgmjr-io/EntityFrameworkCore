namespace Dgmjr.EntityFrameworkCore.Extensions;
using static System.Randoms;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

public class IdValueGenerator : ValueGenerator
{
    public override bool GeneratesTemporaryValues => false;

    protected override object? NextValue(EntityEntry entry)
    {
        var idProperty = entry.Property("Id");
        var _type = idProperty.Metadata.ClrType;
        return _type.Name switch
        {
            nameof(System.Byte) => NextUInt8(),
            nameof(System.SByte) => NextInt8(),
            nameof(System.Int16) => NextInt16(1000, 32000),
            nameof(System.UInt16) => NextUInt16(1000, 32000),
            nameof(System.Int32) => NextInt32(1000, 10000000),
            nameof(System.UInt32) => NextUInt32(1000, 10000000),
            nameof(System.Int64) => NextInt64(1000, 10000000),
            nameof(System.UInt64) => NextUInt64(1000, 10000000),
            nameof(System.String) => Guid.NewGuid().ToString(),
            _ => Guid.NewGuid()
        };
    }
}
