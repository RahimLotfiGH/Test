using System.ComponentModel;

namespace AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate;

public enum EOrderStatus
{
    [Description("Create")]
    New = 1,

    [Description("Approve")]
    Approve = 2,

    [Description("Reject")]
    Reject = 3,

    [Description("Deleted")]
    Deleted = 4,

    [Description("Sending")]
    Sending = 5,

    [Description("Closed")]
    Closed = 6
}