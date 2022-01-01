using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MediatR;

namespace ChannelEngine.Core.IMediatR.Abstraction
{
    public interface IMediatRCommand<out TResult> : ICommand, IRequest<TResult>
    {
    }

    public interface IMediatRCommand : ICommand, IRequest<Unit>
    {
    }
}
