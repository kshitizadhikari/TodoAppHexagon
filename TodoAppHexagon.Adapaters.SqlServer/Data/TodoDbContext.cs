using Microsoft.EntityFrameworkCore;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Adapaters.SqlServer.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}