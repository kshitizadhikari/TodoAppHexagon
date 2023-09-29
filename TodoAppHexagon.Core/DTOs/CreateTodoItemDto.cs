using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.DTOs
{
    public class CreateTodoItemDto
    {
        public string? Title { get; set; }
        public string IsCompleted { get; set; }
    }
}
 