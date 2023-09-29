using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.Storage
{
    public class TodoItemInMemoryStorage : ITodoItemStorage
    {
        public Task<List<TodoItem>> GetAllTodos()
        {
            var data = new[]
            {
                new TodoItem(Guid.NewGuid(), "Read Book", false, DateTime.Now),
                new TodoItem(Guid.NewGuid(), "Practice Guitar", true, DateTime.Now),
                // Add more TodoItem instances here if needed
            };

            return Task.FromResult(data.ToList());
        }
    }
}