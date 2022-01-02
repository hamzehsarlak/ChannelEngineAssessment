using System;
using System.Collections.Generic;
using System.Text;
using ChannelEngine.Core.Abstraction.CQRS;
using RestSharp;

namespace ChannelEngine.Core.RestSharp
{
    public class ExternalCommandResult<T> : RestResponse, IRestBusResult<T>
    {
        public T Result { get; set; }
    }
}
