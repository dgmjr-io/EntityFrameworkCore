/*
 * ITimestamp.cs
 *
 *   Created: 2023-03-19-03:19:04
 *   Modified: 2023-05-05-04:38:22
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// A timestamp for something happening in the database, including <inheritdoc cref="ITimestamp.By" path="/value" />, <inheritdoc cref="ITimestamp.When" path="/value" />, <inheritdoc cref="ITimestamp.Details" path="/value" />, and <inheritdoc cref="ITimestamp.Version" path="/value" />.
/// </summary>
public interface ITimestamp
{
    /// <value>the ID of the user who made the change</value>
    object? By { get; set; }

    /// <value>the <see cref="DateTime"/> of the change</value>
    DateTimeOffset When { get; set; }

    /// <value>tn <see cref="IStringDictionary"/> of the details of the change (if any)</value>
    IStringDictionary Details { get; set; }

    /// <value>the row version number of the change</value>
    int Version { get; set; }
}
