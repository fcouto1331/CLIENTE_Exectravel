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
        void Deletar(Guid GuidId);

        #endregion

        #region Dados da Transação

        void CriarLoteTransacaoDados(List<TransacaoDadosDTO> transacaoDados);
        void CriarTransacaoDados(TransacaoDadosDTO transacaoDados);
        TransacaoDadosDTO PegarTransacaoDadosPorGuidId(Guid GuidId);
        void AtualizarTransacaoDados(TransacaoDadosDTO transacaoDados);
        void DeletarTransacaoDados(Guid GuidId);

        #endregion
    }
}
