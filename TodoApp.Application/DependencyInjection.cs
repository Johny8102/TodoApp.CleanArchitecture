using Microsoft.Extensions.DependencyInjection;
using TodoApp.Application.Services.Persistence.Query.Categories;
using ToDoApp.Application.Common.Interfaces.Persistence;
using ToDoApp.Application.Services.Persistence.Command.UserHandlers;



namespace ToDoApp.Application
{
    public static class DependencyInjection 
    {
        public static IServiceCollection ApplicationServiceProvider(this IServiceCollection service)
        {

            
            service.AddScoped<IUserHandler , UserHandler>();
            service.AddScoped<ICategoryHandler, CategoryHandler>();


            return service;
        }


    }
}
