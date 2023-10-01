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

public class DbEntityValidationException : Exception
{
    public DbEntityValidationException(string message, List<ValidationResult> errors)
        : base(message)
    {
        Errors = errors;
    }

    public List<ValidationResult> Errors { get; }
}
