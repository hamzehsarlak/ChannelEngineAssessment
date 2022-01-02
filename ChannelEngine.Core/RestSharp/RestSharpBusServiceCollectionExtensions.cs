using System;
using System.Collections.Generic;
using System.Text;
using ChannelEngine.Core.Abstraction.CQRS;
using ChannelEngine.Core.Abstraction.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RestSharp.Serialization;

namespace ChannelEngine.Core.RestSharp
{
    public static class RestSharpBusServiceCollectionExtensions
    {
        public static IServiceCollection AddRestSharpExternalCommandBus(this IServiceCollection services, Action<RestSharpOptions> setupAction)
        {
            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }
            services.TryAddScoped<IRestCommandBus, RestSharpCommandBus>();
            services.TryAddScoped<IRestSerializer, RestSharpSerializer>();
            var options = new RestSharpOptions();
            setupAction(options);
            services.Configure(setupAction);
            return services;
        }
    }
}
