using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IServices;
using C3APPLICATION.DTOs;
using C3APPLICATION.Interfaces;
using C3APPLICATION.Mapster;

namespace C3APPLICATION.Services
{
    public class TransacaoApp : ITransacaoApp
    {
        public readonly ITransacaoService _service;
        public TransacaoApp(ITransacaoService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        #region Transação

        public List<TransacaoDTO> Listar()
        {
            throw new NotImplementedException();
        }

        public List<TransacaoCustomDTO> ListarCustom() => Mapper.ToListTransacaoCustomDTO(_service.ListarCustom());

        public void Criar(TransacaoDTO transacao) => _service.Criar(Mapper.ToTransacaoEntity(transacao));

        public TransacaoDTO PegarPorGuidId(Guid GuidId) => Mapper.ToTransacaoDTO(_service.PegarPorGuidId(GuidId));

        public void Atualizar(TransacaoDTO transacao) => _service.Atualizar(Mapper.ToTransacaoEntity(transacao));

        public void Deletar(Guid GuidId) => _service.Deletar(GuidId);

        #endregion

        #region Dados da Transação

        public List<TransacaoDadosDTO> ListarTransacaoDados(Guid GuidId) 
        {
            throw new NotImplementedException();
        }

        public List<TransacaoDadosLiteDTO> ListarTransacaoDadosLite(Guid GuidId) => Mapper.ToListTransacaoDadosLiteDTO(_service.ListarTransacaoDadosLite(GuidId));

        public void CriarLoteTransacaoDados(TransacaoDadosExcelFormDTO transacaoDadosExcelForm) => _service.CriarLoteTransacaoDados(Mapper.ToTransacaoDadosExcelFormEntity(transacaoDadosExcelForm));

        public void CriarTransacaoDados(TransacaoDadosDTO transacaoDados)
        {
            throw new NotImplementedException();
        }

        public TransacaoDadosDTO PegarTransacaoDadosPorGuidId(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public void AtualizarTransacaoDados(TransacaoDadosDTO transacaoDados)
        {
            throw new NotImplementedException();
        }

        public void DeletarTransacaoDados(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<TransacaoDadosGraficoDTO> ListarTransacaoDadosGrafico(Guid GuidId) => Mapper.ToListTransacaoDadosGraficoDTO(_service.ListarTransacaoDadosGrafico(GuidId));

        public List<TransacaoDadosGraficoDTO> ListarTransacaoDadosGraficoDinamico(GraficoDinamicoFormDTO graficoDinamicoForm) => Mapper.ToListTransacaoDadosGraficoDTO(_service.ListarTransacaoDadosGraficoDinamico(Mapper.ToGraficoDinamicoFormEntity(graficoDinamicoForm)));

        #endregion
    }
}
