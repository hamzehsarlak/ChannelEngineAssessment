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
        public static IServiceCollection AddRestSharpBus(this IServiceCollection services, Action<RestSharpOptions> setupAction)
        {
            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }
            var options = new RestSharpOptions();
            setupAction(options);
            services.Configure(setupAction);
            services.TryAddScoped<IRestCommandBus, RestSharpCommandBus>();
            services.TryAddScoped<IRestQueryBus, RestSharpQueryBus>();
            services.TryAddScoped<IRestSerializer, RestSharpSerializer>();
            return services;
        }
    }
}
