using AUA.Infrastructure.BaseServices;
using AUA.ProjectName.DomainEntities.Entities.Commodities.CommodityAggregate;

namespace AUA.ProjectName.Services.EntitiesService.Commodities.Contracts
{
    public interface ICommodityService : IDomainEntityService<Commodity>
    {
        Task<List<Commodity>> GetCommoditiesAsync(IEnumerable<long> ids, CancellationToken cancellationToken);
    }
}
