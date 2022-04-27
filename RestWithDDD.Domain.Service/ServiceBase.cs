using RestWithDDD.Domain.Core.Interfaces.Repositories;
using RestWithDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task Add(TEntity entity)
        {
            await _repository.Add(entity);
        }

        public async Task Delete(TEntity entity)
        {
            await _repository.Delete(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(TEntity entity)
        {
            await _repository.Update(entity);
        }
    }
}
