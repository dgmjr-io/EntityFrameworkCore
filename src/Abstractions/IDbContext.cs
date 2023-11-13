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

/// <summary>An abstraction (interface) for a <see cref="DbContext" />.</summary>
public partial interface IDbContext : IDisposable, IAsyncDisposable
{
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Add(object entity);
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Add<TEntity>(TEntity entity)
        where TEntity : class;
    void AddRange(params object[] entities);
    void AddRange(System.Collections.Generic.IEnumerable<object> entities);
    System.Threading.Tasks.ValueTask<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry> AddAsync(
        object entity,
        System.Threading.CancellationToken cancellationToken = default
    );
    System.Threading.Tasks.ValueTask<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity>> AddAsync<TEntity>(
        TEntity entity,
        System.Threading.CancellationToken cancellationToken = default
    )
        where TEntity : class;
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Attach(object entity);
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Attach<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
        where TEntity : class;
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Entry(object entity);
    object? Find(System.Type entityType, params object[] keyValues);
    TEntity? Find<TEntity>(params object[] keyValues)
        where TEntity : class;
    System.Threading.Tasks.ValueTask<object?> FindAsync(
        System.Type entityType,
        params object[] keyValues
    );
    System.Threading.Tasks.ValueTask<TEntity?> FindAsync<TEntity>(params object[] keyValues)
        where TEntity : class;
    System.Threading.Tasks.ValueTask<TEntity?> FindAsync<TEntity>(
        object[] keyValues,
        System.Threading.CancellationToken cancellationToken
    )
        where TEntity : class;
    Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade Database { get; }
    Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker ChangeTracker { get; }
    Microsoft.EntityFrameworkCore.Metadata.IModel Model { get; }
    Microsoft.EntityFrameworkCore.DbContextId ContextId { get; }
    int SaveChanges();
    int SaveChanges(bool acceptAllChangesOnSuccess);
    System.Threading.Tasks.Task<int> SaveChangesAsync(
        System.Threading.CancellationToken cancellationToken = default
    );
    System.Threading.Tasks.Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        System.Threading.CancellationToken cancellationToken = default
    );
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Remove(object entity);
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Remove<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    void RemoveRange(params object[] entities);
    void RemoveRange(System.Collections.Generic.IEnumerable<object> entities);
    void UpdateRange(params object[] entities);
    void UpdateRange(System.Collections.Generic.IEnumerable<object> entities);
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Update(object entity);
    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Update<TEntity>(
        TEntity entity
    )
        where TEntity : class;

#if NET6_0_OR_GREATER
    Microsoft.EntityFrameworkCore.DbSet<TEntity> Set<TEntity>()
        where TEntity : class;
    Microsoft.EntityFrameworkCore.DbSet<TEntity> Set<TEntity>(string name)
        where TEntity : class;
    System.Linq.IQueryable<TResult> FromExpression<TResult>(
        System.Linq.Expressions.Expression<System.Func<System.Linq.IQueryable<TResult>>> expression
    );
#endif
}

public interface IDbContext<TSelf> : IDbContext
    where TSelf : IDbContext, IDbContext<TSelf>
{
#if NET6_0_OR_GREATER
    // static string IDbContext.DefaultConnectionStringConfigurationKey =>
    //     typeof(TSelf).Name.Replace("Context", string.Empty, StringComparison.OrdinalIgnoreCase);
#endif
}
