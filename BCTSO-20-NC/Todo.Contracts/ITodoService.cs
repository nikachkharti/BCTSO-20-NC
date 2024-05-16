using Todo.Models;
namespace Todo.Contracts
{
    public interface ITodoService
    {
        Task<List<TodoForGettingDto>> GetTodosOfUserAsync(string userId);
        Task<TodoForGettingDto> GetSingleTodoByUserId(int todoId, string userId);
        Task DeleteTodoAsync(int id);
        Task AddTodoAsync(TodoForAddingDto todoForAddingDto);
        Task UpdateTodoAsync(TodoForUpdatingDto todoForUpdatingDto);
    }
}
