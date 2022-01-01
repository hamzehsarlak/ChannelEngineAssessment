using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace ChannelEngine.Core.IMediatR.Abstraction
{
    public interface IMediatRQueryHandler<in TQuery, TResult> :
        IRequestHandler<TQuery, TResult>
        where TQuery : IMediatRQuery<TResult>
    {
    }
}
