using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.AdapterServices
{
    public interface ITodoService
    {
        Task<List<TodoItem>> GetAllTodos();
        Task<TodoItem> GetTodoById(Guid id);
        Task CreateTodoItem(TodoItem item);
        Task DeleteTodoItem(Guid id);
        Task UpdateTodoItem(TodoItem item);
    }
}
