using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Integration.Dtos.Enums;
using ChannelEngine.Integration.Dtos.Order;

namespace ChannelEngine.Application.Order.Abstraction
{
    public interface IOrderService
    {
        Task<IEnumerable<MerchantOrderResponse>> OrderGetByOrderStatusAsync(
            List<OrderStatusView> statuses = default,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<OrderLineGroupDto>> GetTopFiveMerchantProductsAsync(List<OrderStatusView> statuses = default,
            CancellationToken cancellationToken = default);

        IEnumerable<OrderLineGroupDto> GetTopFiveMerchantProducts(IEnumerable<MerchantOrderResponse> orders,
            CancellationToken cancellationToken = default);
    }
}
