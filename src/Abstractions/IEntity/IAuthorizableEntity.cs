/*
 * IAuthorizableEntity.cs
 *
 *   Created: 2023-01-03-12:29:17
 *   Modified: 2023-01-03-12:29:17
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Abstractions;

using System.Security.Claims;

public interface IAuthorizableEntity : IEntity
{
    bool CanDo(ClaimsPrincipal principal, string operation);

    #if NET6_0_OR_GREATER
    bool CanRead(ClaimsPrincipal principal) => CanDo(principal, Dgmjr.Security.Operations.Read.Name);
    bool CanUpdate(ClaimsPrincipal principal) => CanDo(principal, Dgmjr.Security.Operations.Update.Name);
    bool CanDelete(ClaimsPrincipal principal) => CanDo(principal, Dgmjr.Security.Operations.Delete.Name);
    bool CanCreate(ClaimsPrincipal principal) => CanDo(principal, Dgmjr.Security.Operations.Create.Name);
    #else
    bool CanRead(ClaimsPrincipal principal);
    bool CanUpdate(ClaimsPrincipal principal);
    bool CanDelete(ClaimsPrincipal principal);
    bool CanCreate(ClaimsPrincipal principal);
    #endif
}
