using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstraction.CQRS;

namespace ChannelEngine.Web.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/Inventory/v{version:apiVersion}/[controller]/[action]")]
    public class OfferController : ControllerBase
    {
        private readonly ILogger<OfferController> _logger;
        private readonly ICommandBus _commandBus;
        private readonly IQueryBus _queryBus;

        public OfferController(ILogger<OfferController> logger, ICommandBus commandBus, IQueryBus queryBus)
        {
            _logger = logger;
            _commandBus = commandBus;
            _queryBus = queryBus;
        }
        //[HttpGet]
        //public ActionResult GetAllOrders()
        //{
        //    return Ok();
        //}

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}
