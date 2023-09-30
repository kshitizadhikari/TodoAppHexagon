using MediatR;

namespace TodoAppHexagon.CQRS.Commands.CreateTodoItem;
public class CreateTodoItemCommand : ICommand, IRequest<Guid>
{
    public string Title { get; set; }
    public string IsCompleted { get; set; }
}



