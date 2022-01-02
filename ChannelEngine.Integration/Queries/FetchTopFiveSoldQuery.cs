using System.Collections.Generic;
using ChannelEngine.Core.IMediatR;
using ChannelEngine.Core.IMediatR.Abstraction;
using ChannelEngine.Integration.Dtos.Order;

namespace ChannelEngine.Integration.Queries
{
    public class FetchTopFiveSoldQuery : MediatRQueryBase<IEnumerable<OrderLineGroupDto>>
    {

    }
}
