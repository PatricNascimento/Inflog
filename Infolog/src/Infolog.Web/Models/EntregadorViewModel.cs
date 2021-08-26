using Infolog.Domain.Entities;
using System.Collections.Generic;

namespace Infolog.Web.Models
{
    public class EntregadorViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string Moto { get; set; }
        public string Placa { get; set; }
        
    }

    public class ListEntregadorViewModel
    {
        public ListEntregadorViewModel()
        {
            this.Entregadores = new List<Entregador>();
        }

        public IList<Entregador> Entregadores { get; set; }
    }
}