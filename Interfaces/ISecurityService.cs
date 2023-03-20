// <copyright file="ISecurityService.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

using System.Security.Principal;

namespace RemoteExecutor.Dispatch.Interfaces;

public interface ISecurityService
{
    bool IsAdministrator(IPrincipal principal);
    bool IsUser(IPrincipal principal);
    bool CanUserAccessResource(IPrincipal principal, IEnumerable<string?> roles);
}