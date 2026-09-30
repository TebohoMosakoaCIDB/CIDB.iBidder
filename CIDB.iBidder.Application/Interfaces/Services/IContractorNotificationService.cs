using CIDB.iBidder.Application.TransferOptions.Compliance;

namespace CIDB.iBidder.Application.Interfaces.Services
{
    public interface IContractorNotificationService
    {
        Task<NotifyQualifiedContractorsResult> NotifyQualifiedContractorsAsync(
            Guid? provinceId,
            Guid? classOfWorkTypeId,
            string? requiredGradingDesignationContains,
            string subject,
            string message,
            CancellationToken cancellationToken = default);
    }
}
