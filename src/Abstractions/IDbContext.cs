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
// [GenerateInterface(typeof(DbContext))]
public partial interface IDbContext
{
    global::Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade Database { get; }
    global::Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker ChangeTracker { get; }
    global::Microsoft.EntityFrameworkCore.Metadata.IModel Model { get; }
    global::Microsoft.EntityFrameworkCore.DbContextId ContextId { get; }
#if NET6_0_OR_GREATER
    global::Microsoft.EntityFrameworkCore.DbSet<TEntity> Set<TEntity>()
        where TEntity : class;
    global::Microsoft.EntityFrameworkCore.DbSet<TEntity> Set<TEntity>(string name)
        where TEntity : class;
#endif
    int SaveChanges();
    int SaveChanges(bool acceptAllChangesOnSuccess);
    global::System.Threading.Tasks.Task<int> SaveChangesAsync(
        global::System.Threading.CancellationToken cancellationToken =
            default(global::System.Threading.CancellationToken)
    );
    global::System.Threading.Tasks.Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        global::System.Threading.CancellationToken cancellationToken =
            default(global::System.Threading.CancellationToken)
    );
    void Dispose();
    global::System.Threading.Tasks.ValueTask DisposeAsync();
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Entry<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Entry(object entity);
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Add<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    global::System.Threading.Tasks.ValueTask<global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity>> AddAsync<TEntity>(
        TEntity entity,
        global::System.Threading.CancellationToken cancellationToken =
            default(global::System.Threading.CancellationToken)
    )
        where TEntity : class;
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Attach<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Update<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Remove<TEntity>(
        TEntity entity
    )
        where TEntity : class;
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Add(object entity);
    global::System.Threading.Tasks.ValueTask<global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry> AddAsync(
        object entity,
        global::System.Threading.CancellationToken cancellationToken =
            default(global::System.Threading.CancellationToken)
    );
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Attach(object entity);
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Update(object entity);
    global::Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry Remove(object entity);
    void AddRange(params object[] entities);
    global::System.Threading.Tasks.Task AddRangeAsync(params object[] entities);
    void AttachRange(params object[] entities);
    void UpdateRange(params object[] entities);
    void RemoveRange(params object[] entities);
    void AddRange(global::System.Collections.Generic.IEnumerable<object> entities);
    global::System.Threading.Tasks.Task AddRangeAsync(
        global::System.Collections.Generic.IEnumerable<object> entities,
        global::System.Threading.CancellationToken cancellationToken =
            default(global::System.Threading.CancellationToken)
    );
    void AttachRange(global::System.Collections.Generic.IEnumerable<object> entities);
    void UpdateRange(global::System.Collections.Generic.IEnumerable<object> entities);
    void RemoveRange(global::System.Collections.Generic.IEnumerable<object> entities);
    object? Find(global::System.Type entityType, params object[] keyValues);
    global::System.Threading.Tasks.ValueTask<object?> FindAsync(
        global::System.Type entityType,
        params object[] keyValues
    );
    global::System.Threading.Tasks.ValueTask<object?> FindAsync(
        global::System.Type entityType,
        object[] keyValues,
        global::System.Threading.CancellationToken cancellationToken
    );
    TEntity? Find<TEntity>(params object[] keyValues)
        where TEntity : class;
    global::System.Threading.Tasks.ValueTask<TEntity?> FindAsync<TEntity>(params object[] keyValues)
        where TEntity : class;
    global::System.Threading.Tasks.ValueTask<TEntity?> FindAsync<TEntity>(
        object[] keyValues,
        global::System.Threading.CancellationToken cancellationToken
    )
        where TEntity : class;
#if NET6_0_OR_GREATER
    global::System.Linq.IQueryable<TResult> FromExpression<TResult>(
        global::System.Linq.Expressions.Expression<global::System.Func<global::System.Linq.IQueryable<TResult>>> expression
    );
#endif
}

/// <summary>
/// Interface for a database context.  Implements all public properties and methods of <see cref="DbContext"/>.
/// </summary>
public interface IDbContext<TSelf> : IDbContext
    where TSelf : IDbContext, IDbContext<TSelf>
{
#if NET6_0_OR_GREATER
    // /// <summary>Retrieves the default configuration key for the DbContext's configuration string.</summary>
    // /// <returns>The default configuration key for the DbContext's configuration string.</returns>
    // static string IDbContext.DefaultConnectionStringConfigurationKey =>
    //     typeof(TSelf).Name.Replace("Context", string.Empty, StringComparison.OrdinalIgnoreCase);
#endif
}
