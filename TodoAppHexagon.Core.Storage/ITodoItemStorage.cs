using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.Storage
{
    public interface ITodoItemStorage
    {
        Task<List<TodoItem>> GetAllTodos();
    }
}
