using System.Linq;
using System.ComponentModel.DataAnnotations;

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
using Microsoft.EntityFrameworkCore.Extensions;

public class ValidatedDbContext(DbContextOptions options) : DbContext(options), IValidatedDbContext
{
    public virtual IQueryable<TEntity> FromExpression<TEntity>(
        Expression<Func<TEntity, bool>> expression
    )
        where TEntity : class => Set<TEntity>().Where(expression);

    public override Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = new CancellationToken()
    )
    {
        Validate();
        return base.SaveChangesAsync(cancellationToken);
    }

    public virtual IEnumerable<ValidationResult> Validate(ValidationContext context) => Validate();

    public virtual IEnumerable<ValidationResult> Validate()
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

        return errors;
    }
}
