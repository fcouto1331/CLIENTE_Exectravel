using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C2INFRA_SQL.Dapper;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.Text;
using Z.Dapper.Plus;

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

        public List<TransacaoDadosEntity> ListarTransacaoDados(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<TransacaoDadosLiteEntity> ListarTransacaoDadosLite(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                StringBuilder query = new StringBuilder();
                query.Append(" declare @Id int = (select Id from Transacao where GuidId = @GuidId);");
                query.Append(" SELECT Id, GuidId, TransacaoDadosDataCadastro, TransacaoDadosDataAtualizacao, TransacaoId, CCusto, TotalCliente FROM TransacaoDados");
                query.Append(" WHERE TransacaoId = @Id;");
                return [.. db.Query<TransacaoDadosLiteEntity>(query.ToString(), new { GuidId = GuidId }, commandType: CommandType.Text)];
            }
        }

        public void CriarLoteTransacaoDados(List<TransacaoDadosEntity> transacaoDados)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();

                //db.BulkInsert(transacaoDados, options =>
                //{
                //    options.TableName = "TransacaoDados";
                //    options.BatchSize = 1000; // Define o tamanho do lote para inserção
                //    options.AutoMap = true; // Mapeia automaticamente as propriedades da entidade para as colunas da tabela
                //});

                db.BulkInsert(transacaoDados);
            }
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

        public List<TransacaoDadosGraficoEntity> ListarTransacaoDadosGrafico(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                StringBuilder query = new StringBuilder();
                query.Append(" declare @Id int = (select Id from Transacao where GuidId = @GuidId);");
                query.Append(" SELECT CCusto, Sum(TotalCliente) as TotalCliente FROM TransacaoDados where TransacaoId = @Id group by CCusto;");
                return [.. db.Query<TransacaoDadosGraficoEntity>(query.ToString(), new { GuidId = GuidId }, commandType: CommandType.Text)];
            }
        }

        public List<TransacaoDadosGraficoEntity> ListarTransacaoDadosGraficoDinamico(GraficoDinamicoFormEntity graficoDinamicoForm)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                StringBuilder query = new StringBuilder();
                DynamicParameters parameters = new DynamicParameters();

                query.Append(" SELECT CCusto, Sum(TotalCliente) as TotalCliente FROM TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidID)");

                parameters.Add("GuidID", graficoDinamicoForm.GuidId, DbType.Guid);

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NSolicitante))
                {
                    string[] nSolicitante = graficoDinamicoForm.NSolicitante
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NSolicitante in @NSolicitante");
                    parameters.Add("NSolicitante", nSolicitante);
                }  

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NAutorizacaoCartao))
                {
                    string[] nAutorizacaoCartao = graficoDinamicoForm.NAutorizacaoCartao
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NAutorizacaoCartao in @NAutorizacaoCartao");
                    parameters.Add("NAutorizacaoCartao", nAutorizacaoCartao);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NReserva))
                {
                    string[] nReserva = graficoDinamicoForm.NReserva
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NReserva in @NReserva");
                    parameters.Add("NReserva", nReserva);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NAprovador))
                {
                    string[] nAprovador = graficoDinamicoForm.NAprovador
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NAprovador in @NAprovador");
                    parameters.Add("NAprovador", nAprovador);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NMotivoDaViagem))
                {
                    string[] nMotivoDaViagem = graficoDinamicoForm.NMotivoDaViagem
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NMotivoDaViagem in @NMotivoDaViagem");
                    parameters.Add("NMotivoDaViagem", nMotivoDaViagem);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NPassageiro))
                {
                    string[] nPassageiro = graficoDinamicoForm.NPassageiro
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NPassageiro in @NPassageiro");
                    parameters.Add("NPassageiro", nPassageiro);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NProduto))
                {
                    string[] nProduto = graficoDinamicoForm.NProduto
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NProduto in @NProduto");
                    parameters.Add("NProduto", nProduto);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NDespesa))
                {
                    string[] nDespesa = graficoDinamicoForm.NDespesa
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NDespesa in @NDespesa");
                    parameters.Add("NDespesa", nDespesa);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NNomeFornecedor))
                {
                    string[] nNomeFornecedor = graficoDinamicoForm.NNomeFornecedor
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NNomeFornecedor in @NNomeFornecedor");
                    parameters.Add("NNomeFornecedor", nNomeFornecedor);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NLocalizador))
                {
                    string[] nLocalizador = graficoDinamicoForm.NLocalizador
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NLocalizador in @NLocalizador");
                    parameters.Add("NLocalizador", nLocalizador);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NBilhete))
                {
                    string[] nNBilhete = graficoDinamicoForm.NBilhete
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NBilhete in @NBilhete");
                    parameters.Add("NBilhete", nNBilhete);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NRotaCompleta))
                {
                    string[] nRotaCompleta = graficoDinamicoForm.NRotaCompleta
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NRotaCompleta in @NRotaCompleta");
                    parameters.Add("NRotaCompleta", nRotaCompleta, DbType.String);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NVeiculo))
                {
                    string[] nVeiculo = graficoDinamicoForm.NVeiculo
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NVeiculo in @NVeiculo");
                    parameters.Add("NVeiculo", nVeiculo);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NVoucher))
                {
                    string[] nVoucher = graficoDinamicoForm.NVoucher
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NVoucher in @NVoucher");
                    parameters.Add("NVoucher", nVoucher);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NApartamentos))
                {
                    string[] nApartamentos = graficoDinamicoForm.NApartamentos
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NApartamentos in @NApartamentos");
                    parameters.Add("NApartamentos", nApartamentos);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NRegime))
                {
                    string[] nRegime = graficoDinamicoForm.NRegime
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NRegime in @NRegime");
                    parameters.Add("NRegime", nRegime);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NQtDiarias))
                {
                    // Converte a string "1,2,3" em um array de int
                    int[] qtDiariasArray = graficoDinamicoForm.NQtDiarias
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => int.Parse(s.Trim()))
                        .ToArray();

                    // Adiciona o filtro na query
                    query.Append(" and NQtDiarias in @NQtDiarias");

                    // Passa o array como parâmetro para o Dapper
                    parameters.Add("NQtDiarias", qtDiariasArray);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NFaturaNumero))
                {
                    string[] nFaturaNumero = graficoDinamicoForm.NFaturaNumero
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NFaturaNumero in @NFaturaNumero");
                    parameters.Add("NFaturaNumero", nFaturaNumero);
                }

                if (!string.IsNullOrEmpty(graficoDinamicoForm.NNumeroCartao))
                {
                    string[] nNumeroCartao = graficoDinamicoForm.NNumeroCartao
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .ToArray();

                    query.Append(" and NNumeroCartao in (@NNumeroCartao)");
                    parameters.Add("NNumeroCartao", nNumeroCartao);
                }

                query.Append(" group by CCusto;");
                return [.. db.Query<TransacaoDadosGraficoEntity>(query.ToString(), parameters, commandType: CommandType.Text)];
            }
        }

        #endregion
    }
}
