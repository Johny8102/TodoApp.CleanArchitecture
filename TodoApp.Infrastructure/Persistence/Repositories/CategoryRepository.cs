using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Interfaces.Persistence;
using ToDoApp.Application.Common.Entities;


namespace ToDoApp.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : ICategotyRepository
    {
        TodoDBContext _todoDBContext;
        public CategoryRepository(TodoDBContext todoDBContext)
        {
            _todoDBContext = todoDBContext;
        }


        public void AddCategory(Category category)
        {
            _todoDBContext.Category.Add(category);
            _todoDBContext.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            _todoDBContext.Category.Remove(GetCategory(categoryId));
            _todoDBContext.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _todoDBContext.Category.ToList();
        }

        public void UpdateCategory(Category category)
        {
            _todoDBContext.Category.Update(category);
            _todoDBContext.SaveChanges();
        }

        public Category GetCategory(int categoryId)
        {
            return _todoDBContext.Category.Find(categoryId);
        }
    }
}
