using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Services.Categories.Command;
using ToDoApp.Application.Common.Entities;

namespace TodoApp.Application.Common.Mapping
{
    public class AddCategoryMappingConfig :IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AddCategoryCommand, Category>()
                .Map(i => i.IsActive, j => j.IsActive);
        }
    }
}
