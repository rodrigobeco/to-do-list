using Infraestructure.Repositories;
using Models;

namespace Application.Services
{
    public class TodoService: ITodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Todo>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Todo> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Todo> Add(Todo model)
        {
            return await _repository.Add(model);
        }

        public async Task Update(Todo model)
        {
            await _repository.Update(model);
        }

        public async Task TodoIsCompleted(int id)
        {
            var model = await _repository.GetById(id);

            if (model == null) { throw new KeyNotFoundException(); }

            model.IsCompleted = true;
            await _repository.Update(model);
        }

        public async Task Delete(int id)
        {
            var model = await _repository.GetById(id);

            if (model == null) { throw new KeyNotFoundException(); }

            await _repository.Delete(model);
        }
    }
}
