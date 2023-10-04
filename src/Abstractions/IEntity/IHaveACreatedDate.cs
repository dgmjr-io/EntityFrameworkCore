namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>Interface for an entity with <inheritdoc cref="ICreatable.Created" path="/value" /></summary>
public interface ICreatable
{
    /// <summary>Gets or sets <inheritdoc cref="ICreatable.Created" path="/value" /></summary>
    /// <value>a <see cref="ITimestamp"/> holding the details of the object's creation</value>
    ITimestamp Created { get; set; }
}

/// <summary><inheritdoc cref="ICreatable" path="/summary" /> with a user ID.</summary>
/// <typeparam name="TUserId">The type of the user ID.</typeparam>
public interface ICreatable<TUserId>
{
    /// <summary>Gets or sets a <see cref="ITimestamp"/> holding the details of the object's creation with the ID of the user who performed the operation.</summary>
    /// <value><inheritdoc cref="ICreatable.Created" /> with the ID of the user who performed the operation</value>
    ITimestamp<TUserId> Created { get; set; }
}
