namespace CIDB.iBidder.Application.Interfaces.Clients
{
    public interface ICsdAuthTokenProvider
    {
        Task<Guid> GetTokenAsync(CancellationToken cancellationToken = default);
    }
}
