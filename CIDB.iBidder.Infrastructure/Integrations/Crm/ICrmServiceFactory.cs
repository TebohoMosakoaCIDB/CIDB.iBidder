using Microsoft.Xrm.Sdk;

namespace CIDB.iBidder.Infrastructure.Integrations.Crm
{
    public interface ICrmServiceFactory
    {
        IOrganizationService Create();
    }
}
