using CIDB.iBidder.Domain.Models.Csd;

namespace CIDB.iBidder.Application.Interfaces.Clients
{
    public interface ICsdApiClient
    {
        Task<CsdSupplier> GetSupplierDetailsAsync(
            string supplierNumber,
            CancellationToken cancellationToken = default);
    }
}
