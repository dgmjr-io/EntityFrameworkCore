/*
 * IDbSet{T}.cs
 *
 *   Created: 2023-01-06-05:17:24
 *   Modified: 2023-01-06-05:17:25
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.EntityFrameworkCore.Abstractions;

[GenerateInterfaceAttribute(typeof(DbSet<>))]
public partial interface IDbSet<TEntity>
    where TEntity : class
{ }
