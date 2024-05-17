using AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.Ordering
{
    public class OrderCommodityConfig : IEntityTypeConfiguration<OrderCommodity>
    {
        public void Configure(EntityTypeBuilder<OrderCommodity> builder)
        {
            
        }

    }
}
