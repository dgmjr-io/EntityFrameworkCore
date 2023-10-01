/*
 * IEntity.cs
 *
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-09:06:22
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// An interface for an entity including timestamps for <see cref="ICreatable.Created"/>, <see cref="IUpdatable.Updated"/>, and <see cref="IDeletable.Deleted"/>
/// </summary>
public interface ITimestampedEntity : IEntity, ITimestampable { }
