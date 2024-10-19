using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;

namespace ToDoApp.Application.Services.Persistence.Query.Interfaces
{
    public interface ICategoryHandler
    {
        Task<ErrorOr<List<Category>>> getAllCategories();
        Task<ErrorOr<List<TodoTask>>> CategoriesTasks(Category category);




        

    }
}
