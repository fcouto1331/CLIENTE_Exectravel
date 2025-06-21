using C3APPLICATION.DTOs;
using C3APPLICATION.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace C4PRESENTATION_WEB.Controllers
{
    public class TransacaoController : Controller
    {
        private readonly ITransacaoApp _app;
        private readonly IEmpresaApp _appEmpresa;

        public TransacaoController(ITransacaoApp app, IEmpresaApp appEmpresa)
        {
            _app = app ?? throw new ArgumentNullException(nameof(app));
            _appEmpresa = appEmpresa ?? throw new ArgumentNullException(nameof(appEmpresa));
        }

        #region Transação

        [HttpGet]
        public IActionResult Listar()
        {
            return View("Listar");
        }

        [HttpGet]
        public IActionResult ListarJson()
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

        [HttpPost]
        public JsonResult CriarJson([FromBody] TransacaoDTO transacao)
        {
            try
            {
                _app.Criar(transacao);
                return Json(new { ret = true, msg = "Sucesso." });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult PegarPorIdJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", transacao = _app.PegarPorGuidId(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpPut]
        public JsonResult AtualizarJson([FromBody] TransacaoDTO transacao)
        {
            try
            {
                _app.Atualizar(transacao);
                return Json(new { ret = true, msg = "Sucesso." });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult DeletarJson(Guid GuidId)
        {
            try
            {
                _app.Deletar(GuidId);
                return Json(new { ret = true, msg = "Sucesso." });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        #endregion

        #region Empresa

        [HttpGet]
        public IActionResult ListarEmpresaJson()
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", empresa = _appEmpresa.ListarParaSelect() });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        #endregion

        #region Dados da Transação

        [HttpGet]
        public IActionResult ListarTransacaoDadosJson(Guid GuidId)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", transacao = _app.ListarTransacaoDadosLite(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult CriarLoteTransacaoDadosJson([FromForm] TransacaoDadosExcelFormDTO transacaoDadosExcelForm)
        {
            try
            {
                if (transacaoDadosExcelForm.Arquivo == null || transacaoDadosExcelForm.Arquivo.Length == 0) return Json(new { ret = false, msg = "Arquivo inválido." });
                 _app.CriarLoteTransacaoDados(transacaoDadosExcelForm);                
                return Json(new { ret = true, msg = "Sucesso." });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult Grafico(Guid TransacaoId) 
        {
            ViewBag.GuidId = TransacaoId;
            return View("Grafico");
        }

        [HttpGet]
        public IActionResult ListarGraficoJson(Guid GuidId)
        {
            try
            {
              return Json(new { ret = true, msg = "Sucesso.", transacaoDados = _app.ListarTransacaoDadosGrafico(GuidId) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GraficoDinamico(Guid TransacaoId)
        {
            ViewBag.GuidId = TransacaoId;
            return View("GraficoDinamico");
        }

        [HttpPost]
        public JsonResult ListarGraficoDinamicoJson([FromBody] GraficoDinamicoFormDTO graficoDinamicoFormDTO)
        {
            try
            {
                return Json(new { ret = true, msg = "Sucesso.", transacaoDados = _app.ListarTransacaoDadosGraficoDinamico(graficoDinamicoFormDTO) });
            }
            catch (Exception ex)
            {
                return Json(new { ret = false, msg = ex.Message });
            }
        }

        #endregion

    }

}