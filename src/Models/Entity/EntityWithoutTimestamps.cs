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
public abstract class Entity : IEntity, IEquatable<IEntity>, IComparable<IEntity>, IComparable
{
    public virtual object Id { get; set; }

    public abstract int CompareTo(IEntity? other);
    public abstract int CompareTo(object? obj);
    public virtual bool Equals(IEntity? other) => GetHashCode() == other?.GetHashCode();
    public override int GetHashCode() => Id.GetHashCode();
    public override bool Equals(object? obj) => obj is IEntity entity && Equals(entity);
}
