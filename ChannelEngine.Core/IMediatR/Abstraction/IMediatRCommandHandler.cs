﻿using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace ChannelEngine.Core.IMediatR.Abstraction
{
    public interface IMediatRCommandHandler<in TCommand> : IRequestHandler<TCommand>
        where TCommand : IMediatRCommand
    {
    }

    public interface IMediatRCommandHandler<in TCommand, TResult> :
        IRequestHandler<TCommand, TResult>
        where TCommand : IMediatRCommand<TResult>
    {
    }
}
