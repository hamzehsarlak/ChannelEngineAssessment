using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChannelEngine.Console.Abstraction;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Integration.Commands;
using ChannelEngine.Integration.Dtos.Offer;
using ChannelEngine.Integration.Dtos.Order;
using ChannelEngine.Integration.Queries;
using Microsoft.Extensions.Logging;

namespace ChannelEngine.Console
{
    public class ConsoleService: IConsoleService
    {
        private readonly ILogger<ConsoleService> _logger;
        private readonly ICommandBus _commandBus;
        private readonly IQueryBus _queryBus;

        public ConsoleService(ILogger<ConsoleService> logger, ICommandBus commandBus, IQueryBus queryBus)
        {
            _logger = logger;
            _commandBus = commandBus;
            _queryBus = queryBus;
        }

        public async Task<IEnumerable<OrderLineGroupDto>> GetTopFiveMerchantProducts()
        {
            return await _queryBus.SendAsync<FetchTopFiveSoldQuery, IEnumerable<OrderLineGroupDto>>(new FetchTopFiveSoldQuery());
        }

        public async Task<Dictionary<string, List<string>>> UpdateStock(UpdateStockRequest request)
        {
            return await _commandBus.SendAsync<UpdateStockCommand, Dictionary<string, List<string>>>(new UpdateStockCommand(request));
        }
    }
}
