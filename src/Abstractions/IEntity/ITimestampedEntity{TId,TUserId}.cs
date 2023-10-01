/*
 * IEntity{TId, TUserId}.cs
 *
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-07:16:38
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// <inheritdoc cref="ITimestampedEntity" />
/// </summary>
/// <typeparam name="TId"><inheritdoc cref="ITimestampedEntity{TId}"/></typeparam>
/// <typeparam name="TUserId">The type of the user ID</typeparam>
public interface ITimestampedEntity<TId, TUserId> : ITimestampedEntity<TId>
    where TId : IComparable, IEquatable<TId>
{
    /// <value>A <see cref="ITimestamp{TUserId}"/> holding the details of the entity's creation</value>
    new ITimestamp<TUserId> Created { get; set; }

    /// <value>A <see cref="ITimestamp{TUserId}"/> holding the details of the entity's last update</value>
    new ITimestamp<TUserId> Updated { get; set; }

    /// <value>A <see cref="ITimestamp{TUserId}"/> holding the details of the entity's deletion (if applicable, <see langword="null"/>/<see langword="default"/> otherwise)</value>
    new ITimestamp<TUserId>? Deleted { get; set; }
}
