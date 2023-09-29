using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.AdapterServices
{
    public class TodoService : ITodoService
    {
        public Task CreateTodoItem(TodoItem item)
        {

            throw new NotImplementedException();
        }

        public Task DeleteTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoItem>> GetAllTodos()
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> GetTodoById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
