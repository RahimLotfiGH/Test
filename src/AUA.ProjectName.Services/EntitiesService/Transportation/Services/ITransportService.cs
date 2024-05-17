using AUA.Infrastructure.BaseServices;
using AUA.ProjectName.DomainEntities.Entities.Transportation.TransportationAggregate;
using AUA.ProjectName.Services.EntitiesService.Transportation.Contracts;

namespace AUA.ProjectName.Services.EntitiesService.Transportation.Services
{
    public class TransportService : DomainEntityService<Transport>, ITransportService
    {
    }
}
