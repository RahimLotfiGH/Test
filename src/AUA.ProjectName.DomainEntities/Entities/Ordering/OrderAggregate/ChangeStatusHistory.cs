using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Tools.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate
{
    [Table("ChangeStatusHistory", Schema = SchemaConsts.Ordering)]
    public class ChangeStatusHistory : DomainEntity
    {
        public long OrderId { get; set; }
    
        public Order Order { get; set; }

        public EOrderStatus Status { get; set; }

        public string StatusDescription { get; set; }
    }
}
