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
    public class FetchTopFiveSoldQueryHandler : IMediatRQueryHandler<FetchTopFiveSoldQuery,
        IEnumerable<OrderLineGroupDto>>
    {
        private readonly IOrderService _orderService;

        public FetchTopFiveSoldQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IEnumerable<OrderLineGroupDto>> Handle(FetchTopFiveSoldQuery request,
            CancellationToken cancellationToken)
        {
            return await _orderService.GetTopFiveMerchantProductNoAsync(new List<OrderStatusView>()
            {
                OrderStatusView.IN_PROGRESS
            }, cancellationToken);
        }
    }
}
