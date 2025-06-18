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
        void Atualizar(TransacaoEntity transacao);
        void Deletar(Guid GuidId);

        #endregion

        #region Dados da Transação

        List<TransacaoDadosEntity> ListarTransacaoDados(Guid GuidId);
        List<TransacaoDadosLiteEntity> ListarTransacaoDadosLite(Guid GuidId);
        void CriarLoteTransacaoDados(List<TransacaoDadosEntity> transacaoDados);
        void CriarTransacaoDados(TransacaoDadosEntity transacaoDados);
        TransacaoDadosEntity PegarTransacaoDadosPorGuidId(Guid GuidId);
        void AtualizarTransacaoDados(TransacaoDadosEntity transacaoDados);
        void DeletarTransacaoDados(Guid GuidId);
        List<TransacaoDadosGraficoEntity> ListarTransacaoDadosGrafico(Guid GuidId);

        #endregion
    }
}
