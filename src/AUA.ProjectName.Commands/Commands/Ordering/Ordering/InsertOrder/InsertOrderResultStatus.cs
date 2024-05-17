using System.ComponentModel;

namespace AUA.ProjectName.Commands.Commands.Ordering.Ordering.InsertOrder;

public enum InsertOrderResultStatus
{
    [Description("Success")]
    Success = 0,

    [Description("Commodities is empty")]
    CommoditiesIsEmpty = 1,

    [Description("Commodity not find")]
    CommodityNotFind = 2,

    [Description("It is less than the allowed limit")]
    LessThanTheAllowedLimit = 3,
}