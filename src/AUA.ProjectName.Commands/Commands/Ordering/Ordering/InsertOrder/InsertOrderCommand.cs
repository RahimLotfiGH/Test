using AUA.Infrastructure.CommandInfra.Command;

namespace AUA.ProjectName.Commands.Commands.Ordering.Ordering.InsertOrder
{
    public class InsertOrderCommand : BaseCommand<long>
    {
        public IEnumerable<OrderCommodityCommand> Commodities { get; set; }


        public IEnumerable<long> CommoditiesIds => Commodities.Select(p => p.CommodityId).ToList();
    }
}
