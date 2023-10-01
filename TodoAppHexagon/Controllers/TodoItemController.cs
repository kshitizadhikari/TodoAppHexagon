 using Humanizer;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.CQRS.Commands.CreateTodoItem;
 using TodoAppHexagon.Core.CQRS.Commands.UpdateTodoItem;
 using TodoAppHexagon.Core.CQRS.Queries.GetAllTodoItems;
 using TodoAppHexagon.Core.CQRS.Queries.GetTodoItem;
 using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;
using TodoAppHexagon.Core.Ports;

namespace TodoAppHexagon.Controllers
{
    public class TodoItemController : Controller
    {
        private readonly ITodoItemService _todoItemService;
        private readonly IMediator _mediator;

        public TodoItemController(ITodoItemService todoItemService, IMediator mediator)
        {
            _todoItemService = todoItemService;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            List<TodoItemDto> allTodoItemDtos = await _mediator.Send(new GetAllTodoItemsQuery());
            return View(allTodoItemDtos);
        }

        public IActionResult AddTodo()
        {
            var model = new CreateTodoItemDto();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTodo(CreateTodoItemDto dto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddTodo");
            }

            var command = new CreateTodoItemCommand
            {
                Title = dto.Title,
                IsCompleted = dto.IsCompleted
            };

            await _mediator.Send(command);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateTodo(Guid id)
        {
            TodoItemDto obj = await _mediator.Send(new GetTodoItemQuery(id));
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateTodo(TodoItemDto dto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            UpdateTodoItemDto obj = new UpdateTodoItemDto
            {
                Id = dto.Id,
                Title = dto.Title,
                IsCompleted = dto.IsCompleted,
                UpdateAt = DateTime.Now
            };

            bool result = await _mediator.Send(new UpdateTodoItemCommand(obj));
            if (!result)
            {
                TempData["error"] = "Not Updated";
            }

            TempData["success"] = "Updated Successfully";
            return RedirectToAction("Index");
        }

    }
}
