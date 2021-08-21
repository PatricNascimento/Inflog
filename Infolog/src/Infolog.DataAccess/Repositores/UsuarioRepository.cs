using Infolog.Domain.Entities;
using Infolog.Domain.Repositores;

namespace Infolog.DataAccess.Repositores
{
    public class UsuarioRepository : CrudRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(InfologDbContext dbContext) : base(dbContext)
        {
        }
    }
}