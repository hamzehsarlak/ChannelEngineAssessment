using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Integration.Commands;
using ChannelEngine.Integration.Dtos.Offer;

namespace ChannelEngine.Web.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class OffersController : ControllerBase
    {
        private readonly ILogger<OffersController> _logger;
        private readonly ICommandBus _commandBus;
        private readonly IQueryBus _queryBus;

        public OffersController(ILogger<OffersController> logger, ICommandBus commandBus, IQueryBus queryBus)
        {
            _logger = logger;
            _commandBus = commandBus;
            _queryBus = queryBus;
        }
        
        [HttpPut]
        public async Task<Dictionary<string, List<string>>> UpdateStock(UpdateStockRequest request)
        {
            return await _commandBus.SendAsync<UpdateStockCommand,Dictionary<string, List<string>>>(new UpdateStockCommand(request));
        }
    }
}
