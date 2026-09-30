using CIDB.iBidder.Application.TransferOptions.Crm;
using Microsoft.Xrm.Sdk;
using static CIDB.iBidder.Domain.Constants.CrmFieldNames;

namespace CIDB.iBidder.Infrastructure.Mappers
{
    public static class ProvinceMapper
    {
        public static ProvinceModel? ToDomain(Entity entity)
        {
            if (entity is null) return null;

            return new ProvinceModel
            {
                Id = entity.Id,
                SourceId = entity.Contains(ProvinceFields.SourceId)
                    ? entity.GetAttributeValue<int?>(ProvinceFields.SourceId)
                    : null,
                Name = entity.GetAttributeValue<string>(ProvinceFields.Name)
            };
        }

        public static Entity ToEntity(ProvinceModel model)
        {
            var entity = model.Id != Guid.Empty
                ? new Entity(Domain.Constants.CrmEntityNames.Province, model.Id)
                : new Entity(Domain.Constants.CrmEntityNames.Province);

            entity[ProvinceFields.Name] = model.Name;

            if (model.SourceId.HasValue)
                entity[ProvinceFields.SourceId] = model.SourceId.Value;

            return entity;
        }
    }
}
