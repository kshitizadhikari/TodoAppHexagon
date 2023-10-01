using System;
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
        Task<List<TodoItemDto>> GetAllTodoItems();
        Task<TodoItemDto> GetTodoItem(Guid id);
        Task CreateTodoItem(CreateTodoItemCommand item);
        Task UpdateTodoItem(TodoItem item);
        Task DeleteTodoItem(Guid id);
    }
}
