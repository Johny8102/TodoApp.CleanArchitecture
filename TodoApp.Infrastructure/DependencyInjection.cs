using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using ToDoApp.Application.Common.Interfaces.Persistence;
using ToDoApp.Infrastructure.Persistence;
using ToDoApp.Infrastructure.Persistence.Repositories;


namespace ToDoApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection InfrastructureServiceProvider(this IServiceCollection services ,ConfigurationManager configuration)
        {
            services.AddDbContext<TodoDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            

            services.AddScoped<IUserRepository,UserRepository>();

            return services;
        }
   
    }
}
