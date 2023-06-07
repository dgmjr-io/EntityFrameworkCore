/*
 * Entity.cs
 *
 *   Created: 2022-12-28-04:10:43
 *   Modified: 2023-01-03-02:33:31
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


namespace Dgmjr.EntityFrameworkCore.Models;
using Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
public abstract class TimestampedEntity : IEntity, IEquatable<Entity>
{
    public virtual object Id { get; set; }
    public virtual ITimestamp Created { get; set; } = new Timestamp();
    public virtual ITimestamp Updated { get; set; } = new Timestamp();
    public virtual ITimestamp? Deleted { get; set; } = default;

    public bool Equals(Entity other) => GetType().IsAssignableFrom(other.GetType()) && Id.Equals(other.Id);

    public override int GetHashCode() => GetType().GetHashCode() ^ Id.GetHashCode();
    override public bool Equals(object? obj) => obj is Entity entity && Equals(entity);
}
