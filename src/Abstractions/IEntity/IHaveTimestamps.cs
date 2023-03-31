/*
 * IHaveTimestamps.cs
 *
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-09:06:09
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


using System;
namespace Dgmjr.EntityFrameworkCore.Abstractions;

public interface ITimestampable<TUserId> : ICreatable<TUserId>, IUpdatable<TUserId>, IDeletable<TUserId> { }
