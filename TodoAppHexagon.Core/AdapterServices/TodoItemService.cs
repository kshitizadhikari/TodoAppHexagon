using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.CQRS.Commands.CreateTodoItem;
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

        public Task<List<TodoItem>> GetAllTodoItems()
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> GetTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateTodoItem(CreateTodoItemCommand item)
        {
            var todoItem = new TodoItem(Guid.NewGuid(), item.Title, item.IsCompleted, DateTime.Now)
            {
                Title = item.Title,
                IsCompleted = item.IsCompleted,
                CreatedAt = DateTime.Now
            };
            await _todoRepository.CreateAsync(todoItem);
        }

        public Task UpdateTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
