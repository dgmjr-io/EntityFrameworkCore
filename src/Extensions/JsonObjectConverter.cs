/*
 * JsonObjectConverter.cs
 *
 *   Created: 2022-12-10-09:00:15
 *   Modified: 2022-12-10-09:00:15
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dgmjr.EntityFrameworkCore;

public class JsonObjectConverter<T> : ValueConverter<T?, string>
{
    public JsonObjectConverter() : base(
        v => Serialize(v, Jso.Default),
        v => Deserialize<T>(v, Jso.Default))
    {
    }
}
