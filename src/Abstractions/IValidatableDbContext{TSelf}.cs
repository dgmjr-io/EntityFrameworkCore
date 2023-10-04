/*
 * IValidatableDbContext{TSelf}.cs
 *
 *   Created: 2023-10-04-04:06:49
 *   Modified: 2023-10-04-04:06:49
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.EntityFrameworkCore.Abstractions;

public interface IValidatableDbContext<TSelf> : IDbContext<TSelf>, IValidatableDbContext
    where TSelf : IValidatableDbContext<TSelf>
{

}
