using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChannelEngine.Core.Abstraction.CQRS
{
    public interface ICommandBus
    {
        Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
            where TCommand : ICommand;
        void Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
