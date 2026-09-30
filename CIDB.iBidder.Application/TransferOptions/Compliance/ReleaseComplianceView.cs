namespace CIDB.iBidder.Application.TransferOptions.Compliance
{
    public sealed record ReleaseComplianceView(
        string Ocid,
        string ReleaseId,
        string? TenderId,
        string? TenderTitle,
        string? TenderStatus,
        IReadOnlyCollection<PartyComplianceView> Parties,
        bool PublishedToCrm,
        Guid? CrmTenderId,
        string? PublishReason);
}
