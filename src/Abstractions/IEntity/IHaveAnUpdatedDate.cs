namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>Interface for an entity with <inheritdoc cref="IUpdatable.Updated" path="/value" /></summary>
public interface IUpdatable
{
    /// <value>a <see cref="ITimestamp"/> holding the details of the object's last update</value>
    ITimestamp Updated { get; set; }
}

/// <summary><inheritdoc cref="IUpdatable" path="/summary" /> and the ID of the user who updated it.</summary>
public interface IUpdatable<TUserId>
{
    /// <value><inheritdoc cref="IUpdatable.Updated" path="/value" /> and the ID of the user who performed the operation</value>
    ITimestamp<TUserId> Updated { get; set; }
}
