using System;
using ChannelEngine.Core.IMediatR.Abstraction;

namespace ChannelEngine.Core.IMediatR
{
    public abstract class MediatRQueryBase
    {
        protected MediatRQueryBase()
        {
            Id = Guid.NewGuid();
        }

        protected MediatRQueryBase(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }

    public abstract class QueryBase<TResult> : IMediatRQuery<TResult>
    {
        protected QueryBase()
        {
            Id = Guid.NewGuid();
        }

        protected QueryBase(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
