using Infolog.Domain.Entities;
using System.Collections.Generic;

namespace Infolog.Web.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int CodEnderecoPrincipal { get; set; }
        public virtual EnderecoViewModel EnderecoPrincipal { get; set; }

    }

    public class ListClienteViewModel
    {
        public ListClienteViewModel()
        {
            this.Clientes = new List<Cliente>();
        }

        public IList<Cliente> Clientes { get; set; }
    }
}