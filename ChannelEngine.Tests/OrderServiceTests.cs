using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Castle.Components.DictionaryAdapter;
using ChannelEngine.Application;
using ChannelEngine.Application.Order;
using ChannelEngine.Application.Order.Abstraction;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Integration.Dtos.Order;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace ChannelEngine.Tests
{
    public class OrderServiceTests
    {
        private readonly IOrderService _orderService;
        public OrderServiceTests()
        {
            var mockIRestQueryBus = new Mock<IRestQueryBus>();
            var mockIOptions = new Mock<IOptions<ChannelEngineRestOptions>>();
            _orderService = new OrderService(mockIRestQueryBus.Object, mockIOptions.Object);
        }

        [Fact]
        public void Should_Return_Top_5_Products()
        {
            var result= _orderService.GetTopFiveMerchantProducts(GetDummyMerchantOrderResponse());
            Assert.InRange(result.Count(), 0, 5);
        }

        public IEnumerable<MerchantOrderResponse> GetDummyMerchantOrderResponse()
        {
            var testOrderLine = new Faker<MerchantOrderLineResponse>()
                .RuleFor(c => c.MerchantProductNo, c => c.Commerce.Product())
                .RuleFor(c => c.Gtin, c => c.Commerce.Ean8())
                .RuleFor(c => c.Description, c => c.Commerce.ProductDescription())
                .RuleFor(c => c.Quantity, c => c.Random.Int(0, 100));

            var testOrder =
                new Faker<MerchantOrderResponse>()
                    .RuleFor(u => u.Lines, f => testOrderLine.Generate(5).ToList());
            return testOrder.Generate(50);
        }
    }
}
