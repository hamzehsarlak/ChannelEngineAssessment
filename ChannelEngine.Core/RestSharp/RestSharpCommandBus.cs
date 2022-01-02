﻿using System;
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
    public class RestSharpCommandBus : RestSharpBase, IRestCommandBus
    {
        public RestSharpCommandBus(ILogger<RestSharpCommandBus> logger, IRestSerializer restSerializer,
            IOptions<RestSharpOptions> options) : base(logger, restSerializer, options)
        {
        }

        public async Task<IRestBusResult<TResponse>> Post<TRequest, TResponse>(string url, string path, TRequest command,
            Dictionary<string, string> headers = null,
            CancellationToken cancellationToken = default) where TRequest : ICommand
        {
            return await HttpAsync<TResponse>(GetRestClient(url), GetRestRequest(path, command, Method.POST, headers));
        }

        public async Task<IRestBusResult<TResponse>> Put<TRequest, TResponse>(string url, string path, TRequest command,
            Dictionary<string, string> headers = null,
            CancellationToken cancellationToken = default) where TRequest : ICommand
        {
            return await HttpAsync<TResponse>(GetRestClient(url), GetRestRequest(path, command, Method.POST, headers));
        }

        public async Task<IRestBusResult<TResponse>> Delete<TRequest, TResponse>(string url, string path, TRequest command,
            Dictionary<string, string> headers = null,
            CancellationToken cancellationToken = default) where TRequest : ICommand
        {
            return await HttpAsync<TResponse>(GetRestClient(url), GetRestRequest(path, command, Method.POST, headers));
        }
    }
}
