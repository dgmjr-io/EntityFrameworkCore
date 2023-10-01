namespace Microsoft.EntityFrameworkCore.Extensions;

public static class DbSetExtensions
{
    public static void AddRange<T>(this DbSet<T> dbSet, IEnumerable<T> entities)
        where T : class
    {
        foreach (var entity in entities)
        {
            dbSet.Add(entity);
        }
    }

    public static void RemoveRange<T>(this DbSet<T> dbSet, IEnumerable<T> entities)
        where T : class
    {
        foreach (var entity in entities)
        {
            dbSet.Remove(entity);
        }
    }

    public static void UpdateRange<T>(this DbSet<T> dbSet, IEnumerable<T> entities)
        where T : class
    {
        foreach (var entity in entities)
        {
            dbSet.Update(entity);
        }
    }

    public static void AddOrUpdate<TEntity, TId>(this DbSet<TEntity> dbSet, TEntity entity)
        where TEntity : class, IIdentifiable<TId>
        where TId : struct, IComparable, IEquatable<TId>
    {
        var extantEntity = dbSet.Find(entity.Id);
        if (entity.Id.Equals(default) || extantEntity is null)
        {
            dbSet.Add(entity);
        }
        else
        {
            dbSet.Update(entity);
        }
    }

    public static void AddOrUpdate<T>(this DbSet<T> dbSet, Func<T, bool> predicate, T entity)
        where T : class
    {
        var extantEntity = dbSet.FirstOrDefault(predicate);
        if (extantEntity is null)
        {
            dbSet.Add(entity);
        }
        else
        {
            dbSet.Update(entity);
        }
    }
}
