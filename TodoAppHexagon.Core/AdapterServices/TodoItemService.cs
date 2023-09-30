using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;
using TodoAppHexagon.Core.Ports;

namespace TodoAppHexagon.Core.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoItemService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<List<TodoItem>> GetAllAsync()
        {
            return await _todoRepository.GetAllAsync();
        }

        public async Task<TodoItem> GetByIdAsync(Guid id)
        {
            return await _todoRepository.GetByIdAsync(id);
        }

        public async Task CreateAsync(CreateTodoItemDto itemDto)
        {
            var todoItem = new TodoItem(Guid.NewGuid(), itemDto.Title, itemDto.IsCompleted, DateTime.Now)
            {
                Title = itemDto.Title,
                IsCompleted = itemDto.IsCompleted,
                CreatedAt = DateTime.Now
            };

            await _todoRepository.CreateAsync(todoItem);
        }

        public async Task UpdateAsync(TodoItem item)
        {
            await _todoRepository.UpdateAsync(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _todoRepository.DeleteAsync(id);
        }
    }
}