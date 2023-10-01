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
<<<<<<< HEAD
=======

>>>>>>> 6854a28 (ran csharpier)
using Microsoft.EntityFrameworkCore.Abstractions;

public class ValidatedDbContext : DbContext, IValidatedDbContext
{
<<<<<<< HEAD
    public ValidatedDbContext(DbContextOptions options) : base(options)
    {
    }
=======
    public ValidatedDbContext(DbContextOptions options)
        : base(options) { }
>>>>>>> 6854a28 (ran csharpier)

    public override int SaveChanges()
    {
        Validate();
        return base.SaveChanges();
    }

<<<<<<< HEAD
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
=======
    public override Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = new CancellationToken()
    )
>>>>>>> 6854a28 (ran csharpier)
    {
        Validate();
        return base.SaveChangesAsync(cancellationToken);
    }

    public virtual void Validate()
    {
        var changedEntities = ChangeTracker
            .Entries()
<<<<<<< HEAD
            .Where(_ => _.State == EntityState.Added ||
                        _.State == EntityState.Modified);
=======
            .Where(_ => _.State == EntityState.Added || _.State == EntityState.Modified);
>>>>>>> 6854a28 (ran csharpier)

        var errors = new List<ValidationResult>(); // all errors are here
        foreach (var e in changedEntities)
        {
            var vc = new ValidationContext(e.Entity, null, null);
<<<<<<< HEAD
            Validator.TryValidateObject(
                e.Entity, vc, errors, validateAllProperties: true);
=======
            Validator.TryValidateObject(e.Entity, vc, errors, validateAllProperties: true);
>>>>>>> 6854a28 (ran csharpier)
        }

        if (errors.Any())
        {
            throw new DbEntityValidationException(
                "Validation failed for one or more entities.",
<<<<<<< HEAD
                errors);
=======
                errors
            );
>>>>>>> 6854a28 (ran csharpier)
        }
    }
}
