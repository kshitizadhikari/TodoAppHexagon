using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.CQRS.Queries.GetTodoItem;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.CQRS.Queries.GetAllTodoItems
{
    public class GetAllTodoItemsQueryHandler : IQuery, IRequestHandler<GetAllTodoItemsQuery, IEnumerable<TodoItemDto>>
    {
        private readonly ITodoItemService _todoService;

        public GetAllTodoItemsQueryHandler(ITodoItemService todoService)
        {
            _todoService = todoService;
        }
        public async Task<IEnumerable<TodoItemDto>> Handle(GetAllTodoItemsQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<TodoItemDto> allTodoItems = await _todoService.GetAllTodoItems();
            return allTodoItems;
        }
    }
}
