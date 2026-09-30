using CIDB.iBidder.Application.TransferOptions.Crm;

namespace CIDB.iBidder.Application.Interfaces.Services
{
    public interface IQualifiedContractorFinder
    {
        Task<IReadOnlyCollection<ContractorModel>> FindQualifiedContractorsAsync(
            Guid? provinceId,
            Guid? classOfWorkTypeId,
            string? requiredGradingDesignationContains,
            CancellationToken cancellationToken = default);
    }
}
