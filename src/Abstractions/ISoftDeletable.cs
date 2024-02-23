namespace Dgmjr.EntityFrameworkCore.Abstractions;

public interface ISoftDeletable
{
    DateTimeOffset? Deleted { get; set; }
#if NET6_0_OR_GREATER
    bool IsDeleted => Deleted is not null && Deleted.Value < DateTimeOffset.Now;
#else
    bool IsDeleted { get; set; }
#endif
}
