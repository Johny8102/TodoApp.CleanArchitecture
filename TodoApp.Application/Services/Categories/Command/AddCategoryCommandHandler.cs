using MapsterMapper;
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
        private readonly IMapper _mapper;

        public AddCategoryCommandHandler(ICategotyRepository categotyRepository , IMapper mapper)
        {
            _mapper = mapper;
            _categotyRepository = categotyRepository;
        }

        public async Task<bool> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var temp = _mapper.Map<Category>(request);

            _categotyRepository.AddCategory(temp);

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
