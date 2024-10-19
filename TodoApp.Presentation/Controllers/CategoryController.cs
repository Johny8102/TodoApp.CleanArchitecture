using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.API.Controllers
{
    public class CategoryController : Controller
    {
        //                                         In this controller : 

        //User must be able to add new categories , Delete , Update , see availabale categories
        //User must be able to see what tasks are asigned to specific task


        //Command : AddCategory    -    UpdateCategory     -     DeleteCategory     
        //Query :   Allcategories    -     Asigned Tasks to a category     -     



        public IActionResult Index()
        {
            return View();
        }
    }
}
