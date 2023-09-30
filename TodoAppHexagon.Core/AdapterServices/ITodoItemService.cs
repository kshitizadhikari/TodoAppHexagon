using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.AdapterServices
{
    public interface ITodoItemService
    {
        Task<List<TodoItem>> GetAllAsync();
        Task<TodoItem> GetByIdAsync(Guid id);
        Task CreateAsync(CreateTodoItemDto itemDto);
        Task UpdateAsync(TodoItem item);
        Task DeleteAsync(Guid id);
    }
}
