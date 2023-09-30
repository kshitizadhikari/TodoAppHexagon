using Humanizer;
using Microsoft.AspNetCore.Mvc;
using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.DTOs;
using TodoAppHexagon.Core.Entities;
using TodoAppHexagon.Core.Ports;

namespace TodoAppHexagon.Controllers
{
    public class TodoItemController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
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

       
            await _todoItemService.CreateAsync(dto);

            return RedirectToAction("Todo");
        }

    }
}
