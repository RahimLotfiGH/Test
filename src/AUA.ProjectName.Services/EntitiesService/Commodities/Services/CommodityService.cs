using AUA.Infrastructure.BaseServices;
using AUA.ProjectName.DomainEntities.Entities.Commodities.CommodityAggregate;
using AUA.ProjectName.Services.EntitiesService.Commodities.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.Services.EntitiesService.Commodities.Services
{
    public class CommodityService : DomainEntityService<Commodity>, ICommodityService
    {

        public async Task<List<Commodity>> GetCommoditiesAsync(IEnumerable<long> ids, CancellationToken cancellationToken)
        {
            return await GetAll().Where(commodity => ids.Contains(commodity.Id) &&
                                                      commodity.IsActive)
                           .AsNoTracking()
                           .ToListAsync(cancellationToken);
        }
    }
}
