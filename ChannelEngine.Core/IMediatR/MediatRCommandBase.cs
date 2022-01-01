using System;
using ChannelEngine.Core.IMediatR.Abstraction;

namespace ChannelEngine.Core.IMediatR
{
    public abstract class MediatRCommandBase<TResult> : IMediatRCommand<TResult>
    {
        protected MediatRCommandBase()
        {
            Id = Guid.NewGuid();
        }

        protected MediatRCommandBase(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
