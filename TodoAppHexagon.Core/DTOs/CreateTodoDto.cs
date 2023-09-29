using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppHexagon.Core.DTOs
{
    public class CreateTodoDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
