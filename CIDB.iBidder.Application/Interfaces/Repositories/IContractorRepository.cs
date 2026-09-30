using CIDB.iBidder.Application.TransferOptions.Crm;

namespace CIDB.iBidder.Application.Interfaces.Repositories
{
    public interface IContractorRepository
    {
        Task<ContractorModel?> GetByCrsNumberAsync(
            string crsNumber,
            CancellationToken cancellationToken = default);
    }
}
