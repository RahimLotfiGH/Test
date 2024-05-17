using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate;
using AUA.ProjectName.DomainEntities.Tools.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUA.ProjectName.DomainEntities.Entities.Transportation.TransportationAggregate
{
    [Table("Transport", Schema = SchemaConsts.Transport)]
    public class Transport : DomainEntity
    {
        public long OrderId { get; set; }

        public Order Order { get; set; }

        public ETransportType TransportType { get; set; }

    }
}
