//
//  Entity.cs
//
//  Authors:
//       David G. Moore, Jr. <justin@thebackroom.app>
//       &
//       Municipal Drew <drew@wheatleythecat.com>
//
//  Copyright ©️ 2022 2022 David G. Moore, Jr.
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Dgmjr.EntityFrameworkCore.Models;
using Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
/// <typeparam name="TUserId">The type of the user ID (for the <see cref="ITimestamp{TUserId}"/></typeparam>
public abstract class TimestampedEntity<TId, TUserId> : TimestampedEntity<TId>, ITimestampedEntity<TId, TUserId>, IEquatable<IEntity<TId>>, IComparable<IEntity<TId>>
    where TId : IComparable, IEquatable<TId?>
{
    public new virtual ITimestamp<TUserId> Created { get => (this as ITimestampedEntity).Created is ITimestamp<TUserId> ituid ? ituid : new Timestamp<TUserId> { By = default, When = (this as ITimestampedEntity).Created.When, Details = (this as ITimestampedEntity).Created.Details }; set => (this as ITimestampedEntity).Created = value; }
    public new virtual ITimestamp<TUserId> Updated { get => (this as ITimestampedEntity).Created is ITimestamp<TUserId> ituid ? ituid : new Timestamp<TUserId> { By = default, When = (this as ITimestampedEntity).Updated.When, Details = (this as ITimestampedEntity).Updated.Details }; set => (this as ITimestampedEntity).Updated = value; }
    public new virtual ITimestamp<TUserId>? Deleted
    {
        get => (this as ITimestampedEntity).Deleted == default ?
                default :
                (this as ITimestampedEntity).Deleted is ITimestamp<TUserId> ituid ?
                ituid :
            new Timestamp<TUserId> { By = default, When = (this as ITimestampedEntity).Deleted?.When ?? default, Details = (this as ITimestampedEntity).Deleted.Details };
        set => (this as Abstractions.ITimestampedEntity).Deleted = value;
    }

#if NETSTANDARD
    public bool IsDeleted => /*Deleted?.When.HasValue && */Deleted.When < DateTimeOffset.UtcNow;
#endif
}
