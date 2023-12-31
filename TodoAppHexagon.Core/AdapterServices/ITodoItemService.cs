﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.CQRS.Commands.CreateTodoItem;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;
namespace TodoAppHexagon.Core.AdapterServices
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItemDto>> GetAllTodoItems();
        Task<TodoItemDto> GetTodoItem(Guid id);
        Task CreateTodoItem(CreateTodoItemCommand item);
        Task<bool> UpdateTodoItem(UpdateTodoItemDto item);
        Task<bool> DeleteTodoItem(Guid id);
    }
}
