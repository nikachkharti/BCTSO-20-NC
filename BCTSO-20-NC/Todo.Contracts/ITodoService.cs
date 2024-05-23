using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        Task UpdateTodoPartiallyAsync(int todoId, JsonPatchDocument<TodoForUpdatingDto> patchDocument, ModelStateDictionary modelState);
    }
}
