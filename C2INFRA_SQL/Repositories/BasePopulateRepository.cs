using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C2INFRA_SQL.Dapper;
using Dapper;

namespace C2INFRA_SQL.Repositories
{
    public class BasePopulateRepository : IBasePopulateRepository
    {
        private readonly DapperContext _context;
        public BasePopulateRepository(DapperContext context)
        {
            _context = context;
        }

        public List<BasePopulateEntity> ListarNApartamentos(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NApartamentos as BValue, NApartamentos as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NApartamentos";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNAprovador(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NAprovador as BValue, NAprovador as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NAprovador";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNAutorizacaoCartao(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NAutorizacaoCartao as BValue, NAutorizacaoCartao as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NAutorizacaoCartao";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNBilhete(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NBilhete as BValue, NBilhete as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NBilhete";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNCheckIn(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNCheckOut(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNDataSolicitacao(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNDespesa(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NDespesa as BValue, NDespesa as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NDespesa";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNEmbarque(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNFaturaNumero(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NFaturaNumero as BValue, NFaturaNumero as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NFaturaNumero";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNLocalizador(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NLocalizador as BValue, NLocalizador as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NLocalizador";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNMotivoDaViagem(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NMotivoDaViagem as BValue, NMotivoDaViagem as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NMotivoDaViagem";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNNomeFornecedor(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NNomeFornecedor as BValue, NNomeFornecedor as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NNomeFornecedor";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNNumeroCartao(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NNumeroCartao as BValue, NNumeroCartao as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NNumeroCartao";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNPassageiro(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NPassageiro as BValue, NPassageiro as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NPassageiro";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNProduto(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NProduto as BValue, NProduto as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NProduto";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNQtDiarias(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select cast(NQtDiarias as varchar) as BValue, cast(NQtDiarias as varchar) as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NQtDiarias";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNRegime(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NRegime as BValue, NRegime as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NRegime";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNReserva(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NReserva as BValue, NReserva as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NReserva";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNRotaCompleta(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NRotaCompleta as BValue, NRotaCompleta as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NRotaCompleta";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNSolicitante(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NSolicitante as BValue, NSolicitante as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NSolicitante";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNTarifaCliente(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNTaxaDU(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNTaxaEmbarque(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNTaxasTotal(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNVeiculo(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NVeiculo as BValue, NVeiculo as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NVeiculo";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }

        public List<BasePopulateEntity> ListarNVoucher(Guid GuidId)
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select NVoucher as BValue, NVoucher as BText from TransacaoDados where TransacaoId = (select Id from Transacao where GuidId = @GuidId) group by NVoucher";
                return [.. db.Query<BasePopulateEntity>(query, new { GuidId }).AsList()];
            }
        }
    }
}
