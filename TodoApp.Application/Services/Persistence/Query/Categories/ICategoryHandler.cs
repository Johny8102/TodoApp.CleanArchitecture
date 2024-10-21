using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;

namespace TodoApp.Application.Services.Persistence.Query.Categories
{
    public interface ICategoryHandler
    {
        ErrorOr<List<Category>> getAllCategories();
        //Task<ErrorOr<List<TodoTask>>> CategoriesTasks(Category category);






    }
}
