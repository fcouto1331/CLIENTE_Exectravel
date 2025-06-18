using C1DOMAIN.Entities;
using C3APPLICATION.DTOs;

namespace C3APPLICATION.Interfaces
{
    public interface ITransacaoApp
    {
        #region Transação

        List<TransacaoDTO> Listar();
        List<TransacaoCustomDTO> ListarCustom();
        void Criar(TransacaoDTO transacao);
        TransacaoDTO PegarPorGuidId(Guid GuidId);
        void Atualizar(TransacaoDTO transacao);
        void Deletar(Guid GuidId);

        #endregion

        #region Dados da Transação

        List<TransacaoDadosDTO> ListarTransacaoDados(Guid GuidId);
        List<TransacaoDadosLiteDTO> ListarTransacaoDadosLite(Guid GuidId);
        void CriarLoteTransacaoDados(TransacaoDadosExcelFormDTO transacaoDadosExcelForm);
        void CriarTransacaoDados(TransacaoDadosDTO transacaoDados);
        TransacaoDadosDTO PegarTransacaoDadosPorGuidId(Guid GuidId);
        void AtualizarTransacaoDados(TransacaoDadosDTO transacaoDados);
        void DeletarTransacaoDados(Guid GuidId);
        List<TransacaoDadosGraficoDTO> ListarTransacaoDadosGrafico(Guid GuidId);


        #endregion
    }
}
