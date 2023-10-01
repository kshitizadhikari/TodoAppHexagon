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

        public async Task<List<TodoItemDto>> GetAllTodoItems()
        {
            List<TodoItem> allTodoItems = await _todoRepository.GetAllAsync();
            List<TodoItemDto> todoItemDtos = allTodoItems.Select(item => new TodoItemDto
            {
                Id = item.Id,
                Title = item.Title,
                IsCompleted = item.IsCompleted
            }).ToList();
            return todoItemDtos;
        }

        public async Task<TodoItemDto> GetTodoItem(Guid id)
        {
            TodoItem todo = await _todoRepository.GetByIdAsync(id);
            TodoItemDto todoDto = new TodoItemDto
            {
                Id = todo.Id,
                Title = todo.Title,
                IsCompleted = todo.IsCompleted
            };
            return todoDto;
        }

        public async Task CreateTodoItem(CreateTodoItemCommand item)
        {
            var todoItem = new TodoItem(Guid.NewGuid(), item.Title, item.IsCompleted)
            {
                Title = item.Title,
                IsCompleted = item.IsCompleted,
                CreatedAt = DateTime.Now
            };
            await _todoRepository.CreateAsync(todoItem);
        }

        public async Task<bool> UpdateTodoItem(UpdateTodoItemDto item)
        {
            TodoItem obj = await _todoRepository.GetByIdAsync(item.Id);
            obj.Title = item.Title;
            obj.IsCompleted = item.IsCompleted;
            obj.UpdateAt = DateTime.Now;
            bool result = await _todoRepository.UpdateAsync(obj);
            return result;
        }

        public Task DeleteTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
