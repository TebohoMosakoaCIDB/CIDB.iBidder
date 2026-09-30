using CIDB.iBidder.Application.TransferOptions.Compliance;
using CIDB.iBidder.Domain.Models.Crm;

namespace CIDB.iBidder.Application.Interfaces.Services
{
    public interface IContractorComplianceService
    {
        Task<ContractorComplianceResult> CheckAsync(Party party, CancellationToken cancellationToken = default);

        /// <summary>Runs CheckAsync and calls party.SetComplianceStatus with the result.</summary>
        Task<Party> CheckAndApplyAsync(Party party, CancellationToken cancellationToken = default);
    }
}
