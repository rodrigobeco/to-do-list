using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Infraestructure.Repositories
{
    public class TodoRepository: ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task<List<Todo>> GetAll()
        {
            return await _context.TodoList.ToListAsync();
        }

        public async Task<Todo> GetById(int id)
        {
            return await _context.TodoList.FindAsync(id);
        }

        public async Task<Todo> Add(Todo model)
        {
            _context.TodoList.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task Update(Todo model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Todo model)
        {
            _context.TodoList.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
