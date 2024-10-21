using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;
using ToDoApp.Application.Common.Interfaces.Persistence;

namespace ToDoApp.Application.Services.Persistence.Command.UserHandlers
{
    public class UserHandler : IUserHandler
    {

        private readonly IUserRepository _userRepository;

        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        async Task<User> IUserHandler.CrateUser(User user)
        {
            //check if user dose not exists

            try
            {
                _userRepository.AddUser(user);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //create user


            return user;

        }
    }
}
