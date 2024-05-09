using Microsoft.AspNetCore.Mvc;
using Todo.Contracts;

namespace Todo.API.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<IActionResult> AllTodos()
        {
            var result = await _todoService.GetAllTodosAsync();
            return Ok(result);
        }

        //დაწერეთ კონტროლერი რომელიც დაამატებს ახალ Todo - s
    }
}
