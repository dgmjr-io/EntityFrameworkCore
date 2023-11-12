/*
 * IEntity.cs
 *
 *   Created: 2023-01-03-12:27:21
 *   Modified: 2023-01-03-12:27:22
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary><inheritdoc cref="IEntity" path="/summary" /> with a strongly-typed <see cref="IIdentifiable{TId}.Id" /> property.</summary>
public interface IEntity<TId> : IIdentifiable<TId>
    where TId : IComparable, IEquatable<TId>
{ }
