
namespace Dgmjr.EntityFrameworkCore.Abstractions;

public interface ICreatable
{
    /// <value>A <see cref="ITimestamp"/> holding the details of the object's creation</value>
    ITimestamp Created { get; set; }
}
public interface ICreatable<TUserId>
{
    /// <value><inheritdoc cref="ICreatable.Created" />  with the ID of the user who performed the operation</value>
    ITimestamp<TUserId> Created { get; set; }
}
