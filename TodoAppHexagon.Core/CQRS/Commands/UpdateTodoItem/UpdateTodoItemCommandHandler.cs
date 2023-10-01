using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.CQRS.Commands.CreateTodoItem;
using TodoAppHexagon.Core.DTOs;

namespace TodoAppHexagon.Core.CQRS.Commands.UpdateTodoItem
{
    public class UpdateTodoItemCommandHandler : ICommand, IRequestHandler<UpdateTodoItemCommand, bool>
    {
        private readonly ITodoItemService _todoService;

        public UpdateTodoItemCommandHandler(ITodoItemService todoService)
        {
            _todoService = todoService;
        }
        public async Task<bool> Handle(UpdateTodoItemCommand request, CancellationToken cancellationToken)
        {
            bool result = await _todoService.UpdateTodoItem(request.UpdateDto);
            return result;
        }
    }
}
