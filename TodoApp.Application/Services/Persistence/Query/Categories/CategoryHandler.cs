using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;
using ToDoApp.Application.Common.Interfaces.Persistence;

namespace TodoApp.Application.Services.Persistence.Query.Categories
{
    public class CategoryHandler : ICategoryHandler
    {
        private readonly ICategotyRepository _repository;


        public CategoryHandler(ICategotyRepository repository)
        {
            _repository = repository;
        }



        public ErrorOr<List<Category>> getAllCategories()
        {
           return  _repository.GetAllCategories();
        }
    }
}
