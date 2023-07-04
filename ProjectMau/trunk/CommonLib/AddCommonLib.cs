using System;
using System.Collections.Generic;
using System.Text;
using CommonLib.Implementations;
using CommonLib.Interfaces;
using CoreLib.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace CommonLib
{
    // hiendv
    public static class AddCommonLibExtension
    {
        public static IServiceCollection AddCommonLib(this IServiceCollection services, IConfiguration Configuration)
        {
            ILogger serialog = new LoggerConfiguration()
                .WriteTo.File(Configuration["LogFilePath"], encoding: Encoding.UTF8,rollingInterval:RollingInterval.Day)
                .CreateLogger();

            services.AddSingleton(Configuration);
            services.AddSingleton(serialog);
            services.AddSingleton<ISerilogProvider, CSerilog>();
            services.AddSingleton<IErrorHandler, CErrorHandler>();

            return services;
        }
    }
}
