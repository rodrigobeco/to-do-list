using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

[ApiController]
[Route("api/todo-list")]
public class TodoListController : ControllerBase
{
    private readonly ITodoService _service;

    public TodoListController(ITodoService service)
    {
        _service = service;
    }

    [HttpGet("check")]
    public string Check()
    {
        return "TodoList API is running!";
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Todo>>> GetTodoList()
    {
        return await _service.GetAll();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Todo>> GetTodo(int id)
    {
        var model = await _service.GetById(id);

        if (model == null)
        {
            return NotFound();
        }

        return model;
    }

    [HttpPost]
    public async Task<ActionResult<Todo>> PostTodo(Todo model)
    {
        model = await _service.Add(model);
        return CreatedAtAction(nameof(PostTodo), new { id = model.Id }, model);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTodo(int id, Todo model)
    {
        if (id != model.Id)
        {
            return BadRequest();
        }

        await _service.Update(model);

        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchIsCompletedTodo(int id)
    {
        try
        {
            await _service.TodoIsCompleted(id);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodo(int id)
    {
        try
        {
            await _service.Delete(id);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}