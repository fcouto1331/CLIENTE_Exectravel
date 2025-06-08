using C1DOMAIN.Interfaces.IRepositories;
using C3APPLICATION.DTOs;
using C3APPLICATION.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace C4PRESENTATION_WEB.Controllers
{
    public class TransacaoController : Controller
    {
        private readonly ITransacaoApp _app;
        public TransacaoController(ITransacaoApp app)
        {
            _app = app ?? throw new ArgumentNullException(nameof(app));
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View("Listar");
        }

        [HttpPost]
        public IActionResult JsonListar()
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", transacao = _app.ListarCustom() });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }
    }
}
