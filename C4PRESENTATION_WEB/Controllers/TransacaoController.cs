using C1DOMAIN.Interfaces.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace C4PRESENTATION_WEB.Controllers
{
    public class TransacaoController : Controller
    {
        private readonly ITransacaoRepository _repository;
        public TransacaoController(ITransacaoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                _repository.ListarCustom();
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
