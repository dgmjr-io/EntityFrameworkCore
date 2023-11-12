namespace Dgmjr.EntityFrameworkCore.Abstractions;

public interface IEntity<TSelf, TId> : IEntity<TId>, IEquatable<IEntity<TId>>
    where TSelf : IEntity<TSelf, TId>
    where TId : IComparable, IEquatable<TId>
{ }
