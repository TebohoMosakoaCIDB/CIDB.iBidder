using CIDB.iBidder.Domain.Models.Crm;

namespace CIDB.iBidder.Application.Interfaces.Repositories
{
    public interface IReleaseRepository
    {
        Task<Release?> GetByOcidAndReleaseIdAsync(
            string ocid,
            string releaseId,
            CancellationToken cancellationToken = default);

        // Most recent release known for a given ocid, regardless of release.id.
        Task<Release?> GetLatestByOcidAsync(
            string ocid,
            CancellationToken cancellationToken = default);

        Task AddAsync(
            Release release,
            CancellationToken cancellationToken = default);

        Task UpdateAsync(
            Release release,
            CancellationToken cancellationToken = default);

        // Releases pulled from OCDS but not yet confirmed reconciled into iTender.
        Task<IReadOnlyCollection<Release>> GetUnsyncedAsync(
            int take = 100,
            CancellationToken cancellationToken = default);

        Task<DateTime?> GetLatestFetchedAtUtcAsync(CancellationToken cancellationToken = default);
    }
}
