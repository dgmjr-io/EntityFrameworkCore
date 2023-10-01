/*
 * IValidatedDbContext.cs
 *
 *   Created: 2023-03-19-06:08:28
 *   Modified: 2023-03-19-06:08:28
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.EntityFrameworkCore.Abstractions;

[GenerateInterface(typeof(Microsoft.EntityFrameworkCore.ValidatedDbContext))]
public interface IValidatedDbContext : IDbContext
{
    void Validate();
}

public interface IValidatedDbContext<T> : IValidatedDbContext, IDbContext<T>
    where T : IValidatedDbContext<T> { }
