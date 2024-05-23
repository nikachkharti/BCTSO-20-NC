using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using Microsoft.AspNetCore.JsonPatch.Adapters;
using Todo.Contracts;
using Todo.Entities;
using Todo.Models;
using Todo.Service.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Service.Implementations
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TodoService(ITodoRepository todoRepository, IHttpContextAccessor httpContextAccessor)
        {
            _todoRepository = todoRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = MappingInitializer.Initialize();
        }

        public async Task AddTodoAsync(TodoForAddingDto todoForAddingDto)
        {
            if (todoForAddingDto == null)
                throw new ArgumentNullException("Invalid argument passed");

            if (todoForAddingDto.UserId.Trim() != AuthenticatedUserId().Trim())
                throw new UnauthorizedAccessException("Can't add different users todo");

            var result = _mapper.Map<TodoEntity>(todoForAddingDto);
            await _todoRepository.AddTodoAsync(result);
            await _todoRepository.Save();
        }

        public async Task DeleteTodoAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            var rawTodo = await _todoRepository.GetSingleTodoAsync(x => x.Id == id);

            if (rawTodo == null)
                throw new TodoNotFoundException();

            if (rawTodo.UserId.Trim() == AuthenticatedUserId().Trim() || AuthenticatedUserRole().Trim() == "Admin")
            {
                _todoRepository.DeleteTodo(rawTodo);
                await _todoRepository.Save();
            }
            else
            {
                throw new UnauthorizedAccessException("Can't delete different users todo");
            }
        }

        public async Task<TodoForGettingDto> GetSingleTodoByUserId(int todoId, string userId)
        {
            if (todoId <= 0 || string.IsNullOrWhiteSpace(userId))
                throw new ArgumentException("Invalid argument passed");

            if (AuthenticatedUserId().Trim() != userId.Trim())
                throw new UserNotFoundException();

            var rawTodo = await _todoRepository.GetSingleTodoAsync(x => x.Id == todoId && x.UserId == userId);

            if (rawTodo == null)
                throw new TodoNotFoundException();

            var result = _mapper.Map<TodoForGettingDto>(rawTodo);
            return result;
        }

        public async Task<List<TodoForGettingDto>> GetTodosOfUserAsync(string userId)
        {
            List<TodoForGettingDto> result = new();

            if (string.IsNullOrWhiteSpace(userId))
                throw new ArgumentException("Invalid argument passed");

            if (AuthenticatedUserId().Trim() != userId.Trim())
                throw new UserNotFoundException();

            var rawTodos = await _todoRepository.GetAllTodosAsync(x => x.UserId.Trim() == userId.Trim());

            if (rawTodos.Count > 0)
                result = _mapper.Map<List<TodoForGettingDto>>(rawTodos);

            return result;
        }




        public async Task UpdateTodoAsync(TodoForUpdatingDto todoForUpdatingDto)
        {
            if (todoForUpdatingDto == null)
                throw new ArgumentNullException("Invalid argument passed");

            await _todoRepository.UpdateTodoAsync(_mapper.Map<TodoEntity>(todoForUpdatingDto));
            await _todoRepository.Save();
        }



        public async Task UpdateTodoPartiallyAsync(int todoId, JsonPatchDocument<TodoForUpdatingDto> patchDocument, ModelStateDictionary modelState)
        {
            if (todoId <= 0)
                throw new ArgumentException("Invalid argument passed");

            TodoEntity rawTodo = await _todoRepository.GetSingleTodoAsync(x => x.Id == todoId);

            if (rawTodo == null)
                throw new TodoNotFoundException();

            TodoForUpdatingDto todoToPatch = _mapper.Map<TodoForUpdatingDto>(rawTodo);
            patchDocument.ApplyTo(todoToPatch, modelState);

            if (!modelState.IsValid)
                throw new InvalidDataException("Invalid paraemeters passed operation type, updateable property path ro value is incorrect");

            _mapper.Map(todoToPatch, rawTodo);

            await _todoRepository.Save();
        }



        private string AuthenticatedUserId()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                return result;
            }
            else
            {
                throw new UnauthorizedAccessException("Can't get credentials of unauthorized user");
            }
        }
        private string AuthenticatedUserRole()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                return result;
            }
            else
            {
                throw new UnauthorizedAccessException("Can't get credentials of unauthorized user");
            }
        }

    }
}
