using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.CQRS.Queries.GetAllTodoItems
{
    public class GetAllTodoItemsQuery : IQuery, IRequest<IEnumerable<TodoItemDto>>
    {

    }
}
