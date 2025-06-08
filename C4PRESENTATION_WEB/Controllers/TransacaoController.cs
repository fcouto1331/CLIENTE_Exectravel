using C1DOMAIN.Interfaces.IRepositories;
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
            try
            {
                var transacao = _app.ListarCustom();
                return View("Listar");
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                return RedirectToAction("Error");
            }
        }
    }
}
