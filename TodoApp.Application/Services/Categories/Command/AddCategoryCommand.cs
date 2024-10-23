using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Application.Services.Categories.Command
{
    public record AddCategoryCommand(
        
        int Id,
        string Name,
        bool IsActive
        
        ) :IRequest<bool>;
    
    
}
