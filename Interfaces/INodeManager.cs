// <copyright file="INodeManager.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

using static Grpc.Health.V1.HealthCheckResponse.Types;

namespace RemoteExecutor.Dispatch.Interfaces;

public interface INodeManager
{
    void AddNode(Models.Node node);
    void RemoveNode(Models.Node node);
    void UpdateNode(Models.Node node);
    void UpdateHealth(Models.Node node, ServingStatus health);
    void UpdateRunningProcesses(Models.Node node, List<string> runningProcessIds);
    void PurgeNodes();
    IEnumerable<Models.Node> GetNodes();
    Models.Node GetNodeById(string id);
}