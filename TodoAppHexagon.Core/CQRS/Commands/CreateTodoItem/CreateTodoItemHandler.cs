using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppHexagon.Core.AdapterServices;

namespace TodoAppHexagon.Core.CQRS.Commands.CreateTodoItem
{
    public class CreateTodoItemCommandHandler : ICommand, IRequestHandler<CreateTodoItemCommand>
    {

        private readonly ITodoItemService _todoService;

        public CreateTodoItemCommandHandler(ITodoItemService todoService)
        {
            _todoService = todoService;
        }
        public async Task<Unit> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            await _todoService.CreateTodoItem(request);
            return Unit.Value;
        }
    }
}
