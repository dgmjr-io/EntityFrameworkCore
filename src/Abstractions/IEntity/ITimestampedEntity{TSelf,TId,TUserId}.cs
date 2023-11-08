namespace Dgmjr.EntityFrameworkCore.Abstractions;

public interface ITimestampedEntity<TSelf, TId, TUserId> : ITimestampedEntity<TId, TUserId>
    where TSelf : ITimestampedEntity<TSelf, TId, TUserId>
    where TId : IComparable, IEquatable<TId> { }
