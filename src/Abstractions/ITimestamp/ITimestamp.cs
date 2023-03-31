namespace Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// A timestamp for something happening in the database, including rowversion, a dictionary of details, and the ID of the user who made the change.
/// </summary>
public interface ITimestamp
{
    /// <value>The ID of the user who made the change</value>
    object? By { get; set; }
    /// <value>The <see cref="DateTime"/> of the change</value>
    DateTimeOffset When { get; set; }
    /// <value>An <see cref="IStringDictionary"/> of the details of the change (if any)</value>
    IStringDictionary Details { get; set; }
}
