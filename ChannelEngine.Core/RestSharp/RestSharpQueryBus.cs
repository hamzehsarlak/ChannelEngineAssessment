using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstraction.CQRS;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Polly;
using RestSharp;
using RestSharp.Serialization;

namespace ChannelEngine.Core.RestSharp
{
    public class RestSharpQueryBus : RestSharpBase, IRestQueryBus
    {
        public RestSharpQueryBus(ILogger<RestSharpCommandBus> logger, IRestSerializer restSerializer,
            IOptions<RestSharpOptions> options) : base(logger, restSerializer, options)
        {
        }

        public async Task<IRestBusResult<TResponse>> Get<TResponse>(string url, string path, 
            Dictionary<string, string> headers = null,
            IEnumerable<Tuple<string, string>> queryParameters = null,
            CancellationToken cancellationToken = default) 
        {
            return await HttpAsync<TResponse>(GetRestClient(url), GetRestRequest(path, Method.POST, headers, queryParameters));
        }
    }

    
}
