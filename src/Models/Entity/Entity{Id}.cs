/* 
 * Entity{Id}.cs
 * 
 *   Created: 2022-12-28-04:10:43
 *   Modified: 2023-01-03-02:07:12
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Models;

using Dgmjr.Abstractions;
using Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
public abstract class TimestampedEntity<TId> : Entity<TId>
    where TId : IComparable, IEquatable<TId>
{
    public virtual TId Id { get => (TId)((IIdentifiable)this).Id; set => ((IHaveAWritableId)this).Id = value; }

    public virtual ITimestamp Created { get; set; } = new Timestamp();
    public virtual ITimestamp Updated { get; set; } = new Timestamp();
    public virtual ITimestamp? Deleted { get; set; } = default(Timestamp);
    public virtual int CompareTo(IEntity<TId>? other) => Id.CompareTo(other == default ? default : (other as IIdentifiable<TId>).Id);
    public virtual bool Equals(IEntity<TId>? other) => Id.Equals(other == default ? default : (other as IIdentifiable<TId>).Id);
    public virtual int CompareTo(IEntity? other) => CompareTo(other == default ? default : other as IEntity<TId>);
    public bool Equals(IEntity? other) => this.Id?.Equals(other?.Id) ?? false;
}
