// <copyright file="ISigningService.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

using System.Security.Cryptography.X509Certificates;

namespace RemoteExecutor.Dispatch.Interfaces;

public interface ISigningService
{
    X509Certificate2 GetSigningCertificate();
    X509Certificate2 SignCertificateRequest(CertificateRequest csr);
}