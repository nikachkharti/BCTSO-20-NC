using Todo.Models;
namespace Todo.Contracts
{
    public interface ITodoService
    {
        Task<List<TodoForGettingDto>> GetAllTodosAsync();
        Task<TodoForGettingDto> GetAllTodosAsync(int id);
        Task AddTodoAsync(TodoForAddingDto model);
        Task UpdateTodoAsync(TodoForUpdatingDto model);
        Task DeleteTodoAsync(int id);
    }
}
