using ChannelEngine.Core.Abstraction.CQRS;
using MediatR;

namespace ChannelEngine.Core.IMediatR.Abstraction
{
    public interface IMediatRQuery<out TResult> : IQuery<TResult>, IRequest<TResult>
    {
    }
}
