using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngine.Core.Abstraction.CQRS
{
    public interface ICommand<TResult>
    {
        Guid Id { get; }
    }

    public interface ICommand
    {
        Guid Id { get; }
    }
}
