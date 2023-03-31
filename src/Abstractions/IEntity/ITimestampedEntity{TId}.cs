/*
 * IEntity{TId}.cs
 *
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-09:06:39
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <inheritdoc cref="ITimestampedEntity" />
/// <typeparam name="TId"><inheritdoc cref="IEntity{TId}"/></typeparam>
public interface ITimestampedEntity<TId> : IEntity<TId>, ITimestampedEntity where TId : IComparable, IEquatable<TId>
{
}
