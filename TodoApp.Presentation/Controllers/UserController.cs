using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Common.Entities;
using ToDoApp.Application.Services.Persistence.Command.UserHandlers;

namespace ToDoApp.API.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {

        //                                      In This Controller:

        //We can make New User - Edit - Delete - See
        //User Task must be shown - List can be edited


        //Command : Create New User   -   Edit User Info   -   Delete User   -   User must be able to check tasks

        //Query : Get List of Tasks Users   -   List of Users Tasks   -   Get All Users   -   Get User By Id
        //Users undone


        //==========================================================================================================
        //==========================================================================================================

        private readonly IUserHandler _userHandler;

        public UserController(IUserHandler userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpPost("Create")]
        public IActionResult createUser()
        {
            var user = new User()
            {
                Email = "Email@gmail.com",
                Name = "Test",
                Password = "MODSVOjws",
                Tasks = new List<TodoTask>(),
                Id = 2 
            };

            var result = _userHandler.CrateUser(user);





            return View();

        }


        
        public IActionResult Index()
        {
            return View();
        }
    }
}
