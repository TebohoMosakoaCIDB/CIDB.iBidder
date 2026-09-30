using CIDB.iBidder.Application.Interfaces.Repositories;
using CIDB.iBidder.Application.TransferOptions.Crm;
using CIDB.iBidder.Domain.Constants;
using CIDB.iBidder.Infrastructure.Integrations.Crm;
using CIDB.iBidder.Infrastructure.Mappers;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using static CIDB.iBidder.Domain.Constants.CrmFieldNames;

namespace CIDB.iBidder.Infrastructure.Repositories
{
    public class TenderRepository : ITenderRepository
    {
        private readonly ICrmServiceFactory _crmServiceFactory;

        public TenderRepository(ICrmServiceFactory crmServiceFactory)
        {
            _crmServiceFactory = crmServiceFactory;
        }

        public Task<Guid> UpsertAsync(CreateTenderModel model, CancellationToken cancellationToken = default)
        {
            if (model is null) throw new ArgumentNullException(nameof(model));
            if (string.IsNullOrWhiteSpace(model.EmployerTenderNumber))
                throw new ArgumentException("EmployerTenderNumber is required to upsert a tender.", nameof(model));

            var service = _crmServiceFactory.Create();

            var existingId = FindByEmployerTenderNumber(service, model.EmployerTenderNumber);

            var entity = TenderMapper.ToEntity(model, existingId);

            if (existingId.HasValue)
            {
                service.Update(entity);
                return Task.FromResult(existingId.Value);
            }

            var newId = service.Create(entity);
            return Task.FromResult(newId);
        }

        private static Guid? FindByEmployerTenderNumber(IOrganizationService service, string employerTenderNumber)
        {
            var query = new QueryExpression(CrmEntityNames.Tender)
            {
                ColumnSet = new ColumnSet(TenderFields.Id),
                TopCount = 1
            };

            query.Criteria.AddCondition(
                TenderFields.EmployerTenderNumber,
                ConditionOperator.Equal,
                employerTenderNumber.Trim());

            var result = service.RetrieveMultiple(query);

            return result.Entities.FirstOrDefault()?.Id;
        }
    }
}
