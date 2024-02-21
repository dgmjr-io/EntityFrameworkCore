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

// [GenerateInterface(typeof(DbContext))]
// public partial interface IDbContext { }

/// <summary>An abstraction (interface) for a <see cref="DbContext" />.</summary>
public partial interface IDbContext //: IAsyncDisposable
{
    EntityEntry Add(object entity);
    EntityEntry<TEntity> Add<TEntity>(TEntity entity)
        where TEntity : class;
    void AddRange(params object[] entities);
    void AddRange(IEnumerable<object> entities);
    ValueTask<EntityEntry> AddAsync(
        object entity,
        CancellationToken cancellationToken = default
    );
    ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(
        TEntity entity,
        CancellationToken cancellationToken = default
    )
        where TEntity : class;
    EntityEntry Attach(object entity);
    EntityEntry<TEntity> Attach<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
        where TEntity : class;
    EntityEntry Entry(object entity);
    object? Find(type entityType, params object[] keyValues);
    TEntity? Find<TEntity>(params object[] keyValues)
        where TEntity : class;
    ValueTask<object?> FindAsync(
        type entityType,
        params object[] keyValues
    );
    ValueTask<TEntity?> FindAsync<TEntity>(params object[] keyValues)
        where TEntity : class;
    ValueTask<TEntity?> FindAsync<TEntity>(
        object[] keyValues,
        CancellationToken cancellationToken
    )
        where TEntity : class;
    DatabaseFacade Database { get; }
    ChangeTracker ChangeTracker { get; }
    IModel Model { get; }
    DbContextId ContextId { get; }
    int SaveChanges();
    int SaveChanges(bool acceptAllChangesOnSuccess);
    Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default
    );
    Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default
    );
    EntityEntry Remove(object entity);
    EntityEntry<TEntity> Remove<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    void RemoveRange(params object[] entities);
    void RemoveRange(IEnumerable<object> entities);
    void UpdateRange(params object[] entities);
    void UpdateRange(IEnumerable<object> entities);
    EntityEntry Update(object entity);
    EntityEntry<TEntity> Update<TEntity>(
        TEntity entity
    )
        where TEntity : class;

#if NET6_0_OR_GREATER
    DbSet<TEntity> Set<TEntity>()
        where TEntity : class;
    DbSet<TEntity> Set<TEntity>(string name)
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
