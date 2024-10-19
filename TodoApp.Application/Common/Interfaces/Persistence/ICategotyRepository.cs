using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;

namespace ToDoApp.Application.Common.Interfaces.Persistence
{
    public interface ICategotyRepository
    {
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
        List<Category> GetAllCategories();

    }
}
