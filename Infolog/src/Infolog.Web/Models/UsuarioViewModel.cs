using Infolog.Domain.Entities;
using System.Collections.Generic;

namespace Infolog.Web.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class ListUsuarioViewModel
    {
        public ListUsuarioViewModel()
        {
            this.Usuarios = new List<Usuario>();
        }

        public IList<Usuario> Usuarios { get; set; }
    }
}