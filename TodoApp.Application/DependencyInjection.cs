using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Application.Common.Interfaces.Persistence;
using ToDoApp.Application.Services.Persistence.Command.UserHandlers;


namespace ToDoApp.Application
{
    public static class DependencyInjection 
    {
        public static IServiceCollection ApplicationServiceProvider(this IServiceCollection service)
        {

            
            service.AddScoped<IUserHandler , UserHandler>();



            return service;
        }


    }
}
