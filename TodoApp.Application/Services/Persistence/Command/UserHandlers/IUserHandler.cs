using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;

namespace ToDoApp.Application.Services.Persistence.Command.UserHandlers
{
    public interface IUserHandler
    {
        Task<ErrorOr<User>> CrateUser(User user);



    }
}
