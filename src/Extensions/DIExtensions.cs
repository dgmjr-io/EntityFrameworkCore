/*
 * DIExtensions.cs
 *
 *   Created: 2022-12-04-09:30:15
 *   Modified: 2022-12-04-09:30:15
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

public static class DIExtensions
{
    public static IServiceCollection AddDbContext<TContext>(this IServiceCollection services)
        where TContext : DbContext
    {
        var config = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
        var dbContextName = typeof(TContext).Name.Replace(nameof(DbContext), string.Empty);
        services.AddDbContext<TContext>(
            builder => builder.UseSqlServer(config.GetConnectionString(dbContextName))
        );
        return services;
    }
}
