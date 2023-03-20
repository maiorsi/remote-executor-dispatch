// <copyright file="AuthenticationSettings.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

namespace RemoteExecutor.Dispatch.Settings;

public class AuthenticationSettings
{
    public string? ClientId { get; set; }
    public string? Realm { get; set; }
    public string? Url { get; set; }
}