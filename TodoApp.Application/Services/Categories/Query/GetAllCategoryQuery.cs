using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;

namespace TodoApp.Application.Services.Categories.Query
{
    public record GetAllCategoryQuery():IRequest<List<Category>>;
    
}
