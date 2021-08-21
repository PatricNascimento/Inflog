using Infolog.Domain.Entities;
using Infolog.Domain.Repositores;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infolog.DataAccess
{
    public class CrudRepository<T> : ICrudRepository<T> where T : BaseEntity
    {
        protected readonly InfologDbContext _dbContext;

        public CrudRepository(InfologDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            await Delete(entity);
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public async Task Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateMany(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().UpdateRange(entities);
            await _dbContext.SaveChangesAsync();
        }
    }
}