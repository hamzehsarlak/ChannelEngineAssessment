﻿using System;
using System.Collections.Generic;
using System.Text;
using ChannelEngine.Core.Abstraction.CQRS;
using MediatR;

namespace ChannelEngine.Core.IMediatR.Abstraction
{
    public interface IMediatRCommand<TResult> : ICommand<TResult>, IRequest<TResult>
    {
    }

    public interface IMediatRCommand : ICommand, IRequest<Unit>
    {
    }
}
