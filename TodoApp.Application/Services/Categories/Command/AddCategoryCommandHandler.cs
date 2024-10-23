using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;
using ToDoApp.Application.Common.Interfaces.Persistence;

namespace TodoApp.Application.Services.Categories.Command
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, bool>
    {

        private readonly ICategotyRepository _categotyRepository;

        public AddCategoryCommandHandler(ICategotyRepository categotyRepository)
        {
            _categotyRepository = categotyRepository;
        }

        public async Task<bool> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var catEntitiy = new Category()
            {
                Id = request.Id,
                Name = request.Name,
                IsActive = request.IsActive
            };

            _categotyRepository.AddCategory(catEntitiy);

            return true;
        }


        //public  Task Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        //{
        //    var catEntitiy = new Category()
        //    {
        //        Id = request.Id,
        //        Name = request.Name,
        //        IsActive = request.IsActive
        //    };

        //    _categotyRepository.AddCategory(catEntitiy);

        //    return  Task.CompletedTask;
        //}


    }
}
