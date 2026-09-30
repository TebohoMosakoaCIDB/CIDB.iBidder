using CIDB.iBidder.Application.TransferOptions.Crm;

namespace CIDB.iBidder.Application.Interfaces.Repositories
{
    public interface IMetroDistrictRepository
    {
        Task<IReadOnlyList<MetroDistrictModel>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IReadOnlyList<MetroDistrictModel>> GetByProvinceAsync(
            Guid provinceId, CancellationToken cancellationToken = default);

        Task<MetroDistrictModel?> GetByNameAsync(string name, CancellationToken cancellationToken = default);
    }
}
