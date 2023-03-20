// <copyright file="ICertificateValidationService.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace RemoteExecutor.Dispatch.Interfaces;

public interface ICertificateValidationServiuce
{
    bool ServerCertificateCustomValidation(HttpRequestMessage httpRequestMessage, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);
}