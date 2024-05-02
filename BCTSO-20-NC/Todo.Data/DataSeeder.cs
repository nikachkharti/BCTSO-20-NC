﻿using Microsoft.EntityFrameworkCore;
using Todo.Entities;

namespace Todo.Data
{
    public static class DataSeeder
    {
        public static void SeedTodos(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoEntity>().HasData(
                new TodoEntity
                {
                    Id = 1,
                    Title = "პირველი საქმე",
                    Description = "პირველი საქმის აღწერა...",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddHours(1),
                    Status = Status.Todo,
                    Priority = Priority.Medium
                },
                new TodoEntity
                {
                    Id = 2,
                    Title = "მეორე საქმე",
                    Description = "მეორე საქმის აღწერა...",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddHours(1),
                    Status = Status.Todo,
                    Priority = Priority.Low
                },
                new TodoEntity
                {
                    Id = 3,
                    Title = "მესამე საქმე",
                    Description = "მესამე საქმის აღწერა...",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddHours(5),
                    Status = Status.Doing,
                    Priority = Priority.Urgent
                },
                new TodoEntity
                {
                    Id = 4,
                    Title = "მეოთხე საქმე",
                    Description = "მეოთხე საქმის აღწერა...",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(7),
                    Status = Status.Todo,
                    Priority = Priority.Low
                },
                new TodoEntity
                {
                    Id = 5,
                    Title = "მეხუთე საქმე",
                    Description = "მეხუთე საქმის აღწერა...",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(3),
                    Status = Status.Todo,
                    Priority = Priority.High
                },
                new TodoEntity
                {
                    Id = 6,
                    Title = "მეექვსე საქმე",
                    Description = "მეექვსე საქმის აღწერა...",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(10),
                    Status = Status.Doing,
                    Priority = Priority.Medium
                }
            );
        }
    }
}
