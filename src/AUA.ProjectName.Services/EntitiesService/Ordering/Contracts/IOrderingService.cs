using AUA.Infrastructure.BaseServices;
using AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate;

namespace AUA.ProjectName.Services.EntitiesService.Ordering.Contracts
{
    public interface IOrderingService : IDomainEntityService<Order>
    {
    }
}
