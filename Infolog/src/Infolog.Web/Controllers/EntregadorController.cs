using Infolog.Domain.Entities;
using Infolog.Domain.Repositores;
using Infolog.Web.Models;

using Microsoft.AspNetCore.Mvc;

using System.Linq;
using System.Threading.Tasks;

namespace Infolog.Web.Controllers
{
    public class EntregadorController : Controller
    {

        private readonly IEntregadorRepository entregadorRepository;

        public EntregadorController(IEntregadorRepository entregadorRepository)
        {
            this.entregadorRepository = entregadorRepository;
        }

        #region Telas
        public IActionResult Index()
        {
            var entregadores = entregadorRepository.GetAll().OrderBy(u => u.Nome).ToList();
            var model = new ListEntregadorViewModel();
            model.Entregadores = entregadores;

            return View(model);
        }

        public IActionResult Incluir()
        {
            return RedirectToAction("Editar", new { id = 0 });
        }

        public async Task<IActionResult> Editar(int id)
        {
            var model = new EntregadorViewModel();

            if (id == 0)
                return View(model);

            var entregador = await entregadorRepository.GetById(id);

            model.Id = entregador.Id;
            model.Nome = entregador.Nome;
            model.Sobrenome = entregador.Sobrenome;
            model.Telefone = entregador.Telefone;
            model.Celular = entregador.Celular;
            model.Endereco = entregador.Endereco;
            model.Veiculo = entregador.Veiculo;
            model.Placa = entregador.Placa;

            return View(model);
        }
        #endregion

        #region Ações
        public async Task<IActionResult> Salvar(EntregadorViewModel model)
        {
            if (model.Id == 0)
            {
                var entregador = new Entregador(model.Nome, model.Sobrenome, model.Telefone, model.Celular, model.Endereco, model.Veiculo, model.Placa);
                await entregadorRepository.Create(entregador);
            }
            else
            {
                var entregador = await entregadorRepository.GetById(model.Id);

                entregador.Nome = model.Nome;
                entregador.Sobrenome = model.Sobrenome;
                entregador.Telefone = model.Telefone;
                entregador.Celular = model.Celular;
                entregador.Endereco = model.Endereco;
                entregador.Veiculo = model.Veiculo;
                entregador.Placa = model.Placa;

                
            }

            return RedirectToAction("Index");
        }
        #endregion
    }
}