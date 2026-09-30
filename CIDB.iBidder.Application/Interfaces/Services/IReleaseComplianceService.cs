using CIDB.iBidder.Application.TransferOptions.Compliance;
using CIDB.iBidder.Application.TransferOptions.Ocds;
using CIDB.iBidder.Domain.Models.Crm;

namespace CIDB.iBidder.Application.Interfaces.Services
{
    public interface IReleaseComplianceService
    {
        Task<ReleaseComplianceView> EnrichAsync(
            OcdsReleaseDto releaseDto,
            CancellationToken cancellationToken = default);

        Task<IReadOnlyCollection<ReleaseComplianceView>> EnrichAsync(
            IEnumerable<OcdsReleaseDto> releaseDtos,
            CancellationToken cancellationToken = default);

        Task<ReleaseComplianceView> RetryAsync(
            Release release,
            CancellationToken cancellationToken = default);

        Task<IReadOnlyCollection<ReleaseComplianceView>> RetryUnsyncedAsync(
            int take = 100,
            CancellationToken cancellationToken = default);
    }
}
