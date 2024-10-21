using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;
using ToDoApp.Application.Common.Interfaces.Persistence;

namespace ToDoApp.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private TodoDBContext _todoDBContext;
        public UserRepository(TodoDBContext todoDBContext)
        {
            _todoDBContext = todoDBContext;
        }

        public void AddUser(User user)
        {
            _todoDBContext.User.Add(user);
            _todoDBContext.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _todoDBContext.User.ToList();
        }

        public void RemoveUser(int userId)
        {
            _todoDBContext.User.Remove(findUser(userId));
            _todoDBContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _todoDBContext.User.Update(user);
            _todoDBContext.SaveChanges();
        }

        public User findUser(int id) { return _todoDBContext.User.Find(id); }
    }
}
