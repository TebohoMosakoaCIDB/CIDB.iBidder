using CIDB.iBidder.Application.TransferOptions.Crm;

namespace CIDB.iBidder.Application.Interfaces.Repositories
{
    public interface ITrackRecordRepository
    {
        Task<IReadOnlyCollection<TrackRecordModel>> GetByCrsNumberAsync(
            string crsNumber, CancellationToken cancellationToken = default);
    }
}
