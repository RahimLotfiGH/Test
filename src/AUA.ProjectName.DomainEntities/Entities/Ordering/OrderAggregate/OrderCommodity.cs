using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Commodities.CommodityAggregate;
using AUA.ProjectName.DomainEntities.Tools.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate
{

    [Table("OrderCommodity", Schema = SchemaConsts.Ordering)]
    public class OrderCommodity : DomainEntity
    {
        public string CommodityTitle { get; set; }

        public decimal CommodityPrice { get; set; }

        public decimal ExtraPrice { get; set; }

        public decimal TotalPrice => CommodityPrice + ExtraPrice;

        public int Count { get; set; }

        public ECommodityBreakableStatusType BreakableStatus { get; set; }

        public long CommodityId { get; set; }

        public Commodity Commodity { get; set; }

        public void SetCommodityValues(Commodity commodity)
        {
            CommodityTitle = commodity.Title;
            CommodityPrice = commodity.TotalPrice;
            ExtraPrice = commodity.ExtraPrice;
        }

    }
}
