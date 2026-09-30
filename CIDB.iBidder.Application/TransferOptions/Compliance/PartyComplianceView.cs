using CIDB.iBidder.Domain.Enums;

namespace CIDB.iBidder.Application.TransferOptions.Compliance
{
    public sealed record PartyComplianceView(
       string ExternalId,
       string Name,
       string? RegistrationScheme,
       string? RegistrationNumber,
       CidbComplianceStatus ComplianceStatus,
       string Reason);
}
