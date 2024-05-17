using AUA.ProjectName.Commands.Commands.Ordering.Ordering.InsertOrder;
using AUA.ProjectName.DomainEntities.Entities.Commodities.CommodityAggregate;
using AUA.ProjectName.DomainEntities.Entities.Ordering.OrderAggregate;
using AUA.ProjectName.Infrastructure.CommandInfra.Handler.Base;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Services.EntitiesService.Commodities.Contracts;
using AUA.ProjectName.Services.EntitiesService.Ordering.Contracts;

namespace AUA.ProjectName.CommandHandler.CommandHandlers.Ordering.OrderCommandHandlers
{
    public class OrderCommandHandler : BaseCommandHandler<InsertOrderCommand, long>
    {
        private readonly ICommodityService _commodityService;
        private readonly IOrderingService _orderingService;
        private IEnumerable<Commodity> _orderCommodities;
        private Order _order;
        public OrderCommandHandler(ICommodityService commodityService
                                   , IOrderingService orderingService)
        {
            _commodityService = commodityService;
            _orderingService = orderingService;
        }


        public override async Task ValidationAsync(CancellationToken cancellationToken = new CancellationToken())
        {

            if (_request.Commodities is null || !_request.Commodities.Any())
                AddError(InsertOrderResultStatus.CommoditiesIsEmpty);

            await SetCommoditiesAsync(cancellationToken);

            if (_orderCommodities.Count() != _request.Commodities!.Count())
                AddError(InsertOrderResultStatus.CommodityNotFind);

            if (HasError) return;

            _order = CreateOrderFromRequest();

            if (_order.TotalPrice < 50000)
                AddError(InsertOrderResultStatus.LessThanTheAllowedLimit);

        }

        private async Task SetCommoditiesAsync(CancellationToken cancellationToken)
        {
            _orderCommodities = await _commodityService.GetCommoditiesAsync(_request.CommoditiesIds, cancellationToken);
        }

        public override async Task<ResultModel<long>> ExecuteAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var orderId = await _orderingService.InsertAsync(_order, cancellationToken);

            return CreateSuccessResult(orderId);

        }

        private Order CreateOrderFromRequest()
        {
            var order= new Order
            {
                CustomerId = 1,//Get From Jwt token
                Status = EOrderStatus.New,
                SubmitDate = DateTime.UtcNow,
                OrderItems = CreateList()

            };

            order.SetTransportationType();

            return order;
        }

        private List<OrderCommodity> CreateList()
        {
            return (from item in _request.Commodities
                    let commodity = _orderCommodities.First(p => p.Id == item.CommodityId)
                    select new OrderCommodity
                    {
                        CommodityId = commodity.Id,
                        CommodityTitle = commodity.Title,
                        CommodityPrice = commodity.TotalPrice,
                        BreakableStatus = commodity.BreakableStatus,
                        ExtraPrice = item.ExtraPrice,
                        Count = item.Count
                    }).ToList();
        }


    }
}
