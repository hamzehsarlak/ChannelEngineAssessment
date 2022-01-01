using System;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Core.IMediatR.Abstraction;
using MediatR;

namespace ChannelEngine.Core.IMediatR
{
    public class MediatRQueryBus : IQueryBus
    {
        private readonly IMediator _mediator;

        public MediatRQueryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<TResponse> Send<TQuery, TResponse>(TQuery query, CancellationToken cancellationToken = default)
            where TQuery : IQuery<TResponse>
        {
            var mq = (query as IMediatRQuery<TResponse>) ?? throw new InvalidOperationException("TQuery must be IMediatorQuery<TResponse>");
            return _mediator.Send(mq, cancellationToken);
        }
    }
}
