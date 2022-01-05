using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Application.Offer.Abstraction;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Integration.Dtos;
using ChannelEngine.Integration.Dtos.Offer;
using Microsoft.Extensions.Options;

namespace ChannelEngine.Application.Offer
{
    public class OfferService : IOfferService
    {
        private readonly IRestCommandBus _restCommandBus;
        private readonly ChannelEngineRestOptions _options;

        public OfferService(IRestCommandBus restCommandBus, IOptions<ChannelEngineRestOptions> options)
        {
            _restCommandBus = restCommandBus;
            _options = options.Value;
        }

        public async Task<Dictionary<string, List<string>>> UpdateStockAsync(string merchantProductNo, int stock,
            CancellationToken cancellationToken = default)
        {
            var request =
                await _restCommandBus.Put<List<UpdateStockRequest>, SingleOfDictionaryOfStringAndListOfString>(
                    _options.BaseUrl, _options.SetStockPath,
                    new List<UpdateStockRequest>
                    {
                        new UpdateStockRequest
                        {
                            MerchantProductNo = merchantProductNo,
                            Stock = stock
                        }
                    }, null, new List<Tuple<string, string>> {_options.GetApiKeyQueryString()}, cancellationToken);
            if (!request.IsSuccessful || !request.Result.Success) throw request.ErrorException;
            return request.Result.Content;
        }
    }
}
