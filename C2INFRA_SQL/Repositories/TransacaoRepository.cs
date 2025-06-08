using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C2INFRA_SQL.Dapper;
using Dapper;
using System.Data;
using System.Text;

namespace C2INFRA_SQL.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly DapperContext _context;
        public TransacaoRepository(DapperContext context)
        {
            _context = context;
        }

        #region Transação

        public List<TransacaoEntity> Listar()
        {
            throw new NotImplementedException();
        }

        public List<TransacaoCustomEntity> ListarCustom()
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                StringBuilder query = new StringBuilder();
                query.Append(" SELECT t.Id, t.GuidId, t.TransacaoDataCadastro, t.TransacaoDataAtualizacao, t.Empresa_Id, t.Mes, t.Ano, t.PeriodoIni, t.PeriodoFim, e.Nome as EmpresaNome FROM Transacao as t");
                query.Append(" inner join Empresa as e on e.Id = t.Empresa_Id");
                return [.. db.Query<TransacaoCustomEntity>(query.ToString(), commandType: CommandType.Text)];
            }
        }

        public void Criar(TransacaoEntity transacao)
        {
            throw new NotImplementedException();
        }

        public TransacaoEntity PegarPorGuidId(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Dados da Transação

        public void CriarLoteTransacaoDados(List<TransacaoDadosEntity> transacaoDados)
        {
            throw new NotImplementedException();
        }

        public void CriarTransacaoDados(TransacaoDadosEntity transacaoDados)
        {
            throw new NotImplementedException();
        }

        public TransacaoDadosEntity PegarTransacaoDadosPorGuidId(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public void AtualizarTransacaoDados(TransacaoDadosEntity transacaoDados)
        {
            throw new NotImplementedException();
        }

        public void DeletarTransacaoDados(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
