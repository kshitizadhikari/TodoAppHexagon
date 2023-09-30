using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppHexagon.CQRS.Commands.CreateTodoItem
{
    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, Guid>
    {
        public Task<Guid> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
