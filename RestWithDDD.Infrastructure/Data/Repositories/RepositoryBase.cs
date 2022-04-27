using RestWithDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestWithDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly InfraContext _databaseContext;

        public RepositoryBase(InfraContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _databaseContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _databaseContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Add(TEntity entity)
        {
            try
            {
                await _databaseContext.Set<TEntity>().AddAsync(entity);
                await _databaseContext.SaveChangesAsync();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(TEntity entity)
        {
            try
            {
                _databaseContext.Set<TEntity>().Remove(entity);
                await _databaseContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task Update(TEntity entity)
        {
            try
            {
                _databaseContext.Entry(entity).State = EntityState.Modified;
                await _databaseContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
