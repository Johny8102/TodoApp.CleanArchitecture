using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Services.Persistence.Query.Categories;

namespace ToDoApp.API.Controllers
{
    [Route("Cat")]
    public class CategoryController : Controller
    {
        //                                         In this controller : 

        //User must be able to add new categories , Delete , Update , see availabale categories
        //User must be able to see what tasks are asigned to specific task


        //Command : AddCategory    -    UpdateCategory     -     DeleteCategory     
        //Query :   Allcategories    -     Asigned Tasks to a category     -     

        private readonly ICategoryHandler _categories;

        public CategoryController(ICategoryHandler category)
        {
            _categories = category;
        }






        [HttpGet("All")]
        public string GetAllCategories()
        {

            var cats = _categories.getAllCategories();

            return "Hellpppo pleisia";


        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
