﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChannelEngine.Core.Abstraction.CQRS
{
    public interface IRestQueryBus
    {
        Task<IRestBusResult<TResponse>> Get<TResponse>(string url, string path, 
            Dictionary<string, string> headers,
            IEnumerable<Tuple<string, string>> queryParameters,
            CancellationToken cancellationToken = default);
    }
}
