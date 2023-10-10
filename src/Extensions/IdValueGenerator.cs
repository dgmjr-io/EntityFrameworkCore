using System.Collections.Generic;

namespace Dgmjr.EntityFrameworkCore.Extensions;

using static Randoms;
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
            nameof(Byte) => NextUInt8(byte.MinValue, byte.MaxValue),
            nameof(SByte) => NextInt8(sbyte.MinValue, sbyte.MaxValue),
            nameof(Int16) => NextInt16(1000, short.MaxValue),
            nameof(UInt16) => NextUInt16(1000, ushort.MaxValue),
            nameof(Int32) => NextInt32(1000, 99999999),
            nameof(UInt32) => NextUInt32(1000, 99999999),
            nameof(Int64) => NextInt64(1000, 99999999),
            nameof(UInt64) => NextUInt64(1000, 99999999),
            nameof(String) => Guid.NewGuid().ToString(),
            _ => Guid.NewGuid()
        };
    }
}
