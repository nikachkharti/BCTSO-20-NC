using AutoMapper;
using Todo.Entities;
using Todo.Models;

namespace Todo.Service
{
    public static class MappingInitializer
    {
        public static IMapper Initialize()
        {
            MapperConfiguration configuration = new(config =>
            {
                config.CreateMap<TodoEntity, TodoForAddingDto>().ReverseMap();
                config.CreateMap<TodoEntity, TodoForUpdatingDto>().ReverseMap();
                config.CreateMap<TodoEntity, TodoForGettingDto>().ReverseMap();
            });

            return configuration.CreateMapper();
        }
    }
}
