/*
 * Entity{TId}.cs
 *
 *   Created: 2022-12-28-04:10:43
 *   Modified: 2022-12-30-01:46:30
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
extern alias DgmjrSysExts;

namespace Dgmjr.EntityFrameworkCore.Models;

using Dgmjr.Abstractions;
using Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
public abstract class Entity<TId>
    : IEntity<TId>,
        IEntity,
        IEquatable<IEntity<TId>>,
        IComparable<IEntity<TId>>,
        IHaveAWritableId<TId>,
        IHaveAWritableId,
        IComparable
    where TId : IComparable, IEquatable<TId>
{
    public virtual TId Id
    {
        get => (TId)((IIdentifiable)this).Id;
        set => ((IHaveAWritableId)this).Id = value;
    }
    object IIdentifiable.Id => Id;
    object IHaveAWritableId.Id { get; set; }

    public override bool Equals(object obj) => obj is IEntity ie && Equals(ie);

    public virtual bool Equals(IEntity? other) => GetHashCode() == other?.GetHashCode();

    public virtual bool Equals(IEntity<TId>? other) =>
        Id.Equals(other is null ? default : other.Id);

    public virtual int CompareTo(IEntity<TId>? other) =>
        Id.CompareTo(other is null ? default : other.Id);

    public virtual int CompareTo(IEntity? other) =>
        CompareTo(other is null ? default : other as IEntity<TId>);

    public virtual int CompareTo(object? obj) =>
        obj is IIdentifiable oid
            ? Id.CompareTo(oid.Id)
            : throw new ArgumentException(
                $"Object must be of type {nameof(IIdentifiable)}.",
                nameof(obj)
            );

    public override int GetHashCode() => GetType().GetHashCode() ^ Id.GetHashCode();

    int IComparable.CompareTo(object obj)
    {
        if (obj == null)
        {
            return 1;
        }

        if (obj is IEntity<TId> x)
        {
            return CompareTo(x);
        }

        throw new ArgumentException($"Object of type {obj.GetType()} is not allowed.", nameof(obj));
    }

    public static bool operator ==(Entity<TId> @this, IEntity other) => @this.Equals(other);

    public static bool operator !=(Entity<TId> @this, IEntity other) => !@this.Equals(other);

    public static bool operator ==(Entity<TId> @this, object other) => @this.Equals(other);

    public static bool operator !=(Entity<TId> @this, object other) => !@this.Equals(other);
}
