using C3APPLICATION.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace C4PRESENTATION_WEB.Controllers
{
    public class BasePopulateController : Controller
    {
        private readonly IBasePopulateApp _app;
        public BasePopulateController(IBasePopulateApp app)
        {
            _app = app ?? throw new ArgumentNullException(nameof(app));
        }

        [HttpGet]
        public IActionResult ListarNApartamentosJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNApartamentos(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNAprovadorJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNAprovador(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNAutorizacaoCartaoJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNAutorizacaoCartao(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNBilheteJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNBilhete(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNDespesaJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNDespesa(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNEmbarqueJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNEmbarque(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNFaturaNumeroJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNFaturaNumero(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNLocalizadorJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNLocalizador(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNMotivoDaViagemJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNMotivoDaViagem(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNNomeFornecedorJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNNomeFornecedor(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNNumeroCartaoJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNNumeroCartao(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNPassageiroJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNPassageiro(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNProdutoJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNProduto(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNQtDiariasJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNQtDiarias(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNRegimeJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNRegime(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNReservaJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNReserva(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNRotaCompletaJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNRotaCompleta(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNSolicitanteJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNSolicitante(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNVeiculoJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNVeiculo(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarNVoucherJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", basePopulate = _app.ListarNVoucher(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

    }
}
