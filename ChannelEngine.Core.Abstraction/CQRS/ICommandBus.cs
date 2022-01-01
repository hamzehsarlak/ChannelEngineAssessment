﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChannelEngine.Core.Abstraction.CQRS
{
    /// <summary>
    /// Command bus must handle this methods
    /// </summary>
    public interface ICommandBus
    {
        Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
            where TCommand : ICommand;

        void Send<TCommand>(TCommand command) where TCommand : ICommand;

        Task SendAsync<TCommand, TResult>(TCommand command, CancellationToken cancellationToken = default)
            where TCommand : ICommand<TResult>;

        void Send<TCommand, TResult>(TCommand command) where TCommand : ICommand<TResult>;

    }
}
