using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstraction.CQRS;

namespace ChannelEngine.Application.Offer.Abstraction
{
    public interface IOfferService
    {
        Task<Dictionary<string, List<string>>> UpdateStockAsync(
            string merchantProductNo, int stock,
            CancellationToken cancellationToken = default);
    }
}
