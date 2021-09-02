using Infolog.Domain.Entities;
using Infolog.Domain.Repositores;
using Infolog.Web.Models;

using Microsoft.AspNetCore.Mvc;

using System.Linq;
using System.Threading.Tasks;

namespace Infolog.Web.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteRepository clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        #region Telas
        public IActionResult Index()
        {
            var cliente = clienteRepository.GetAll().OrderBy(u => u.NomeFantasia).ToList();
            var model = new ListClienteViewModel();
            model.Clientes = cliente;

            return View(model);
        }

        public IActionResult Incluir()
        {
            return RedirectToAction("Editar", new { id = 0 });
        }

        public async Task<IActionResult> Editar(int id)
        {
            var model = new ClienteViewModel();

            if (id == 0)
                return View(model);

            var cliente = await clienteRepository.GetById(id);

            model.Id = cliente.Id;
            model.NomeFantasia = cliente.NomeFantasia;
            model.RazaoSocial = cliente.RazaoSocial;
            model.Cnpj = cliente.Cnpj;
            model.Telefone = cliente.Telefone;
            model.Celular = cliente.Celular;
           // model.EnderecoPrincipal = cliente.EnderecoPrincipal;
            
            return View(model);
        }
        #endregion

        #region Ações
        public async Task<IActionResult> Salvar(ClienteViewModel model)
        {
            if (model.Id == 0)
            {
               // var cliente = new Cliente(model.NomeFantasia, model.RazaoSocial, model.Cnpj, model.Telefone, model.Celular, model.EnderecoPrincipal);
               //await clienteRepository.Create(cliente);
            }
            else
            {
                var cliente = await clienteRepository.GetById(model.Id);

                model.NomeFantasia = cliente.NomeFantasia;
                model.RazaoSocial = cliente.RazaoSocial;
                model.Cnpj = cliente.Cnpj;
                model.Telefone = cliente.Telefone;
                model.Celular = cliente.Celular;
                //model.EnderecoPrincipal = cliente.EnderecoPrincipal;

            }

            return RedirectToAction("Index");
        }
        #endregion
    }
}