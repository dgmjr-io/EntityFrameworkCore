using Dgmjr.Abstractions;
using Dgmjr.EntityFrameworkCore.Abstractions;

namespace Dgmjr.EntityFrameworkCore;

public class Entity<TId> : IIdentifiable<TId>
    where TId : IComparable, IEquatable<TId>
{
    public TId Id { get; set; }
}
