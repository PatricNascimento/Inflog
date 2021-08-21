using Infolog.Domain.Entities;
using Infolog.Domain.Repositores;
using Infolog.Web.Models;

using Microsoft.AspNetCore.Mvc;

using System.Linq;
using System.Threading.Tasks;

namespace Infolog.Web.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        #region Telas
        public IActionResult Index()
        {
            var usuarios = usuarioRepository.GetAll().OrderBy(u => u.Nome).ToList();
            var model = new ListUsuarioViewModel();
            model.Usuarios = usuarios;

            return View(model);
        }

        public IActionResult Incluir()
        {
            return RedirectToAction("Editar", new { id = 0 });
        }

        public async Task<IActionResult> Editar(int id)
        {
            var model = new UsuarioViewModel();

            if (id == 0)
                return View(model);

            var usuario = await usuarioRepository.GetById(id);

            model.Id = usuario.Id;
            model.Nome = usuario.Nome;
            model.Sobrenome = usuario.Sobrenome;
            model.Email = usuario.Email;

            return View(model);
        }
        #endregion

        #region Ações
        public async Task<IActionResult> Salvar(UsuarioViewModel model)
        {
            if(model.Id == 0)
            {
                var usuario = new Usuario(model.Nome, model.Sobrenome, model.Email, model.Senha);
                await usuarioRepository.Create(usuario);
            }
            else
            {
                var usuario = await usuarioRepository.GetById(model.Id);

                usuario.Nome = model.Nome;
                usuario.Sobrenome = model.Sobrenome;
                usuario.Email = model.Email;

                if (!string.IsNullOrEmpty(model.Senha) && !string.IsNullOrWhiteSpace(model.Senha))
                    usuario.Senha = model.Senha;

                await usuarioRepository.Update(usuario);
            }

            return RedirectToAction("Index");
        }
        #endregion
    }
}