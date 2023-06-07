//
// IDbContext.cs
//
//   Created: 2022-10-18-10:51:12
//   Modified: 2022-11-13-01:18:19
//
//   Author: David G. Moore, Jr. <david@dgmjr.io>
//
//   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore;


/// <summary>
/// Interface for a database context.  Implements all public properties and methods of <see cref="DbContext"/>.
/// </summary>

[GenerateInterfaceAttribute(typeof(DbContext))]
public partial interface IDbContext
{
#if NET6_0_OR_GREATER
    // /// <summary>Retrieves the default configuration key for the DbContext's configuration string.</summary>
    // /// <returns>The default configuration key for the DbContext's configuration string.</returns>
    // public static abstract string DefaultConnectionStringConfigurationKey { get; } //=> "Db";
#endif
}

/// <summary>
/// Interface for a database context.  Implements all public properties and methods of <see cref="DbContext"/>.
/// </summary>
public interface IDbContext<TSelf> : IDbContext where TSelf : IDbContext, IDbContext<TSelf>
{
#if NET6_0_OR_GREATER
    // /// <summary>Retrieves the default configuration key for the DbContext's configuration string.</summary>
    // /// <returns>The default configuration key for the DbContext's configuration string.</returns>
    // static string IDbContext.DefaultConnectionStringConfigurationKey =>
    //     typeof(TSelf).Name.Replace("Context", string.Empty, StringComparison.OrdinalIgnoreCase);
#endif
}
