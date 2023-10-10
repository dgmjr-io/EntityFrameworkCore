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

public partial interface IDbSet<TEntity>
    where TEntity : class
{
    Microsoft.EntityFrameworkCore.Metadata.IEntityType EntityType { get; }
    Microsoft.EntityFrameworkCore.ChangeTracking.LocalView<TEntity> Local { get; }
    System.Linq.IQueryable<TEntity> AsQueryable();
    TEntity Find(TEntity[] keyValues);
    System.Threading.Tasks.ValueTask<TEntity> FindAsync(TEntity[] keyValues);
    System.Threading.Tasks.ValueTask<TEntity> FindAsync(
        TEntity[] keyValues,
        System.Threading.CancellationToken cancellationToken
    );
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Add(TEntity entity);
    System.Threading.Tasks.ValueTask<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity>> AddAsync(
        TEntity entity,
        System.Threading.CancellationToken cancellationToken
    );
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Attach(TEntity entity);
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Remove(TEntity entity);
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Update(TEntity entity);
    void AddRange(TEntity[] entities);
    System.Threading.Tasks.Task AddRangeAsync(TEntity[] entities);
    void AttachRange(TEntity[] entities);
    void RemoveRange(TEntity[] entities);
    void UpdateRange(TEntity[] entities);
    void AddRange(System.Collections.Generic.IEnumerable<TEntity> entities);
    System.Threading.Tasks.Task AddRangeAsync(
        System.Collections.Generic.IEnumerable<TEntity> entities,
        System.Threading.CancellationToken cancellationToken
    );
    void AttachRange(System.Collections.Generic.IEnumerable<TEntity> entities);
    void RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities);
    void UpdateRange(System.Collections.Generic.IEnumerable<TEntity> entities);
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Entry(TEntity entity);
}
