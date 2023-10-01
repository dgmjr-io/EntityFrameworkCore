/*
 * ValidatedDbContext.cs
 *
 *   Created: 2022-12-31-06:22:28
 *   Modified: 2022-12-31-06:22:29
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Abstractions;

public class ValidatedDbContext : DbContext, IValidatedDbContext
{
    public ValidatedDbContext(DbContextOptions options)
        : base(options) { }

    public override int SaveChanges()
    {
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = new CancellationToken()
    )
    {
        Validate();
        return base.SaveChangesAsync(cancellationToken);
    }

    public virtual void Validate()
    {
        var changedEntities = ChangeTracker
            .Entries()
            .Where(_ => _.State == EntityState.Added || _.State == EntityState.Modified);

        var errors = new List<ValidationResult>(); // all errors are here
        foreach (var e in changedEntities)
        {
            var vc = new ValidationContext(e.Entity, null, null);
            Validator.TryValidateObject(e.Entity, vc, errors, validateAllProperties: true);
        }

        if (errors.Any())
        {
            throw new DbEntityValidationException(
                "Validation failed for one or more entities.",
                errors
            );
        }
    }
}
