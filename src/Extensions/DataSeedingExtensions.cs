/*
 * DataSeedingExtensions.cs
 *
 *   Created: 2022-12-31-04:13:10
 *   Modified: 2022-12-31-04:13:11
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.EntityFrameworkCore.Extensions;

public static class DataSeedingExtensions
{
    public static int Seed<T>(this DbContext db, IEnumerable<T> entities)
        where T : class
    {
        var count = 0;
        foreach (var entity in entities)
        {
            if (db.Set<T>().Find(entity) == null)
            {
                db.Set<T>().Add(entity);
                count++;
            }
        }

        return count;
    }
}
