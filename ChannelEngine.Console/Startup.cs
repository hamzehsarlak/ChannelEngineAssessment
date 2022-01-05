using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChannelEngine.Application;
using ChannelEngine.Console.Abstraction;
using ChannelEngine.Core.FluentValidation;
using ChannelEngine.Core.IMediatR;
using ChannelEngine.Core.Newtonsoft;
using ChannelEngine.Core.RestSharp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ChannelEngine.Console
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IConsoleService, ConsoleService>();
            services.AddNewtonSerializer(options =>
            {
                options.JsonSerializerSettings = new JsonSerializerSettings();
            });
            services.AddRestSharpBus(options =>
            {
                options.MaxRetryAttempts = 2;
                options.PauseBetweenFailures = TimeSpan.FromSeconds(0);
            });
            services.AddMediatR();
            services.AddAllMediatRHandlers();
            services.AddAllValidators();
            services.AddApplicationServices(configuration.GetSection("ChannelEngineConfig").Get<ChannelEngineRestOptions>());
            return services;
        }
    }
}
