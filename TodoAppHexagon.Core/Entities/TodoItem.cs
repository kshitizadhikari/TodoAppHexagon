
using TodoAppHexagon.Core.Primitives;

namespace TodoAppHexagon.Core.Entities;

    public class TodoItem : Entity
    {
        public TodoItem(Guid id, string title, string isCompleted, DateTime createdAt) : base(id)
        {
            Title = title;
            IsCompleted = isCompleted;
            CreatedAt = createdAt;
        }

        public required string Title { get; set; }
        public string IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

