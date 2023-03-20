// <copyright file="ApiKeyAuthSettings.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

namespace RemoteExecutor.Dispatch.Settings;

public class ApiKeyAuthSettings
{
    public List<string?> ApiKeyWhitelist { get; set; }
}