using Humanizer;
using Microsoft.AspNetCore.Mvc;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;
using TodoAppHexagon.Core.Ports;

namespace TodoAppHexagon.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IActionResult Todo()
        {
            var model = new CreateTodoItemDto();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Todo(CreateTodoItemDto dto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Todo");
            }

            var todoItem = new TodoItem(Guid.NewGuid(), dto.Title, dto.IsCompleted, DateTime.Now)
            {
                Title = dto.Title,
                IsCompleted = dto.IsCompleted,
                CreatedAt = DateTime.Now
            };

            await _todoRepository.CreateAsync(todoItem);

            return RedirectToAction("Todo");
        }

    }
}
