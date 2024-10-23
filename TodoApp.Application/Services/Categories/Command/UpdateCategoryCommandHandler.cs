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
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly ICategotyRepository _categotyRepository;

        public UpdateCategoryCommandHandler(ICategotyRepository categotyRepository)
        {
            _categotyRepository = categotyRepository;
        }
        public Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var catEntitiy = new Category()
            {
                Id = request.Id,
                Name = request.Name,
                IsActive = request.IsActive
            };
            
            _categotyRepository.UpdateCategory(catEntitiy);
            return Task.CompletedTask;
        }
    }
}
