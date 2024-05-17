using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Tools.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUA.ProjectName.DomainEntities.Entities.Commodities.CommodityAggregate
{

    [Table("Commodity", Schema = SchemaConsts.Commodity)]
    public class Commodity : DomainEntity
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public decimal ExtraPrice { get; set; }

        public ECommodityBreakableStatusType BreakableStatus { get; set; }

        public decimal TotalPrice => Price + ExtraPrice;

        public string Quantity { get; set; }



    }
}
