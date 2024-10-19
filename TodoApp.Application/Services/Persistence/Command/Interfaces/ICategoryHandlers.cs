using ErrorOr;
using ToDoApp.Application.Common.Entities;


namespace ToDoApp.Application.Services.Persistence.Command.Interfaces
{
    public interface ICategoryHandlers 
    {
        Task<ErrorOr<Category>> CreateCategory(Category category);
        //Category GetCategory(string categoryId);    
        Task<ErrorOr<Category>> UpdateCategory(Category category);
        Task DeleteCategory(Category category);


        
    }
}
