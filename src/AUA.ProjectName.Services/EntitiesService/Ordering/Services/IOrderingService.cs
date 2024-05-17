using AUA.Infrastructure.BaseServices;
using AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate;
using AUA.ProjectName.Services.EntitiesService.Ordering.Contracts;

namespace AUA.ProjectName.Services.EntitiesService.Ordering.Services
{
    public class OrderingService : DomainEntityService<Order>,IOrderingService
    {
    }
}
