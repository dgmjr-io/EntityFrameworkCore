namespace Microsoft.EntityFrameworkCore.Abstractions;

/// <summary>
/// <inheritdoc cref="IHaveADbContext" />
/// </summary>
/// <typeparam name="TContext">The type of the database context</typeparam>
public interface IHaveADbContext<out TContext> : IHaveADbContext
    where TContext : IDbContext, IDbContext<TContext>
{
    new TContext Db { get; }
#if NET6_0_OR_GREATER
    IDbContext IHaveADbContext.Db => Db;
#endif
}
