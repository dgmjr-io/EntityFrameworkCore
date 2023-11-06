namespace Microsoft.EntityFrameworkCore.Extensions;

public static class EntityTypeConfigurationExtensions
{
    public static ModelBuilder ApplyConfiguration<T, U>(this ModelBuilder modelBuilder)
        where T : IEntityTypeConfiguration<U>, new()
        where U : class
    {
        new T().Configure(modelBuilder.Entity<U>());
        return modelBuilder;
    }
}
