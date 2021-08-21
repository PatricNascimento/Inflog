using Infolog.Domain.Entities;
using Infolog.Domain.Repositores;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infolog.DataAccess.Repositores
{
    public class ClienteRepository : CrudRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(InfologDbContext dbContext) : base(dbContext)
        {

        }
    }
}