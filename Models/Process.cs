// <copyright file="Process.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

using static Grpc.Health.V1.HealthCheckResponse.Types;

namespace RemoteExecutor.Dispatch.Models;

public class Process
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public List<string?> Roles { get; set; }
    public bool HasArguments { get; set; }
    public bool IsRunning { get; set; }
    public bool IsAllowed { get; set; }
}