using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Infolog.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger)
        {
        }

        #region Telas
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
        #endregion

        #region Ações
        public IActionResult Salvar()
        {
            return View();
        }

        public IActionResult Deletar()
        {
            return RedirectToAction("Index");
        }
        #endregion
    }
}