﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.Ports
{
    public interface ITodoRepository 
    {
        Task<IEnumerable<TodoItem>> GetAllAsync();
        Task<TodoItem?> GetByIdAsync(Guid id);
        Task CreateAsync(TodoItem item);
        Task<bool> UpdateAsync(TodoItem item);
        Task<bool> DeleteAsync(Guid id);
    }
}
