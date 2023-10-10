/*
 * EntityWithoutTimestamps.cs
 *
 *   Created: 2023-10-01-08:57:29
 *   Modified: 2023-10-10-07:12:29
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Models;

using Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
public abstract class Entity : IEntity, IEquatable<IEntity>, IComparable<IEntity>, IComparable
{
    public virtual object Id { get; set; }

    public abstract int CompareTo(IEntity? other);
    public abstract int CompareTo(object? obj);

    public virtual bool Equals(IEntity? other) => GetHashCode() == other?.GetHashCode();

    public override bool Equals(object? obj) => obj is IEntity entity && Equals(entity);

    public override int GetHashCode() => Id.GetHashCode();
}
