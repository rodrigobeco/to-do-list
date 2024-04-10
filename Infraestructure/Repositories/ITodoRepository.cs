using Models;

namespace Infraestructure.Repositories
{
    public interface ITodoRepository
    {
        public Task<List<Todo>> GetAll();

        public Task<Todo> GetById(int id);

        public Task<Todo> Add(Todo model);

        public Task Update(Todo model);

        public Task Delete(Todo model);
    }
}