using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.Ordering
{
    public class OrderChangeStatusHistoryConfig : IEntityTypeConfiguration<ChangeStatusHistory>
    {
        public void Configure(EntityTypeBuilder<ChangeStatusHistory> builder)
        {

            builder
                .Property(p => p.StatusDescription)
                .HasMaxLength(LengthConsts.MaxStringLen1000);

            
        }

    }
}
