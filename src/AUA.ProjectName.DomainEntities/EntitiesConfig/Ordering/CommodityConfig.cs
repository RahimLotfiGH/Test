using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Commodities.CommodityAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.Ordering
{
    public class CommodityConfig : IEntityTypeConfiguration<Commodity>
    {
        public void Configure(EntityTypeBuilder<Commodity> builder)
        {

            builder
                .Property(p => p.Title)
                .HasMaxLength(LengthConsts.MaxStringLen100);

            
        }

    }
}
