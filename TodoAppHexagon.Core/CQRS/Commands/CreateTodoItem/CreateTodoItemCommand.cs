using MediatR;

namespace TodoAppHexagon.Core.CQRS.Commands.CreateTodoItem;
public class CreateTodoItemCommand : ICommand, IRequest, IRequest<Unit>
{
    public string Title { get; set; }
    public string IsCompleted { get; set; }


}



