using Microsoft.Extensions.DependencyInjection;
using MediatR;
using TodoApp.Application.Services.Categories.Command;
using TodoApp.Application.Services.Categories.Query;
using ToDoApp.Application.Common.Entities;
using Microsoft.Extensions.Configuration;
using TodoApp.Application.Common.Mapping;


namespace ToDoApp.Application
{
    public static class DependencyInjection 
    {
        public static IServiceCollection ApplicationServiceProvider(this IServiceCollection service  )
        {
            
            service.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(typeof(AddCategoryCommandHandler).Assembly));
            MappingDependencyInjection.ApplicationMapperProvider(service);
            //service.AddSingleton<IMediator , Mediator>();
            //service.AddScoped<IRequestHandler<AddCategoryCommand>, AddCategoryCommandHandler>();
            //service.AddScoped<IRequestHandler<GetAllCategoryQuery, List<Category>>, GetAllCategoryQueryHandler>();


            return service;
        }


    }

}
