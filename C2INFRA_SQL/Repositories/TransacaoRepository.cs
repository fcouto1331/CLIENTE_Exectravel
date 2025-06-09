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
                query.Append(" SELECT t.Id, t.GuidId, t.TransacaoDataCadastro, t.TransacaoDataAtualizacao, t.EmpresaId, t.Mes, t.Ano, t.PeriodoIni, t.PeriodoFim, e.Nome as EmpresaNome FROM Transacao as t");
                query.Append(" inner join Empresa as e on e.Id = t.EmpresaId");
                query.Append(" order by t.TransacaoDataCadastro desc;");
                return [.. db.Query<TransacaoCustomEntity>(query.ToString(), commandType: CommandType.Text)];
            }
        }

        public void Criar(TransacaoEntity transacao)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                StringBuilder query = new StringBuilder();
                query.Append(" insert into Transacao (TransacaoDataAtualizacao, EmpresaId, Mes, Ano, PeriodoIni, PeriodoFim) values (@TransacaoDataAtualizacao, @Empresa_Id, @Mes, @Ano, @PeriodoIni, @PeriodoFim);");
                DynamicParameters parameters = new DynamicParameters();
                //parameters.Add("Nome", String.IsNullOrEmpty(transacao.Nome) ? DBNull.Value : transacao.Nome, dbType: DbType.String);
                parameters.Add("TransacaoDataAtualizacao", DateTime.Now, DbType.DateTime);
                parameters.Add("Empresa_Id", transacao.EmpresaId, DbType.Int32);
                parameters.Add("Mes", transacao.Mes, DbType.Int32);
                parameters.Add("Ano", transacao.Ano, DbType.Int32);
                parameters.Add("PeriodoIni", transacao.PeriodoIni, DbType.DateTime);
                parameters.Add("PeriodoFim", transacao.PeriodoFim, DbType.DateTime);
                db.Execute(query.ToString(), parameters, commandType: CommandType.Text);
            }
        }

        public TransacaoEntity PegarPorGuidId(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                StringBuilder query = new StringBuilder();
                query.Append(" SELECT t.Id, t.GuidId, t.TransacaoDataCadastro, t.TransacaoDataAtualizacao, t.EmpresaId, t.Mes, t.Ano, t.PeriodoIni, t.PeriodoFim FROM Transacao as t");
                query.Append(" WHERE t.GuidId = @GuidId;");
                return db.QueryFirst<TransacaoEntity>(query.ToString(), new { GuidId = GuidId }, commandType: CommandType.Text);
            }
        }

        public void Atualizar(TransacaoEntity transacao)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                StringBuilder query = new StringBuilder();
                query.Append(" update Transacao");
                query.Append(" set EmpresaId = @EmpresaId,");
                query.Append(" Mes = @Mes,");
                query.Append(" Ano = @Ano,");
                query.Append(" PeriodoIni = @PeriodoIni,");
                query.Append(" PeriodoFim = @PeriodoFim,");
                query.Append(" TransacaoDataAtualizacao = getdate()");
                query.Append(" WHERE GuidId = @GuidId;");
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("EmpresaId", transacao.EmpresaId, DbType.Int32);
                parameters.Add("Mes", transacao.Mes, DbType.Int32);
                parameters.Add("Ano", transacao.Ano, DbType.Int32);
                parameters.Add("PeriodoIni", transacao.PeriodoIni, DbType.DateTime);
                parameters.Add("PeriodoFim", transacao.PeriodoFim, DbType.DateTime);
                parameters.Add("GuidId", transacao.GuidId, DbType.Guid);
                db.Execute(query.ToString(), parameters, commandType: CommandType.Text);
            }
        }

        public void Deletar(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                StringBuilder query = new StringBuilder();
                query.Append(" declare @Id int = (select Id from Transacao where GuidId = @GuidId);");
                query.Append(" delete from TransacaoDados where TransacaoId = @Id;");
                query.Append(" delete from Transacao where Id = @Id;");
                db.Execute(query.ToString(), new { GuidId = GuidId }, commandType: CommandType.Text);
            }
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
