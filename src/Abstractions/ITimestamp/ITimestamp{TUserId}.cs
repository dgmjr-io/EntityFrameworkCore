/*
 * ITimestamp{TUserId}.cs
 *
 *   Created: 2023-03-19-03:19:04
 *   Modified: 2023-05-05-04:38:28
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Data;

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// <inheritdoc cref="ITimestamp" path="/summary" />
/// </summary>
/// <typeparam name="TUserId">The type of the user ID</typeparam>
public interface ITimestamp<TUserId> : ITimestamp
{
    /// <value>the strongly-typed ID of the user who made the change</value>
    new TUserId By { get; set; }
}
