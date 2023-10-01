using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.CQRS.Commands.CreateTodoItem;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.CQRS.Queries.GetTodoItem
{
    public class GetTodoItemQueryHandler : IQuery, IRequestHandler<GetTodoItemQuery, TodoItemDto>
    {

        private readonly ITodoItemService _todoService;

        public GetTodoItemQueryHandler(ITodoItemService todoService)
        {
            _todoService = todoService;
        }
        public async Task<TodoItemDto> Handle(GetTodoItemQuery request, CancellationToken cancellationToken)
        {
            var todo = await _todoService.GetTodoItem(request.Id);
            return todo;
        }
    }
}
