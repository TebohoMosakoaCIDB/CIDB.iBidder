using CIDB.iBidder.Application.TransferOptions.Crm;

namespace CIDB.iBidder.Application.Interfaces.Repositories
{
    public interface IProvinceRepository
    {
        Task<IReadOnlyList<ProvinceModel>> GetAllAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Case-insensitive exact match on nv_name. Returns null if there's no match -
        /// callers decide what that means (e.g. TenderMapper leaves ProvinceId unset
        /// rather than guessing).
        /// </summary>
        Task<ProvinceModel?> GetByNameAsync(string name, CancellationToken cancellationToken = default);
    }
}
