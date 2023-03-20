// <copyright file="SigningSettings.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

namespace RemoteExecutor.Dispatch.Settings;

public class SigningSettings
{
    public string? CertificatePath { get; set; }
    public string? KeyPath { get; set; }
}