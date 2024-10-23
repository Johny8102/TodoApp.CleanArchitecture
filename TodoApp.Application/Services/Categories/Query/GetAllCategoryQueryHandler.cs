using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;
using ToDoApp.Application.Common.Interfaces.Persistence;

namespace TodoApp.Application.Services.Categories.Query
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, List<Category>>
    {

        private readonly ICategotyRepository _categotyRepository;

        public GetAllCategoryQueryHandler(ICategotyRepository categotyRepository)
        {
            _categotyRepository = categotyRepository;
        }

        public async Task<List<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return  _categotyRepository.GetAllCategories();
        }
        


    }
}
