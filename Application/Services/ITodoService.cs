using Models;

namespace Application.Services
{
    public interface ITodoService
    {
        public Task<List<Todo>> GetAll();

        public Task<Todo> GetById(int id);

        public Task<Todo> Add(Todo model);

        public Task Update(Todo model);

        public Task TodoIsCompleted(int id);

        public Task Delete(int id);
    }
}
