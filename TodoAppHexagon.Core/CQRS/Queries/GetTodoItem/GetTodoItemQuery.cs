using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;

namespace TodoAppHexagon.Core.CQRS.Queries.GetTodoItem
{
    public class GetTodoItemQuery : IQuery, IRequest<TodoItemDto>
    {
        public Guid Id { get; set; }

        public GetTodoItemQuery(Guid id)
        {
            Id = id;
        }
    }
}
