using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.CQRS.Commands;

namespace TodoAppHexagon.Core.DTOs
{
    public class UpdateTodoItemDto : ICommand
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string IsCompleted { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
