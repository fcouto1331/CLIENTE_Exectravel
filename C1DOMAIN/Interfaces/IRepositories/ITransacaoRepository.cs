using C1DOMAIN.Entities;

namespace C1DOMAIN.Interfaces.IRepositories
{
    public interface ITransacaoRepository
    {
        #region Transação

        List<TransacaoEntity> Listar();
        List<TransacaoCustomEntity> ListarCustom();
        void Criar(TransacaoEntity transacao);
        TransacaoEntity PegarPorGuidId(Guid GuidId);
        void Deletar(Guid GuidId);

        #endregion

        #region Dados da Transação

        void CriarLoteTransacaoDados(List<TransacaoDadosEntity> transacaoDados);
        void CriarTransacaoDados(TransacaoDadosEntity transacaoDados);
        TransacaoDadosEntity PegarTransacaoDadosPorGuidId(Guid GuidId);
        void AtualizarTransacaoDados(TransacaoDadosEntity transacaoDados);
        void DeletarTransacaoDados(Guid GuidId);

        #endregion
    }
}
