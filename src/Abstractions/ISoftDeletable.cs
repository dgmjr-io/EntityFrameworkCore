namespace Dgmjr.EntityFrameworkCore.Abstractions;

public interface ISoftDeletable
{
    DateTimeOffset? Deleted { get; set; }
    bool IsDeleted { get; }
}
