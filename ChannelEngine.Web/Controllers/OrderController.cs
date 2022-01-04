using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Integration.Dtos.Order;
using ChannelEngine.Integration.Queries;

namespace ChannelEngine.Web.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/Inventory/v{version:apiVersion}/[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly ICommandBus _commandBus;
        private readonly IQueryBus _queryBus;

        public OrderController(ILogger<OrderController> logger, ICommandBus commandBus, IQueryBus queryBus)
        {
            _logger = logger;
            _commandBus = commandBus;
            _queryBus = queryBus;
        }
        [HttpGet]
        public async Task<IEnumerable<MerchantOrderResponse>> GetAllOrders()
        {
            return await _queryBus.SendAsync<FetchAllOrdersQuery, IEnumerable<MerchantOrderResponse>>(new FetchAllOrdersQuery());
        }

    }
}
