using System.Data;

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// <inheritdoc cref="ITimestamp" path="/summary" />
/// </summary>
/// <typeparam name="TUserId">The type of the user ID</typeparam>
public interface ITimestamp<TUserId> : ITimestamp
{
    /// <value>the strongly-typed ID of the user who made the change</value>
    new TUserId By { get; set; }
}
