using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TodoAppHexagon.Core.DTOs;

namespace TodoAppHexagon.Core.CQRS.Commands.UpdateTodoItem
{
    public class UpdateTodoItemCommand : IRequest<bool>
    {
        public UpdateTodoItemDto UpdateDto { get; set; }

        public UpdateTodoItemCommand(UpdateTodoItemDto updateDto)
        {
            UpdateDto = updateDto;
        }
    }

}
