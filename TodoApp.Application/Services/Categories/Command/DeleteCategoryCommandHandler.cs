using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Interfaces.Persistence;

namespace TodoApp.Application.Services.Categories.Command
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {

        private readonly ICategotyRepository _categotyRepository;

        public DeleteCategoryCommandHandler(ICategotyRepository categotyRepository)
        {
            _categotyRepository = categotyRepository;
        }


        public Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            _categotyRepository.DeleteCategory(request.Id);
            return Task.CompletedTask;
        }
    }
}
