using Microsoft.EntityFrameworkCore;
using TodoAppHexagon.Adapaters.SqlServer.Data;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;
using TodoAppHexagon.Core.Ports;

public class SqlServerTodoRepository : ITodoRepository
{
    private readonly TodoDbContext _dbContext;

    public SqlServerTodoRepository(TodoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<TodoItem>> GetAllAsync()
    {
        return await _dbContext.TodoItems.ToListAsync();
    }
    
    public async Task<TodoItem> GetByIdAsync(Guid id)
    {
        return await _dbContext.TodoItems.FirstOrDefaultAsync(item => item.Id == id);
    }

    public async Task CreateAsync(TodoItem item)
    {
        _dbContext.TodoItems.Add(item);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<bool> UpdateAsync(TodoItem item)
    {
        _dbContext.TodoItems.Update(item);
        int result = await _dbContext.SaveChangesAsync();
        return result > 0;
    }

    public async Task DeleteAsync(Guid id)
    {
        var item = await GetByIdAsync(id);
        if (item != null)
        {
            _dbContext.TodoItems.Remove(item);
            await _dbContext.SaveChangesAsync();
        }
    }
}
