// <copyright file="IMasterManager.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

namespace RemoteExecutor.Dispatch.Interfaces;

public interface IMasterManager
{
    bool IsMaster();
    void SetMaster(bool isMaster);
}