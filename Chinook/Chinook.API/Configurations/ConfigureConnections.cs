﻿using System;
using System.Runtime.InteropServices;
using Chinook.Data.Data;
using Chinook.Domain.DbInfo;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chinook.API.Configurations
{
    public static class ConfigureConnections
    {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connection = String.Empty;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                connection = configuration.GetConnectionString("ChinookDbWindows");
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                     RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                connection = configuration.GetConnectionString("ChinookDbDocker");

            services.AddDbContextPool<ChinookContext>(options => options.UseSqlServer(connection));
            services.AddSingleton(new SqlConnection(connection));
            services.AddSingleton(new DbInfo(connection));

            return services;
        }
    }
}