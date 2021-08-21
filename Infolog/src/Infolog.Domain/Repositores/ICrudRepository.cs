using Infolog.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infolog.Domain.Repositores
{
    public interface ICrudRepository<T> where T : BaseEntity
    {
        Task Create(T entity);
        Task Delete(int id);
        Task Delete(T entity);
        Task<T> GetById(int id);
        IQueryable<T> GetAll();
        Task Update(T entity);
        Task UpdateMany(IEnumerable<T> entities);
    }
}