
using TodoAppHexagon.Core.Primitives;

namespace TodoAppHexagon.Core.Entities;

    public class TodoItem : Entity
    {
        public TodoItem(Guid id, string title, string isCompleted) : base(id)
        {
            Title = title;
            IsCompleted = isCompleted;
        }

        public required string Title { get; set; }
        public string IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; } = null;
    }

