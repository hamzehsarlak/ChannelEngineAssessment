using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChannelEngine.Integration.Dtos.Offer;
using ChannelEngine.Integration.Dtos.Order;

namespace ChannelEngine.Console.Abstraction
{
    public interface IConsoleService
    {
        Task<IEnumerable<OrderLineGroupDto>> GetTopFiveMerchantProducts();
        Task<Dictionary<string, List<string>>> UpdateStock(UpdateStockRequest request);
    }
}
