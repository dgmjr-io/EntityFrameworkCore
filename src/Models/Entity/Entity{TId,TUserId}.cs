/*
 * Entity{TId,TUserId}.cs
 *
 *   Created: 2023-10-01-08:57:29
 *   Modified: 2023-10-10-07:12:17
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
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
/// <typeparam name="TUserId">The type of the user ID (for the <see cref="ITimestamp{TUserId}"/></typeparam>
public abstract class TimestampedEntity<TId, TUserId>
    : TimestampedEntity<TId>,
        ITimestampedEntity<TId, TUserId>
    where TId : IComparable, IEquatable<TId?>
{
    public new virtual ITimestamp<TUserId> Created
    {
        get =>
            (this as ITimestampedEntity).Created is ITimestamp<TUserId> ituid
                ? ituid
                : new Timestamp<TUserId>
                {
                    By = default,
                    When = (this as ITimestampedEntity).Created.When,
                    Details = (this as ITimestampedEntity).Created.Details
                };
        set => (this as ITimestampedEntity).Created = value;
    }
    public new virtual ITimestamp<TUserId> Updated
    {
        get =>
            (this as ITimestampedEntity).Created is ITimestamp<TUserId> ituid
                ? ituid
                : new Timestamp<TUserId>
                {
                    By = default,
                    When = (this as ITimestampedEntity).Updated.When,
                    Details = (this as ITimestampedEntity).Updated.Details
                };
        set => (this as ITimestampedEntity).Updated = value;
    }
    public new virtual ITimestamp<TUserId>? Deleted
    {
        get =>
            (this as ITimestampedEntity).Deleted == default
                ? default
                : (this as ITimestampedEntity).Deleted is ITimestamp<TUserId> ituid
                    ? ituid
                    : new Timestamp<TUserId>
                    {
                        By = default,
                        When = (this as ITimestampedEntity).Deleted?.When ?? default,
                        Details = (this as ITimestampedEntity).Deleted.Details
                    };
        set => (this as Abstractions.ITimestampedEntity).Deleted = value;
    }

#if NETSTANDARD
    public bool IsDeleted => /*Deleted?.When.HasValue && */
        Deleted.When < DateTimeOffset.UtcNow;
#endif
}
