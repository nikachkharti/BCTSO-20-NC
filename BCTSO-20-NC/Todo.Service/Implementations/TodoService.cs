﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Todo.Contracts;
using Todo.Entities;
using Todo.Models;
using Todo.Service.Exceptions;

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


        public Task UpdateTodoAsync(TodoForUpdatingDto todoForUpdatingDto)
        {
            throw new NotImplementedException();
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
