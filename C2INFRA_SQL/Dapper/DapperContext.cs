using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace C2INFRA_SQL.Dapper
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _conexao;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _conexao = _configuration.GetConnectionString("conexao") ?? throw new InvalidOperationException("conexao não encontrada.");
        }

        public IDbConnection DapperConexao() => new SqlConnection(_conexao);
    }
}
