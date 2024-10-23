using Mapster;
using MapsterMapper;
using System.Net.WebSockets;
using System.Reflection;

namespace TodoApp.Presentation.Common.Mapping
{
    public static class PresentationMappingDependencyInjection
    {
        public static IServiceCollection PresentationMappingProvider(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.GetExecutingAssembly());

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();

            return services;
        }

    }
}
