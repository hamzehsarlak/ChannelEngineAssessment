using System;
using ChannelEngine.Application.Offer;
using ChannelEngine.Application.Offer.Abstraction;
using ChannelEngine.Application.Order;
using ChannelEngine.Application.Order.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ChannelEngine.Application
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, Action<ChannelEngineRestOptions> setupAction)
        {
            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }
            services.TryAddScoped<IOrderService, OrderService>();
            services.TryAddScoped<IOfferService, OfferService>();
            var options = new ChannelEngineRestOptions();
            setupAction(options);
            services.Configure(setupAction);
            return services;
        }
    }
}
