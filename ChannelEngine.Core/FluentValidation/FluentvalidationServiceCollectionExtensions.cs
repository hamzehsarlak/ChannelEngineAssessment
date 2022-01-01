using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ChannelEngine.Core.FluentValidation
{
    public static class FluentValidationServiceCollectionExtensions
    {
        public static IServiceCollection AddAllValidators(this IServiceCollection services,
            ServiceLifetime serviceLifetime = ServiceLifetime.Transient)
        {
            services.Scan(scan => scan
                .FromApplicationDependencies()
                .AddClasses(classes => classes.Where(t => !t.IsGenericType).AssignableTo(typeof(IValidator<>)))
                .AsImplementedInterfaces()
                .WithLifetime(serviceLifetime));

            return services;
        }
    }
}
