using CIDB.iBidder.Application.TransferOptions.Ocds;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIDB.iBidder.Application.Interfaces.Clients
{
    public interface IOcdsApiClient
    {
        Task<OcdsReleasePackageDto> GetReleasesAsync(
            int PageNumber,
            int PageSize,
            DateTime? from,
            DateTime? to,
            CancellationToken cancellationToken = default);
    }
}
