using Microsoft.AspNetCore.Mvc;
using TodoAppHexagon.Core.AdapterServices;

[ApiController]
[Route("api/todos")]
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public IActionResult GetAllTodos()
    {
        // Implement logic to get all todos using _todoService
    }

    [HttpGet("{id}")]
    public IActionResult GetTodoById(Guid id)
    {
        // Implement logic to get a todo by ID using _todoService
    }

    [HttpPost]
    public IActionResult CreateTodo([FromBody] TodoCreateDto todoCreateDto)
    {
        // Implement logic to create a todo using _todoService
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTodo(Guid id, [FromBody] TodoUpdateDto todoUpdateDto)
    {
        // Implement logic to update a todo using _todoService
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTodo(Guid id)
    {
        // Implement logic to delete a todo using _todoService
    }
}