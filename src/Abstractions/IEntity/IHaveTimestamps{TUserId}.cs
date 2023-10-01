using System;

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// <inheritdoc cref="ICreatable" path="/summary" />
/// And <inheritdoc cref="IUpdatable" path="/summary" />
/// And <inheritdoc cref="IDeletable" path="/summary" />.
/// </summary>
public interface ITimestampable : ICreatable, IUpdatable, IDeletable { }
