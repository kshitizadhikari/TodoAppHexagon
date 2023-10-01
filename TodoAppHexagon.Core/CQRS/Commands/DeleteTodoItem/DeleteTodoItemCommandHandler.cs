using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TodoAppHexagon.Core.AdapterServices;

namespace TodoAppHexagon.Core.CQRS.Commands.DeleteTodoItem
{
    public class DeleteTodoItemCommandHandler : IRequestHandler<DeleteTodoItemCommand, bool>
    {
        private readonly ITodoItemService _todoItemService;

        public DeleteTodoItemCommandHandler(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<bool> Handle(DeleteTodoItemCommand request, CancellationToken cancellationToken)
        {
            bool result = await _todoItemService.DeleteTodoItem(request.DeleteTodoItemDto.Id);
            return result;
        }
    }
}
