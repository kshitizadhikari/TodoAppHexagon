using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppHexagon.Core.CQRS.Commands.UpdateTodoItem
{
    public class UpdateTodoItemCommand : ICommand
    {
        public string Title { get; set; }
        public string IsCompleted{ get; set; }

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
