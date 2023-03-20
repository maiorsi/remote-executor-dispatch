// <copyright file="User.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

using static Grpc.Health.V1.HealthCheckResponse.Types;

namespace RemoteExecutor.Dispatch.Models;

public class User
{
    public string? Username { get; set; }
    public string? Guid { get; set; }
    public bool IsAuthenticated { get; set; }
    public ISet<string?> Roles { get; set; } = new HashSet<string?>();
    public ISet<string?> Rights { get; set; } = new HashSet<string?>();
}