using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Services.Categories.Command;
using TodoApp.Application.Services.Categories.Query;
using ToDoApp.Presentation.Common.Entities;

namespace ToDoApp.API.Controllers
{
    [Route("Cat")]
    public class CategoryController : Controller
    {
        //                                         In this controller : 

        //User must be able to add new categories , Delete , Update , see availabale categories
        //User must be able to see what tasks are asigned to specific Categories


        //Command : AddCategory    -    UpdateCategory     -     DeleteCategory     
        //Query :   Allcategories    -     Asigned Tasks to a category     -     

        private readonly IMediator _imediatr;

        public CategoryController(IMediator imediatr)
        {
            _imediatr = imediatr;
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(CategoryPresentation category)
        {
            var temp = new AddCategoryCommand(
                category.Id  , category.Name , category.IsActive);

            await _imediatr.Send(temp);



            return View(category);
        }






        [HttpGet("All")]
        public string GetAllCategories()
        {
            var cats = _imediatr.Send(new GetAllCategoryQuery());


            return "Hellpppo pleisia";
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
