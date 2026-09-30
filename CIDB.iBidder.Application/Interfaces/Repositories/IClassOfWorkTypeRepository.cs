using CIDB.iBidder.Application.TransferOptions.Crm;

namespace CIDB.iBidder.Application.Interfaces.Repositories
{
    public interface IClassOfWorkTypeRepository
    {
        Task<IReadOnlyList<ClassOfWorkTypeModel>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<ClassOfWorkTypeModel?> GetByNameAsync(string name, CancellationToken cancellationToken = default);
    }
}
