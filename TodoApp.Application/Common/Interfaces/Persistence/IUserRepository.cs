using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;


namespace ToDoApp.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void UpdateUser(User user);
        void RemoveUser(int userId);
        List<User> GetAllUsers();
    }
}
