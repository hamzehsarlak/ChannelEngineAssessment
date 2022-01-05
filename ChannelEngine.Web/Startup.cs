using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoWrapper;
using ChannelEngine.Application;
using ChannelEngine.Core.FluentValidation;
using ChannelEngine.Core.IMediatR;
using ChannelEngine.Core.Newtonsoft;
using ChannelEngine.Core.RestSharp;
using Microsoft.AspNetCore.Mvc.Versioning;
using Newtonsoft.Json;

namespace ChannelEngine.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Configs

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
            services.AddApplicationServices(Configuration.GetSection("ChannelEngineConfig").Get<ChannelEngineRestOptions>());
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
                config.ApiVersionReader = new HeaderApiVersionReader("api-version");
            });

            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ChannelEngine.Web", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChannelEngine.Web v1"));
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseApiResponseAndExceptionWrapper();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
