using Microsoft.AspNetCore.Mvc;
using Todo.Contracts;
using Todo.Models;

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


        [HttpPost]
        public async Task<IActionResult> AddTodo([FromForm] TodoForAddingDto model)
        {
            await _todoService.AddTodoAsync(model);
            return Ok(model);
        }

    }
}
