using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C2INFRA_SQL.Dapper;
using Dapper;
using System.Data;

namespace C2INFRA_SQL.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly DapperContext _context;
        public EmpresaRepository(DapperContext context)
        {
            _context = context;
        }

        public List<EmpresaCustomEntity> ListarParaSelect()
        {
            using (var db = _context.DapperConexao())
            {
                db.Open();
                string query = "select Id, GuidId, Nome from Empresa where EmpresaStatus = 1";
                return [.. db.Query<EmpresaCustomEntity>(query, commandType: CommandType.Text)];
            };
        }
    }
}
