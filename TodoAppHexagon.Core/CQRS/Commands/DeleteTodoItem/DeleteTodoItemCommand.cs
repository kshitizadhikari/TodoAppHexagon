using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TodoAppHexagon.Core.DTOs;

namespace TodoAppHexagon.Core.CQRS.Commands.DeleteTodoItem
{
    public class DeleteTodoItemCommand : ICommand, IRequest<bool>
    {
        public DeleteTodoItemDto DeleteTodoItemDto;

        public DeleteTodoItemCommand(DeleteTodoItemDto deleteTodoItemDto)
        {
            DeleteTodoItemDto = deleteTodoItemDto;
        }
    }
}
