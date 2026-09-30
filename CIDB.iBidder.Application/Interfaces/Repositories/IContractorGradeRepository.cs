using CIDB.iBidder.Application.TransferOptions.Crm;

namespace CIDB.iBidder.Application.Interfaces.Repositories
{
    public interface IContractorGradeRepository
    {
        Task<ContractorModel?> GetByCsdNumberAsync(
            string csdNumber,
            CancellationToken cancellationToken = default);
    }
}
