using CIDB.iBidder.Application.TransferOptions.eTender;

namespace CIDB.iBidder.Application.Interfaces.Services
{
    public interface ITenderPublishingService
    {
        Task<CreateTenderResult> CreateTenderAsync(
            CreateTenderRequest request,
            IReadOnlyCollection<TenderDocumentUpload>? documents = null,
            CancellationToken cancellationToken = default);
    }
}
