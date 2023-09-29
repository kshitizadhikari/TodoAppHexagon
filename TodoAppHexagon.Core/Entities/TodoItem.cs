
using TodoAppHexagon.Core.Primitives;

namespace TodoAppHexagon.Core.Entities;

    public sealed class TodoItem : Entity
    {
        public TodoItem(Guid id, string title, DateTime createdAt) : base(id)
        {
            Title = title;
            CreatedAt = createdAt;
        }

        public required string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

