using CIDB.iBidder.Application.TransferOptions.Compliance;

namespace CIDB.iBidder.Application.Interfaces.Services
{
    public interface IContractorProfileService
    {
        Task<ContractorFullProfile> GetByCrsNumberAsync(
            string crsNumber, CancellationToken cancellationToken = default);
        Task<bool> SupplierExistsAsync(
        string csdNumber,
        CancellationToken cancellationToken = default);
    }
}
