using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngine.Core.RestSharp
{
    public class RestSharpOptions
    {
        public int MaxRetryAttempts { get; } 
        public TimeSpan PauseBetweenFailures { get; }

        public RestSharpOptions(int maxRetryAttempts=-1, TimeSpan pauseBetweenFailures= default)
        {
            MaxRetryAttempts = maxRetryAttempts;
            PauseBetweenFailures = pauseBetweenFailures;
        }
    }
}
