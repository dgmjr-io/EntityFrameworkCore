using System;
/*
 * IHaveADeletedDate.cs
 *
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-07:14:40
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>Interface for an entity that has <inheritdoc cref="IDeletable.Deleted" path="/value" />.</summary>
public interface IDeletable
{
    /// <value>a <see cref="ITimestamp" /> holding the details of the object's deletion (if applicable, <see langword="null"/>/<see langword="default"/> otherwise)</value>
    ITimestamp? Deleted { get; set; }
#if NET6_0_OR_GREATER
    /// <value><see langword="true" /> if the object has been deleted, <see langword="false" /> otherwise</value>
    bool IsDeleted => /*Deleted?.When.HasValue && */Deleted.When < DateTimeOffset.UtcNow;
#else
    /// <value><see langword="true" /> if the object has been deleted, <see langword="false" /> otherwise</value>
    bool IsDeleted { get; }
    #endif
}

/// <summary><inheritdoc cref="IDeletable" path="/summary" /> with the strongly-typed ID of the user who deleted it.</summary>
public interface IDeletable<TUserId>
{
    /// <value><inheritdoc cref="IDeletable.Deleted" path="/value" />  with the ID of the user who performed the operation</value>
    ITimestamp<TUserId> Deleted { get; set; }
#if NET6_0_OR_GREATER
    /// <value><inheritdoc cref="IDeletable.IsDeleted" path="/value" />  with the ID of the user who performed the operation</value>
    bool IsDeleted => /*Deleted?.When.HasValue && */Deleted.When < DateTimeOffset.UtcNow;
#else
    /// <value><inheritdoc cref="IDeletable.IsDeleted" path="/value" />  with the ID of the user who performed the operation</value>
    bool IsDeleted { get; }
    #endif
}
