using Microsoft.Extensions.DependencyInjection;
using MediatR;
using TodoApp.Application.Services.Categories.Command;
using TodoApp.Application.Services.Categories.Query;
using ToDoApp.Application.Common.Entities;
using Microsoft.Extensions.Configuration;


namespace ToDoApp.Application
{
    public static class DependencyInjection 
    {
        public static IServiceCollection ApplicationServiceProvider(this IServiceCollection service  )
        {
            
            service.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(typeof(AddCategoryCommandHandler).Assembly));
            
            //service.AddSingleton<IMediator , Mediator>();
            //service.AddScoped<IRequestHandler<AddCategoryCommand>, AddCategoryCommandHandler>();
            //service.AddScoped<IRequestHandler<GetAllCategoryQuery, List<Category>>, GetAllCategoryQueryHandler>();


            return service;
        }


    }

}
