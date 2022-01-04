using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Application.Order.Abstraction;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Integration.Dtos.Enums;
using ChannelEngine.Integration.Dtos.Order;
using Microsoft.Extensions.Options;

namespace ChannelEngine.Application.Order
{
    public class OrderService : IOrderService
    {
        private readonly IRestQueryBus _restQueryBus;
        private readonly ChannelEngineRestOptions _options;

        public OrderService(IRestQueryBus restQueryBus, IOptions<ChannelEngineRestOptions> options)
        {
            _restQueryBus = restQueryBus;
            _options = options.Value;
        }

        public async Task<IEnumerable<MerchantOrderResponse>> OrderGetByOrderStatusAsync(
            List<OrderStatusView> statuses = default, CancellationToken cancellationToken = default)
        {
            var qps = new List<Tuple<string, string>>
            {
                _options.GetApiKeyQueryString()
            };
            if (statuses != null)
                qps.AddRange(statuses.Select(orderStatusView => new Tuple<string, string>("statuses", orderStatusView.ToString())));

            var request= await _restQueryBus.Get<CollectionOfMerchantOrderResponse>(_options.BaseUrl,
                _options.OrderPathGet,
                null,
                qps, cancellationToken);
            if (!request.IsSuccessful) throw request.ErrorException;
            return request.Result.Content;
        }

        public async Task<IEnumerable<OrderLineGroupDto>> GetTopFiveMerchantProductNoAsync(
            List<OrderStatusView> statuses = default,
            CancellationToken cancellationToken = default)
        {
            var allOrder = await OrderGetByOrderStatusAsync(statuses, cancellationToken);
            if (allOrder.Any())
            {
                return Top5MerchantProductNoAsync(allOrder);
            }

            return default;
        }

        public IEnumerable<OrderLineGroupDto> GetTopFiveMerchantProductNoAsync(IEnumerable<MerchantOrderResponse> orders, 
            CancellationToken cancellationToken = default)
        {
            return Top5MerchantProductNoAsync(orders);
        }                                                            

        private static IEnumerable<OrderLineGroupDto> Top5MerchantProductNoAsync(IEnumerable<MerchantOrderResponse> orders)
        {
            return orders.SelectMany(order => order.Lines)
                .GroupBy(line => line.MerchantProductNo)
                .Select(grp => new OrderLineGroupDto
                {
                    MerchantProductNo = grp.First().MerchantProductNo,
                    Gtin = grp.First().Gtin,
                    Description = grp.First().Description,
                    Quantity = grp.Sum(l => l.Quantity),
                }).OrderByDescending(olg => olg.Quantity).Take(5);
        }
    }
}
