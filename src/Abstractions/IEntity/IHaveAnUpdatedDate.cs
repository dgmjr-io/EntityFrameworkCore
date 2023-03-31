
namespace Dgmjr.EntityFrameworkCore.Abstractions;

public interface IUpdatable
{
    /// <value>A <see cref="ITimestamp"/> holding the details of the object's last update</value>
    ITimestamp Updated { get; set; }
}
public interface IUpdatable<TUserId>
{
    /// <value><inheritdoc cref="IUpdatable.Updated" />  with the ID of the user who performed the operation</value>
    ITimestamp<TUserId> Updated { get; set; }
}
