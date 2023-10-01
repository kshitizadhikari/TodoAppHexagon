using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppHexagon.Core.DTOs
{
    public class DeleteTodoItemDto
    {
        public Guid Id { get;}

        public DeleteTodoItemDto(Guid id)
        {
            Id = id;
        }
    }
}
