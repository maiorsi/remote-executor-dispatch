// <copyright file="IClient.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

namespace RemoteExecutor.Dispatch.Interfaces;

public interface IClient
{
    Task ReceiveMessage(string? message);
}