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

public interface IDeletable
{
    /// <value>A <see cref="ITimestamp" /> holding the details of the object's deletion (if applicable, <see langword="null"/>/<see langword="default"/> otherwise)</value>
    ITimestamp? Deleted { get; set; }
    #if NET6_0_OR_GREATER
    bool IsDeleted => /*Deleted?.When.HasValue && */Deleted.When < DateTimeOffset.UtcNow;
    #else
    bool IsDeleted { get; }
    #endif
}
public interface IDeletable<TUserId>
{
    /// <value><inheritdoc cref="IDeletable.Deleted" />  with the ID of the user who performed the operation</value>
    ITimestamp<TUserId> Deleted { get; set; }
    #if NET6_0_OR_GREATER
    bool IsDeleted => /*Deleted?.When.HasValue && */Deleted.When < DateTimeOffset.UtcNow;
    #else
    bool IsDeleted { get; }
    #endif
}
