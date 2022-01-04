using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Application.Order.Abstraction;
using ChannelEngine.Core.IMediatR.Abstraction;
using ChannelEngine.Integration.Dtos.Enums;
using ChannelEngine.Integration.Dtos.Order;
using ChannelEngine.Integration.Queries;

namespace ChannelEngine.Application.Order.QueryHandlers
{
    public class FetchAllOrdersQueryHandler : IMediatRQueryHandler<FetchAllOrdersQuery, IEnumerable<MerchantOrderResponse>>
    {
        private readonly IOrderService _orderService;

        public FetchAllOrdersQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IEnumerable<MerchantOrderResponse>> Handle(FetchAllOrdersQuery request,
            CancellationToken cancellationToken)
        {
            return await _orderService.OrderGetByOrderStatusAsync(new List<OrderStatusView>()
            {
                OrderStatusView.IN_PROGRESS
            }, cancellationToken);
        }
    }
}
