using Microsoft.AspNetCore.Mvc;
using Todo.Web.Interfaces;

namespace Todo.Web.Controllers
{
    public class TodosController : Controller
    {
        private readonly ITodoService _todoService;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
