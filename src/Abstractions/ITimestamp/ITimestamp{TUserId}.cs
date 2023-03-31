using System.Data;

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// <inheritdoc cref="ITimestamp" path="/summary/node()" />
/// </summary>
/// <typeparam name="TUserId">The type of the user ID</typeparam>
public interface ITimestamp<TUserId> : ITimestamp
{
    /// <inheritdoc cref="ITimestamp.By" />
    new TUserId By { get; set; }
}
