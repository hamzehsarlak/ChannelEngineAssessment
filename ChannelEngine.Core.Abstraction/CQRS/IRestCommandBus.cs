using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChannelEngine.Core.Abstraction.CQRS
{
    public interface IRestCommandBus
    {
        Task<IRestBusResult<TResponse>> Post<TRequest, TResponse>(string url, string path, TRequest command, Dictionary<string, string> headers,
            CancellationToken cancellationToken = default) where TRequest : ICommand;

        Task<IRestBusResult<TResponse>> Put<TRequest, TResponse>(string url, string path, TRequest command, Dictionary<string, string> headers,
            CancellationToken cancellationToken = default) where TRequest : ICommand;

        Task<IRestBusResult<TResponse>> Delete<TRequest, TResponse>(string url, string path, TRequest command, Dictionary<string, string> headers,
            CancellationToken cancellationToken = default) where TRequest : ICommand;
    }
}
