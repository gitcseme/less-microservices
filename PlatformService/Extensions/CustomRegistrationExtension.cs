using Microsoft.Extensions.DependencyInjection;
using PlatformService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Extensions
{
    public static class CustomRegistrationExtension
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPlatformRepository, PlatformRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
