// <copyright file="Node.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

using static Grpc.Health.V1.HealthCheckResponse.Types;

namespace RemoteExecutor.Dispatch.Models;

public class Node : IEquatable<Node>
{
    public string? Id { get; set; }
    public string? Channel { get; set; }
    public string? Name { get; set; }
    public string? Host { get; set; }
    public string? Version { get; set; }
    public ServingStatus Health { get; set; }
    public List<Process> Processes { get; set; }

    bool IEquatable<Node>.Equals(Node? other)
    {
        if (other == null)
        {
            return false;
        }

        return other.Id == this.Id;
    }
}