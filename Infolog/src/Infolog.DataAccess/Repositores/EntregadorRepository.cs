using Infolog.Domain.Entities;
using Infolog.Domain.Repositores;

namespace Infolog.DataAccess.Repositores
{
    public class EntregadorRepository : CrudRepository<Entregador>, IEntregadorRepository
    {
        public EntregadorRepository(InfologDbContext dbContext) : base(dbContext)
        {

        }
    }
}
