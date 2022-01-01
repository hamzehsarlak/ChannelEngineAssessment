using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngine.Core.Abstraction.CQRS
{
    public interface IQuery<out TResponse>
    {
    }
}
