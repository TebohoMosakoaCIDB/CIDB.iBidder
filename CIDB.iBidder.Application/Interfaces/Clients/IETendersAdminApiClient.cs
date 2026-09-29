using CIDB.iBidder.Application.TransferOptions.eTender;

namespace CIDB.iBidder.Application.Interfaces.Clients
{
    public interface IETendersAdminApiClient
    {
        Task<EtendersApiResponse> CreateTenderAsync(
            CreateTenderRequest request,
            IReadOnlyCollection<TenderDocumentUpload>? documents = null,
            CancellationToken cancellationToken = default);
    }
}
