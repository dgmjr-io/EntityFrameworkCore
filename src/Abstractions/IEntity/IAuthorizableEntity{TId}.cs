/*
 * IAuthorizableEntity{TId}.cs
 *
 *   Created: 2023-01-03-12:29:51
 *   Modified: 2023-01-03-12:29:52
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Abstractions;

using System.Security.Claims;

/// <summary>
/// <inheritdoc cref="IAuthorizableEntity" path="/summary" />
/// </summary>
/// <typeparam name="TId"></typeparam>
public interface IAuthorizableEntity<TId> : IEntity<TId>, IAuthorizableEntity where TId : IComparable, IEquatable<TId>
{
}
