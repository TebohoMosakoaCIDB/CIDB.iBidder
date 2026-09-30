using CIDB.iBidder.Application.TransferOptions.Crm;
using CIDB.iBidder.Domain.Models.Csd;

namespace CIDB.iBidder.Application.TransferOptions.Compliance
{
    public sealed record ContractorFullProfile(
        string CrsNumber,
        ContractorModel? Crm,
        CsdSupplier? Csd,
        string? CrmLookupReason,
        string? CsdLookupReason);
}
