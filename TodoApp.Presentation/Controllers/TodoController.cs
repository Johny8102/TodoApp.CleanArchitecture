using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.API.Controllers
{

    //                                      In this controller:

    //User must be able to Add , Update , remove and observe todoTasks
    //After defining tasks we want user to be able on adding , Deleteing , Updating and observing Users and categories to tasks
    //Tasks must be able to be assigned to another task as it's child task



    //Query : See ALl Exixting Task   -   List of Usres asigned to task   -   list of checked tasks   -   List of unchecked tasks
    //-   List of categories asigned to task   -   List of subtasks

    
    //Command : AddNewTask   -   UpdateTask     -     DeleteTask
    //-    Assign Worker    -    EditWorker   -    DeleteWorker
    //-    Assign Category    -    Edit Category     -     Delete Category   
    //-    Asign Parent Task for sub tasks (Relation will be determined or modified only by deleting of sub or parrent task)  


    public class TodoController : Controller
    {
        public ErrorOr<IActionResult> Index()
        {



            return View();
        }
        public ErrorOr<IActionResult> unCheckedTodos()
        {
            return View();
        }

        public ErrorOr<IActionResult> CheckedTodos()
        {
            return View();
        }

        public ErrorOr<IActionResult> RemoveTodo()
        {
            return View();
        }

        public ErrorOr<IActionResult> AddTodo()
        {
            return View();
        }







    }
}
