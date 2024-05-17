using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Commodities.CommodityAggregate;
using AUA.ProjectName.DomainEntities.Entities.Transportation.TransportationAggregate;
using AUA.ProjectName.DomainEntities.Tools.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate
{

    [Table("Order", Schema = SchemaConsts.Ordering)]
    public class Order : DomainEntity
    {
        public long CustomerId { get; set; }

        public EOrderStatus Status  { get; set; }

        public string? StatusDescription { get; set; }

        public List<OrderCommodity> OrderItems { get; set; }

        private ETransportType TransportationType { get; set; }

        public DateTime SubmitDate { get; set; }

        public decimal TotalPrice => OrderItems.Sum(p => p.TotalPrice);

        public void SetTransportationType()
        {
            TransportationType = HasBreakableItem() ?
                                 ETransportType.Express :
                                 ETransportType.Regular;
        }

        private bool HasBreakableItem()
        {
            return OrderItems.Any(p => p.BreakableStatus == ECommodityBreakableStatusType.Breakable);
        }
    }
}
