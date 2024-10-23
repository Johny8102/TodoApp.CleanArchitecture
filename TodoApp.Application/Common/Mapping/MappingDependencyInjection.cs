using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Application.Common.Mapping
{
    static class MappingDependencyInjection
    {
        public static IServiceCollection ApplicationMapperProvider(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.GetExecutingAssembly());

            services.AddSingleton(config);
            services.AddTransient<IMapper, ServiceMapper>();

            return services;
        }




    }
}
